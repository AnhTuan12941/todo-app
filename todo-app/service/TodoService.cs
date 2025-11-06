using todo_app.controller;
using todo_app.entity;
using todo_app.exception;
using todo_app.repository;

namespace todo_app.service;

public class TodoService
{
    private TagRepository _tagRepository;
    private TodoRepository _todoRepository;
    private LoggedInAccount _loggedInAccount;

    public TodoService(Controller controller)
    {
        _tagRepository = controller.TagRepository;
        _todoRepository = controller.TodoRepository;
        _loggedInAccount = controller.LoggedInAccount;
    }
    
    public void Create(string? content, DateTime? dueDate, Tag? tag)
    {
        if (string.IsNullOrEmpty(content))
        {
            throw new AppException("Nội dung công việc không hợp lệ.");
        }
        if (dueDate == null) 
        {
            throw new AppException("Ngày hết hạn không hợp lệ.");
        }
        if (tag == null)
        {
            throw new AppException("Danh sách không hợp lệ.");
        }
        
        Todo todo = new Todo();
        todo.Content = content;
        todo.DueDate = dueDate.Value;
        todo.TagId = tag.Id;
        _todoRepository.Create(todo);
    }
    
    public List<Todo> FindByTagId(int tagId)
    {
        return _todoRepository.FindByTagId(tagId).ToList();
    }

    public void UpdateDueDate(int id, DateTime? dueDate)
    {
        var todo = _todoRepository.FindById(id);
        if (todo == null)
        {
            throw new AppException("Tác vụ không tồn tại.");
        }
        if (dueDate == null)
        {
            throw new AppException("Ngày hết hạn không hợp lệ.");
        }
        todo.DueDate = dueDate.Value;
        _todoRepository.Update(todo);
    }

    public void UpdateNote(int id, string? note)
    {
        var todo = _todoRepository.FindById(id);
        if (todo == null)
        {
            throw new AppException("Tác vụ không tồn tại.");
        }
        todo.Note = note ?? string.Empty;
        _todoRepository.Update(todo);
    }

    public void Delete(int id)
    {
        _todoRepository.Delete(id);
    }

    public void CheckTodo(int id, bool isDone)
    {
        var todo = _todoRepository.FindById(id);
        if (todo == null)
        {
            throw new AppException("Tác vụ không tồn tại.");
        }

        todo.IsDone = isDone;
        _todoRepository.Update(todo);
    }

    public List<Todo> SearchTodos(string? keyword)
    {
        if (string.IsNullOrEmpty(keyword))
        {
            throw new AppException("Từ khóa tìm kiếm không hợp lệ.");
        }

        List<Todo> todos = new List<Todo>();
        List<Tag> tags = (List<Tag>) _tagRepository.FindByAccountId(_loggedInAccount.GetId());

        foreach (var tag in tags)
        {
            var tagTodos = _todoRepository.FindByTagId(tag.Id);
            foreach (var todo in tagTodos)
            {
                if (todo.Content.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                    (todo.Note.Contains(keyword, StringComparison.OrdinalIgnoreCase)))
                {
                    todos.Add(todo);
                }
            }
        }

        return todos; // Trả về danh sách đã lọc theo cả Content và Note
    }
}   