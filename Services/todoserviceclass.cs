using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Service
{
    class todoclassservice : Itodo
    {
        private readonly TodoContext _context;

        public todoclassservice (TodoContext context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task CreateAsync(TodoItem item)
        {
            /*if (item == null)
                {
                    // return BadRequest();
                }*/
            _context.tblProductInfo.Add(item);
          await _context.SaveChangesAsync();
                
        }
        [HttpGet]
        public async Task <List<TodoItem>> GetAllAsync()
        {
                return await _context.tblProductInfo.ToListAsync();
        }

        [HttpGet("{id}")]
            public async Task<TodoItem> GetbyIdAsync(int id)
            {
                try{
                TodoItem item = await _context.tblProductInfo.FindAsync(id);
                if (item == null)
                {
                    // return NotFound();
                }
               return item;
            }catch(Exception ex)
            {
                    throw new Exception(ex.Message);
            }
            } 

            [HttpPut("{id}")]
        public async Task UpdateAsync(int id,[FromBody] TodoItem item)
        {
            if (item == null || item.ID != id)
                    {
                        // return BadRequest();
                    }

                    var todo = _context.tblProductInfo.FirstOrDefault(t => t.ID == id);
                    if (todo == null)
                    {
                        // return NotFound();
                    }

                    todo.GroupID = item.GroupID;
                    todo.ID = item.ID ;    
                    todo.Name = item.Name;
                    todo.Description = item.Description;
                    todo.Rate = item.Rate;

                    _context.tblProductInfo.Update(todo);
                   await _context.SaveChangesAsync();
                    // return await new NoContentResultAsync();
        }

        [HttpDelete("{id}")]
                public async Task DeleteAsync(int id)
                {
                    var todo = _context.tblProductInfo.FirstOrDefault(t => t.ID == id);
                    if (todo == null)
                    {
                        // return NotFound();
                    }

                    _context.tblProductInfo.Remove(todo);
                   await _context.SaveChangesAsync();
                    // return new NoContentResult();
                } 
        
    }
}