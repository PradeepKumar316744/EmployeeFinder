using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeFinder.Model;
using Microsoft.AspNetCore.Mvc;
using EmployeeFinder.Service;
using System.Data;

namespace EmployeeFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private EmployeeService employeeService;

        // GET api/values
        [HttpGet]
        public ActionResult<EmployeeDataAccess.EmployeeDataSet.EmployeeDataTable> Get()
        {
            employeeService = new EmployeeService();
            var result = employeeService.GetAll();
            return result;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<object[]> Get(int id)
        {
            employeeService = new EmployeeService();

            var result =  employeeService.GetEmployeeByID(id).ItemArray;

            return result;

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
