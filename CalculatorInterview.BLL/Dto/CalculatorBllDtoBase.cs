using MediatR;
using CalculatorInterview.Web.Dto;

namespace CalculatorInterview.BLL.Dto
{
    public class CalculatorBllDtoBase : CalculateDto, IRequest<int[]>
    {
    }
}
