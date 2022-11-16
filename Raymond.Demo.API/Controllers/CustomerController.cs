using Microsoft.AspNetCore.Mvc;
using System.Reflection.PortableExecutable;
using System;
using Newtonsoft.Json;
using Raymond.Demo.API.Model;
using Microsoft.AspNetCore.Hosting.Server;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Raymond.Demo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {


      
        // GET: api/<ValuesController1>
        [HttpGet]
        public JsonResult Get()
        {
           
            //https://northwind.netcore.io/customers
            HttpClient http = new HttpClient(); // for live hosted data from 
            var data = http.GetAsync("https://northwind.netcore.io/customers?format=json").Result.Content.ReadAsStringAsync().Result;
            Serializer customer = JsonConvert.DeserializeObject<Serializer>(data);
            return new JsonResult(customer);

        }

        // GET api/<ValuesController1>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController1>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController1>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController1>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

   
}
