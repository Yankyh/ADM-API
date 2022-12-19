namespace ERP.BACKEND.MODULE.PERSON.Controllers
{
    using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs;
    using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs.Requests.User;
    using ERP.BACKEND.MODULE.PERSON.APPLICATION.Interfaces;
    using ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities;
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

        [HttpPost]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] UserGetAllRequest request)
        {
            try
            {
                var entity = await _app.GetAll(request);
                return new OkObjectResult(entity);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("Authenticate")]
        public async Task<IActionResult> Authenticate(UserAuthenticateRequest user)
        {
            try
            {
                var entity = await _app.Authenticate(user);
                return new OkObjectResult(entity);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
