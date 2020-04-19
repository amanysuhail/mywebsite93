using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myweb.API.Data;
using Microsoft.EntityFrameworkCore;


namespace myweb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;

        }
        // GET api/values
        //يعرضلي الموجود في قاعدة البيانات كل القيم
        [HttpGet]
        public async Task <IActionResult> GetValues()
        {
            var values =await _context.values.ToListAsync();
            return Ok (values);
        }

        // GET api/values/5
        /*يعرضلي فقط رقم الايدي الي ادخله يعني اذا
         كتبت 1 هو حيعرضلي قيمه الايدي 1 الي دخلنا
         في قاعدة البيانات
        */
        [HttpGet("{id}")]
        public async Task <IActionResult> GetValue(int id)
        {
            var value=await _context.values.FirstOrDefaultAsync(x=>x.id==id);
            return Ok (value);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
