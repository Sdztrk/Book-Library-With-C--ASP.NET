using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using Microsoft.AspNetCore.Mvc;


namespace api.Controllers
{


    [Route("api/v1/book")]
    [ApiController]


    public class BookControllers : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public BookControllers(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet]

        public IActionResult GetAll()
        {
            var books = _context.books.ToList();
            return Ok(books);
        }

        [HttpGet("{id}")]

        public IActionResult GetById([FromRoute] int id)
        {
            var book = _context.books.Find(id);
            if(book == null){
                return NotFound();
            }
            
            return Ok(book);
        }


    }

}