using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using CalculatorInterview.BLL.Dto;
using CalculatorInterview.Web.Dto;

namespace CalculatorInterview
{
    [Route("api/history")]
    [ApiController]
    public class HistoryController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;
        public HistoryController(IMediator mediator,
            IMapper mapper)
        {
            this.mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<List<HistoryResponseDto>> Gethistory(string? descriptionFilter = null)
        {
            return await mediator.Send(new HistoryBllDto { Descriptionfilter = descriptionFilter });
        }

    }
}
