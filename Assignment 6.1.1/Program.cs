namespace Assignment_6._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implement a single linked list with each node representing a house. You may add data in it like house number, brief address, type of house ( like Ranch, Colonial) .
            //each house (node) will be linked to next .Give facility to the user to search a house by its number and then display the details. ( Windows / Console)

            LinkedList houseList = new LinkedList();
            houseList.AddHouse(1, "123 Ellenwood Drive, Texarkana AR", "Mobile Home");
			houseList.AddHouse(2, "456 Oak St", "Semi-Detached");
			houseList.AddHouse(3, "789 Pine St", "Terraced");

            Console.WriteLine("Enter a house number: (1,2, or 3)");

			int number = int.Parse(Console.ReadLine());
			houseList.SearchByHouseNumber(number);
		}

        public class House
        {
            public int Number { get; set; }
            public string Address { get; set; }
            public string Type { get; set; }
            public House Next { get; set; }
            public House(int number, string address, string type)
            {
                Number = number;
                Address = address;
                Type = type;
                Next = null;
            }
        }

        public class LinkedList
        {
            private House head;
            public LinkedList()
            {
                head = null;
            }
            public void AddHouse(int number, string address, string type)
            {
                House newHouse = new House(number, address, type);
                if (head == null)
                {
                    head = newHouse;
                }
                else
                {
                    House current = head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = newHouse;
                }
            }
			public void SearchByHouseNumber(int number)
			{
				House current = head;
				while (current != null)
				{
					if (current.Number == number)
					{
						Console.WriteLine($"House Number: {current.Number}");
						Console.WriteLine($"Address: {current.Address}");
						Console.WriteLine($"House Type: {current.Type}");
						return;
					}
					current = current.Next;
				}
				Console.WriteLine("House not found.");
			}
		}
    }
}
