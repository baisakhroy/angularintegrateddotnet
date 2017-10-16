using System; 
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoApi.Service;


namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        private readonly TodoContext _context;

        private Itodo _service;

        public TodoController(TodoContext context, Itodo service)
        {
            _context = context; 
            _service = service;

            if (_context.tblProductInfo.Count() == 0)
            { 
                _context.tblProductInfo.Add(new TodoItem { Name = "Item1" });
                _context.SaveChanges();
            }
        } 
        

            [HttpGet]
            public Task<List<TodoItem>> GetAllAsync()
            {
                // try{
                // return await _context.tblProductInfo.ToListAsync();
                // }catch(Exception ex)
                // {
                //     throw new Exception(ex.Message);
                // }
              return _service.GetAllAsync();
            }

           [HttpGet("{id}")]
            public Task<TodoItem> GetbyIdAsync(int id)
            {
            //     try{
            //     TodoItem item = await _context.tblProductInfo.FindAsync(id);
            //     if (item == null)
            //     {
            //         // return NotFound();
            //     }
            //    return item;
            // }catch(Exception ex)
            // {
            //         throw new Exception(ex.Message);
            // }
          return _service.GetbyIdAsync(id);
            
           
            }  
 
            [HttpPost]
            public  Task CreateAsync([FromBody] TodoItem item)
            {
                  
            //     if (item == null)
            //     {
            //         // return BadRequest();
            //     }

            //     _context.tblProductInfo.Add(item);
            //   await _context.SaveChangesAsync();

            //     // return await CreatedAtRoute("GetTodo", new { id = item.ID }, item);
            return _service.CreateAsync(item);
            } 

            [HttpPut("{id}")]
                public  Task UpdateAsync(int id, [FromBody] TodoItem item)
                {
                //     if (item == null || item.ID != id)
                //     {
                //         // return BadRequest();
                //     }

                //     var todo = _context.tblProductInfo.FirstOrDefault(t => t.ID == id);
                //     if (todo == null)
                //     {
                //         // return NotFound();
                //     }

                //     todo.GroupID = item.GroupID;
                //     todo.ID = item.ID ;    
                //     todo.Name = item.Name;
                //     todo.Description = item.Description;
                //     todo.Rate = item.Rate;

                //     _context.tblProductInfo.Update(todo);
                //    await _context.SaveChangesAsync();
                //     // return new NoContentResult();
                return _service.UpdateAsync(id,item); 
                } 

                [HttpDelete("{id}")]
                public  Task DeleteAsync(int id)
                {
                //     var todo = _context.tblProductInfo.FirstOrDefault(t => t.ID == id);
                //     if (todo == null)
                //     {
                //         // return NotFound();
                //     }

                //     _context.tblProductInfo.Remove(todo);
                //    await _context.SaveChangesAsync();
                //     // return new NoContentResult();

                return _service.DeleteAsync(id);
                } 







    }
}