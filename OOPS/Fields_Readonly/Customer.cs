namespace MyCSLearning
{
    partial class Program
    {
        public class Customer
        {
            public int Id;
            public string Name;
            public readonly List<Order> Orders = new List<Order>();

            public Customer(int id)
            {
                this.Id = id;
                
            }
            public Customer(int id, string name)
                :this(id)
            {
                this.Name = name;
            }

            public void Promote()
            {
                //Orders = new List<Order>(); -> error as it is readonly
            }

        }

    }
}
