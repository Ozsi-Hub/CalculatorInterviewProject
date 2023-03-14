using MediatR;
using CalculatorInterview.Web.Dto;

namespace CalculatorInterview.BLL.Dto
{
    public class HistoryBllDto : IRequest<List<HistoryResponseDto>>
    {
        public string? Descriptionfilter { get; set; }
    }
}
