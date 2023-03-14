namespace CalculatorInterview.DataAccess.Domain
{
    public class History
    {
        public int Id { get; set; } 
        public string Array { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string DateTime { get; set; } = default!;
        public string Output { get; set; } = default!;
    }
}