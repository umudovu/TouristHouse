using MediatR;
using Microsoft.AspNetCore.Mvc;
using TouristHouse.Application.Features.Commands.AnnounceCommands.HomeAnnounce;
using TouristHouse.Application.Features.Commands.AnnounceCommands.RemoveAnnounce;
using TouristHouse.Application.Features.Queries.Announce.GetAllAnnounce;
using TouristHouse.Application.Features.Queries.Announce.GetByIdAnnounce;

namespace TouristHouse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnounceController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AnnounceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        


        [HttpPost("createhome")]
        public async Task<IActionResult> Create([FromForm] CreateHomeAnnounceCommandRequest createHome)
        {
            var response = await _mediator.Send(createHome);

            return Ok(response);
        }


        [HttpGet("item/{id}")]
        public async Task<IActionResult>GetById([FromRoute]GetByIdAnnounceQueryRequest getByIdAnnounceQueryRequest)
        {
            GetByIdAnnounceQueryResponse response = await _mediator.Send(getByIdAnnounceQueryRequest);

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromRoute]GetAllAnnounceQueryRequest getAllAnnounceQueryRequest)
        {
            GetAllAnnounceQueryResponse response = await _mediator.Send(getAllAnnounceQueryRequest);

            return Ok(response);
        }

        [HttpDelete()]
        public async Task<IActionResult>RemoveAnnounce([FromQuery]RemoveAnnounceCommandRequest removeAnnounceCommandRequest)
        {
            RemoveAnnounceCommandResponse response = await _mediator.Send(removeAnnounceCommandRequest);

            return Ok(response);
        }
    }
}
