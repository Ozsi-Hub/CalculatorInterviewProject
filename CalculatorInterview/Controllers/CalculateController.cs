using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using CalculatorInterview.BLL.Dto;
using CalculatorInterview.Web.Dto;

namespace CalculatorInterview
{
    [Route("api/calculate")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;
        public CalculateController(IMediator mediator,
            IMapper mapper)
        {
            this.mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [Route("a")]
        [HttpGet]
        public async Task<int[]> CalculateA(CalculateDto input)
        {
            return await mediator.Send(mapper.Map<ACalculatorBllDto>(input));
        }

        [Route("b")]
        [HttpGet]
        public async Task<int[]> CalculateB(CalculateDto input)
        {
            return await mediator.Send(mapper.Map<BCalculatorBllDto>(input));
        }

        [Route("c")]
        [HttpGet]
        public async Task<int[]> CalculateC(CalculateDto input)
        {
            return await mediator.Send(mapper.Map<CCalculatorBllDto>(input));
        }
    }
}
