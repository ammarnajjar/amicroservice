
namespace amicroservice.Models.Builder
{
    public class SuperComputerBuilder : IComputerBuilder
    {
        public string CPU { get; set; }
        public string Color { get; set; }
        public string Resolution { get; set; }

        public Computer GetResult()
        {
            return CPU == "SuperCPU" ? new Computer(CPU, "", "SuperGPU", "256GB", Color, Resolution) : null;
        }
    }
}
