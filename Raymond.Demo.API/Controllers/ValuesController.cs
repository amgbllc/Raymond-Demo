using Microsoft.AspNetCore.Mvc;
using Raymond.Demo.API.Model;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Raymond.Demo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public List<Employee> Employees { get; set; }
        // GET: api/<ValuesController>
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            Employees = Enumerable.Range(1, 50).Select(x => new Employee()
            {
                EmployeeID=0+x,
      LastName= "ALFKI",
      FirstName="ANTON",
      Title="Artist",
      TitleOfCourtesy="Owner",
      Address="Apple Street",
      City="Dallas",
      PostalCode=76543

                //EmployeeID = 0 + x,
                //LastName = 
                //(new string[] { "ALFKI", "ANANTR", "ANTON", "BLONP", "BOLID" })
                //[new Random().Next(5)],
            }).ToList();

            return Employees;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
