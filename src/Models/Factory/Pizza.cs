
// Factory Pattern
namespace amicroservice.Models.Factory
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        public static Pizza MargheritaPizza()
        {
            return new Pizza { Id = 2, Name = "Margherita", Category = "Vegetarian" };
        }

        public static Pizza SalamiPizza()
        {
            return new Pizza { Id = 1, Name = "Salami", Category = "Meat" };
        }

        public static Pizza Default()
        {
            return MargheritaPizza();
        }
    }
}