using MediatR;
using CalculatorInterview.BLL.Dto;

namespace CalculatorInterview.BLL
{
    public class CCalculatorHandler : IRequestHandler<CCalculatorBllDto, int[]>
    {
        public Task<int[]> Handle(CCalculatorBllDto request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}