using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using System.Web.Http;
using ZR.Demo.API.DataContract;
using ZR.Demo.Domains;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ZR.Demo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ApiController
    {
        [HttpGet("GetAll")]
        [SwaggerOperation("GetAll")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Employee>), description: "Success")]
        [SwaggerResponse(statusCode: 404, type: typeof(InlineResponse400), description: "Not Found")]
        [SwaggerResponse(statusCode: 500, type: typeof(List<Employee>), description: "Internal Error")]
        public async Task<IActionResult> Get()
        {
            //dummy code for now


            return null;
            
        }
    }
}
