namespace Accelerantx.MVCWebApp.Models
{
    public class Calculation
    {
        public int Input1 { get; set; }
        public int Input2 { get; set; }
        public Operation Operator { get; set; }
        public int? Result { get; set; }
    }

    public enum Operation
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
}