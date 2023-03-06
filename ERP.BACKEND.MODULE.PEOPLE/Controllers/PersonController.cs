namespace PeopleManagement.Api
{
    using PeopleManagement.Application.DTOs;
    using PeopleManagement.Application.Interfaces;
    using PeopleManagement.Domain.Entities;
    using Microsoft.AspNetCore.Mvc;
    using PeopleManagement.Application.DTOs.Requests.Person;

    [ApiController]
    [Route("api/[controller]")]

    public class PersonController : Controller
    {
        IPersonApplication _application;
        public PersonController(IPersonApplication application)
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
        public async Task<IActionResult> GetAll([FromQuery] PersonGetAllRequest request)
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
        public async Task<IActionResult> Add([FromBody] PersonAddRequest request)
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
        public async Task<IActionResult> Update(Guid id, [FromBody] PersonUpdateRequest data)
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
