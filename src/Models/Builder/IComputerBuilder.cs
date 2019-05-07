
namespace amicroservice.Models.Builder
{
    public interface IComputerBuilder
    {
        string CPU { get; set; }
        string Resolution { get; set; }
        string Color { get; set; }

        Computer GetResult();
    }
}