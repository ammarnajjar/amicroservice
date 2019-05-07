
namespace amicroservice.Models.Builder
{
    public class LaptopBuildDirector
    {
        private IComputerBuilder _builder;

        public LaptopBuildDirector(IComputerBuilder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.CPU = "LaptopCPU";
            _builder.Color = "LaptopBlack";
            _builder.Resolution = "LaptopResolution";
        }
    }
}