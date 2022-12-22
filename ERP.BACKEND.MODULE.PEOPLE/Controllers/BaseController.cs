namespace PeopleManagement.Api
{
    using PeopleManagement.Application.DTOs;
    using PeopleManagement.Application.DTOs.Requests;
    using PeopleManagement.Application.Interfaces;
    using PeopleManagement.Domain.Entities;
    using Microsoft.AspNetCore.Mvc;

    [Produces("application/json")]
    [Route("api/[controller]")]
    public class BaseController<Entity, EntityDTO> : Controller
         where Entity : EntityBase
         where EntityDTO : BaseDTO
    {
        readonly protected IApplicationBase<Entity, EntityDTO, DefaultFilterRequest> _application;

        public BaseController(IApplicationBase<Entity, EntityDTO, DefaultFilterRequest> application)
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

     /*   [HttpPost]
        public async Task<IActionResult> Add([FromBody] EntityDTO data)
        {
            try
            {
                return new OkObjectResult(await _application.Add(data));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }*/

       /* [HttpPut]
        public async Task<IActionResult> Update([FromBody] EntityDTO data)
        {
            try
            {
                return new OkObjectResult(await _application.Update(data));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }*/

      /*  [HttpDelete]
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
        }*/
    }
}
