using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Angular5CRUD.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Angular5CRUD.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {

        EmployeeDataAccessLayer objemployee = new EmployeeDataAccessLayer();
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return objemployee.GetAllEmployee();
        }

        [HttpGet]
        [Route("api/Employee/Index")]
        public IEnumerable<Employee> Index()
        {
            return objemployee.GetAllEmployee();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
