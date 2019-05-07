
namespace amicroservice.Models.Builder
{
    public class LaptopBuilder : IComputerBuilder
    {
        public string CPU { get; set; }
        public string Color { get; set; }
        public string Resolution { get; set; }

        public Computer GetResult()
        {
            return CPU == "LaptopCPU" ? new Computer(CPU, "", "LaptopGPU", "16GB", Color, Resolution) : null;
        }
    }
}
