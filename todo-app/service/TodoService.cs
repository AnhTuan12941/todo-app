using todo_app.controller;
using todo_app.entity;
using todo_app.exception;
using todo_app.repository;

namespace todo_app.service;

public class TodoService
{
    private TodoRepository _todoRepository;
    
    public TodoService(Controller controller)
    {
        _todoRepository = controller.TodoRepository;
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
    
    public void Update(Todo newTodo)
    {
        _todoRepository.Update(newTodo);
    }

    public void Delete(int id)
    {
        _todoRepository.Delete(id);
    }
}   