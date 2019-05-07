
namespace amicroservice.Models.Builder
{
    public class Computer
    {
        public string CPU { get; set; }
        public string Mark { get; set; }
        public string GPU { get; set; }
        public string RAM { get; set; }
        public string Color { get; set; }
        public string Resolution { get; set; }

        public Computer(string cpu, string mark, string gpu, string ram, string color, string resolution)
        {
            CPU = cpu;
            Mark = mark;
            GPU = gpu;
            RAM = ram;
            Color = color;
            Resolution = resolution;
        }
    }
}