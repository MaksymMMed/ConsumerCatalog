using BLL.DTO.Response;
using BLL.Services.Interfaces;
using DAL.Exceptions;
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

        public ConsumerController(IConsumerService consumerService)
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
        public async Task<ActionResult<ConsumerResponse>> GetConsumersAync()
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

        [HttpGet("GetConsumersRep")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<DAL.Entities.Consumer>> GetConsumersRepAync()
        {
            try
            {
                return Ok(await consumerRepository.GetAsync());
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
        public async Task<ActionResult<UnitResponse>> GetUnitsOfConsumer(int id,[FromQuery] UnitParameters parameters)
        {
            try
            {
                return Ok(await consumerService.GetUnitsAsync(id,parameters));
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
