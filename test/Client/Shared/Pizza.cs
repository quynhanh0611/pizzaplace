namespace PizzaPlace_2022.Shared
{
    public class Pizza
    {
        public Pizza(int id, string name, decimal price,Spiciness sp
            )
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Spiciness = Spiciness;
        }
        public int Id { get;  }
        public string Name { get; }
        public decimal Price { get; }
        public object Spiciness { get; }
        public Spiciness Spiceness { get; }
    }
}
