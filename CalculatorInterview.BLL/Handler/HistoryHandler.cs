using MediatR;
using CalculatorInterview.BLL.Dto;
using CalculatorInterview.Web.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorInterview.BLL.Handler
{
    public class HistoryHandler : IRequestHandler<HistoryBllDto, List<HistoryResponseDto>>
    {
        public Task<List<HistoryResponseDto>> Handle(HistoryBllDto request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
