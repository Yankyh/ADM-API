using Microsoft.AspNetCore.Mvc;
using PeopleManagement.Application.DTOs.Requests.Person;
using PeopleManagement.Application.DTOs.Requests.PersonContact;
using PeopleManagement.Application.Interfaces;

namespace PeopleManagement.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonContactController : Controller
    {
        IPersonContactApplication _application;
        public PersonContactController(IPersonContactApplication application)
        {
            this._application = application;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                var entity = await _application.GetById(id);
                return new OkObjectResult(entity);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] PersonContactGetAllRequest request)
        {
            try
            {
                var entity = await _application.GetAll(request);
                return new OkObjectResult(entity);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] PersonContactAddRequest request)
        {
            try
            {
                return new OkObjectResult(await _application.Add(request));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] PersonContactUpdateRequest data)
        {
            try
            {
                data.Id = id;
                return new OkObjectResult(await _application.Update(data));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                return new OkObjectResult(await _application.Delete(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
