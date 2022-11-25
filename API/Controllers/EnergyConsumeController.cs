using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL.Services;
using BLL.Services.Interfaces;
using DAL.Pagination;
using BLL.DTO.Response;
using DAL.Parameters;
using API.Extensions;
using DAL.Exceptions;
using BLL.DTO.Request;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class energyConsumeController : ControllerBase
    {
        private readonly IEnergyConsumeService energyConsumeService;

        public energyConsumeController(IEnergyConsumeService energyConsumeService)
        {
            this.energyConsumeService = energyConsumeService;
        }

        [HttpGet("GetEnergyConsumes")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<EnergyConsumeResponse>>> GetEnergyConsumes()
        {
            try
            {
                return Ok(await energyConsumeService.GetAsync());
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet("GetEnergyConsumesPagedList")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<PagedList<EnergyConsumeResponse>>> GetEnergyConsumesPagedList([FromQuery] EnergyConsumeParameters parameters)
        {
            try
            {
                var item = await energyConsumeService.GetAsync(parameters);
                Response.Headers.Add("X-serialization", item.SerializeMetadata());
                return Ok(item);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpPost("AddEnergyConsume")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> AddEnergyConsume([FromQuery] EnergyConsumeRequest request)
        {
            try
            {
                await energyConsumeService.InsertAsync(request);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpPut("UpdateEnergyConsume")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> UpdateEnergyConsume([FromQuery] EnergyConsumeRequest request)
        {
            try
            {
                await energyConsumeService.UpdateAsync(request);
                return Ok();
            }
            catch (EntityNotFoundException e)
            {
                return NotFound(new { e.Message });
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpDelete("DeleteEnergyConsume")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteEnergyConsume(int id)
        {
            try
            {
                await energyConsumeService.DeleteAsync(id);
                return Ok();
            }
            catch (EntityNotFoundException e)
            {
                return NotFound(new { e.Message });
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}
