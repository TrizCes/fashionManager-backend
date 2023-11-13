using fashionManager.Dto.Companies.Request;
using fashionManager.Dto.Users.Response;
using fashionManager.Interfaces.Services;
using fashionManager.Models.Enums;

using fashionManagerAPI.Attributes;

using Microsoft.AspNetCore.Mvc;

namespace fashionManager.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
        [Authorize(RoleEnum.Admin)]
        public class CompaniesController : ControllerBase
        {
            private readonly ICompaniesService _service;

            public CompaniesController(ICompaniesService service)
            {
                _service = service;
            }

            [HttpPost]
            [AllowAnonymous]
            public async Task<IActionResult> Post([FromBody] PostCompanies company)
            {
                var result = await _service.CreateAsync(company);

                return Created("companies", result);
            }

            [HttpGet("{id}")]
            public async Task<IActionResult> Get([FromRoute] int id)
            {
                var changer = (UsersResponse)HttpContext.Items["User"]!;
                return Ok(await _service.GetByIdAsync(changer.CompanyId));
            }

            [HttpPut("{id}")]
            public async Task<IActionResult> Put([FromRoute] int id, [FromBody] PutCompanies company)
            {
                return Ok(await _service.UpdateAsync(id, company));
            }

            [HttpDelete("{id}")]
            public async Task<IActionResult> Delete([FromRoute] int id)
            {
                return Ok(await _service.DeleteAsync(id));
            }
        }
}

