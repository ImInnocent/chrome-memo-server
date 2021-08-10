using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ChromeMemo.Models;
using ChromeMemo.Services;

namespace ChromeMemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MemoController : ControllerBase
    {
        // GET by Id action
        [HttpGet("{id}")]
        public ActionResult<Memo> Get(int id)
        {
            var memo = MemoService.Get(id);

            if(memo == null)
                return NotFound();

            return memo;
        }

        // POST action
        [HttpPost]
        public IActionResult Create()
        {
            int userId = MemoService.Add();
            return CreatedAtAction(nameof(Create), new { id = userId });
        }

        // PUT action
        [HttpPut("{id}")]
        public IActionResult Update(int id, Memo memo)
        {
            if (id != memo.Id)
                return BadRequest();

            var existingPizza = MemoService.Get(id);
            if (existingPizza is null)
                return NotFound();

            MemoService.Update(memo);

            return NoContent();
        }
    }
}