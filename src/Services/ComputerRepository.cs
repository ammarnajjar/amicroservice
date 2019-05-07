using Microsoft.AspNetCore.Http;
using amicroservice.Models.Builder;

namespace amicroservice.Services
{
    public class ComputerRepository
    {
        private SuperComputerBuilder _superComputerBuilder;
        private SuperComputerBuildDirector _superComputerBuildDirector;

        private LaptopBuilder _laptopBuilder;
        private LaptopBuildDirector _laptopBuildDirector;

        public ComputerRepository()
        {
            _laptopBuilder = new LaptopBuilder();
            _laptopBuildDirector = new LaptopBuildDirector(_laptopBuilder);
            _superComputerBuilder = new SuperComputerBuilder();
            _superComputerBuildDirector = new SuperComputerBuildDirector(_superComputerBuilder);
        }
        public Computer[] AllComputers
        {
            get
            {
                _laptopBuildDirector.Construct();
                Computer laptop = _laptopBuilder.GetResult();

                _superComputerBuildDirector.Construct();
                Computer superComputer = _superComputerBuilder.GetResult();

                return new Computer[] { laptop, superComputer };
            }
        }
    }
}
