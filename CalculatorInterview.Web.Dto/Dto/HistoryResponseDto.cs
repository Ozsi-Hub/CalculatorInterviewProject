
namespace CalculatorInterview.Web.Dto
{
    public class HistoryResponseDto
    {
        public int Id { get; set; }
        public string Array { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string DateTime { get; set; } = default!;
        public string Output { get; set; } = default!;
    }
}
