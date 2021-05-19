using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using RC.MongoDBApi.Domains;
using RC.MongoDBApi.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RC.MongoDBApi.Controllers
{
    [ApiController]
    [Route("v1/mongodb")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository )
        {
            this.employeeRepository = employeeRepository;
        }

        [HttpPost]
        [Route("")]
        public async Task Post([FromBody] Employee employee)
        {
            await this.employeeRepository.InsertOneAsync(employee);
        }

        [HttpGet]
        [Route("employeeId:string")]
        public async Task<Employee> Get(string employeeId)
        {
            return await this.employeeRepository.FindByIdAsync(employeeId);
        }

        [HttpDelete]
        [Route("employeeId:string")]
        public async Task Delete(string employeeId)
        {
            await this.employeeRepository.DeleteByIdAsync(employeeId);
        }

        [HttpPut]
        [Route("")]
        public async Task Update([FromBody] Employee employee)
        {
             await this.employeeRepository.ReplaceOneAsync(employee);
        }


        [HttpGet]
        [Route("")]
        public IEnumerable<Employee> Get()
        {
            return this.employeeRepository.FilterBy(x => x.Id != null);
        }

    }
}