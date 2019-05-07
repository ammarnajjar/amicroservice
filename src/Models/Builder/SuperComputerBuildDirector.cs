

namespace amicroservice.Models.Builder
{
    public class SuperComputerBuildDirector
    {
        private IComputerBuilder _builder;

        public SuperComputerBuildDirector(IComputerBuilder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.CPU = "SuperCPU";
            _builder.Color = "SuperBlack";
            _builder.Resolution = "SuperResolution";
        }
    }
}