using API.Extensions;
using BLL.DTO.Response;
using BLL.Services.Interfaces;
using DAL.Exceptions;
using DAL.Pagination;
using DAL.Parameters;
using DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumerController : ControllerBase
    {
        private readonly IConsumerService consumerService;
        private readonly IConsumerRepository consumerRepository;

        public ConsumerController(IConsumerService consumerService,IConsumerRepository consumerRepository)
        {
            this.consumerService = consumerService;
            this.consumerRepository = consumerRepository;
        }

        [HttpGet("GetCompleteEntityById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ConsumerResponse>> GetCompleteByIdAsync(int id)
        {
            try
            {
                return Ok(await consumerService.GetCompleteEntityById(id));
            }
            catch (EntityNotFoundException e)
            {
                return NotFound(new { e.Message });
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }

        [HttpGet("GetConsumers")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable <ConsumerResponse>>> GetConsumersAync()
        {
            try
            {
                return Ok(await consumerService.GetAsync());
            }
            catch (EntityNotFoundException e)
            {
                return NotFound(new { e.Message });
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }

        [HttpGet("GetConsumersPagedList")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<PagedList<ConsumerResponse>>> GetConsumersPagedListAync([FromQuery] ConsumerParameters parameters)
        {
            try
            {
                var item = await consumerService.GetAsync(parameters);
                Response.Headers.Add("X-Pagination", item.SerializeMetadata());
                return Ok(item);
            }
            catch (EntityNotFoundException e)
            {
                return NotFound(new { e.Message });
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }


        [HttpGet("GetUnitsOfConsumer")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<UnitResponse>>> GetUnitsOfConsumer(int id)
        {
            try
            {
                return Ok(await consumerService.GetUnitsAsync(id));
            }
            catch (EntityNotFoundException e)
            {
                return NotFound(new { e.Message });
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }

        [HttpGet("GetConsumesOfConsumer")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<EnergyConsumeResponse>>> GetConsumesOfConsumer(int id)
        {
            try
            {
                return Ok(await consumerService.GetConsumesAsync(id));
            }
            catch (EntityNotFoundException e)
            {
                return NotFound(new { e.Message });
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }
    }
}
