using Microsoft.AspNetCore.Mvc;
using ChromeMemo.Models;
using ChromeMemo.Services;

namespace ChromeMemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserInfoController : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<Memo> Get(int id)
        {
            UserInfo memo = MemoService.Get(id);

            if(memo == null)
                return NotFound();

            return memo;
        }
    }
}