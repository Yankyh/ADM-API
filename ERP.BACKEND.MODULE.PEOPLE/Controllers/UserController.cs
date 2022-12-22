namespace PeopleManagement.Api
{
    using PeopleManagement.Application.DTOs;
    using PeopleManagement.Application.DTOs.Requests.User;
    using PeopleManagement.Application.Interfaces;
    using PeopleManagement.Domain.Entities;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]

    public class UserController : BaseController<User, UserDTO>
    {
        IUserApplication _app;
        public UserController(IUserApplication app) : base(app)
        {
            this._app = app;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAll([FromQuery] UserGetAllRequest request)
        {
            try
            {
                var entity = await _app.GetAll(request);
                return new OkObjectResult(entity);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] UserAddRequest request)
        {
            try
            {
                return new OkObjectResult(await _app.Add(request));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("Authentication")]
        public async Task<IActionResult> Authenticate(UserAuthenticationRequest user)
        {
            try
            {
                var entity = await _app.Authentication(user);
                return new OkObjectResult(entity);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UserUpdateRequest data)
        {
            try
            {
                return new OkObjectResult(await _app.Update(data));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
