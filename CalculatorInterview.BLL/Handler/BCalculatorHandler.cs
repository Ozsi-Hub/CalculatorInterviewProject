using MediatR;
using CalculatorInterview.BLL.Dto;

namespace CalculatorInterview.BLL
{
    public class BCalculatorHandler : IRequestHandler<BCalculatorBllDto, int[]>
    {
        public Task<int[]> Handle(BCalculatorBllDto request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}