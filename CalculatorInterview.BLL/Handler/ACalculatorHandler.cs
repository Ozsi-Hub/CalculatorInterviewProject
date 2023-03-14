using MediatR;
using CalculatorInterview.BLL.Dto;

namespace CalculatorInterview.BLL
{
    public class ACalculatorHandler : IRequestHandler<ACalculatorBllDto, int[]>
    {
        public Task<int[]> Handle(ACalculatorBllDto request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}