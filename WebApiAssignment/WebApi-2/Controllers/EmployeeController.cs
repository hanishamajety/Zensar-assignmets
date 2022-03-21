using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeApi2.Models;

namespace WeApi2.Controllers
{
    
    public class EmployeeController : ApiController
    {
        zensardbEntities zensardb = new zensardbEntities();

        public IHttpActionResult GetEmployeeSalById(int eid)
        {
            var details = zensardb.getEmployeeSalary(eid).ToList();
            return Ok(details);
        }
    }
}
