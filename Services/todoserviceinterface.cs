using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Service
{
    public  interface Itodo
    {
        Task CreateAsync(TodoItem item);
        Task <List<TodoItem>> GetAllAsync();

        Task<TodoItem> GetbyIdAsync(int id);
        Task UpdateAsync(int id, TodoItem item);

        Task DeleteAsync(int id);

    }
}