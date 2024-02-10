using System;

class Program {
    static void Main() {
        Console.Write("Enter the denomination: ");
        string denomination = Console.ReadLine();

        switch (denomination)
        {
            case "0.01":
            case "0.05":
            case "0.25":
                Console.WriteLine("No Person is found");
                break;
            case "1":
                Console.WriteLine("{0} is found on {1} peso", "Jose Rizal", denomination);
                break;
            case "5":
                Console.WriteLine("{0} is found on {1} pesos", "Emilio Aguinaldo", denomination);
                break;
            case "10":
                Console.WriteLine("{0}, {1} is found on {2} pesos", "Andres Bonifacio", "Apolinario Mabini", denomination);
                break;
            case "20":
                Console.WriteLine("{0} is found on {1} pesos", "Manuel L. Quezon", denomination);
                break;
            case "50":
                Console.WriteLine("{0} is found on {1} pesos", "Sergio Osmena", denomination);
                break;
            case "100":
                Console.WriteLine("{0} is found on {1} pesos", "Manuel Roxas", denomination);
                break;
            case "200":
                Console.WriteLine("{0} is found on {1} pesos", "Diosdado Macapagal", denomination);
                break;
            case "500":
                Console.WriteLine("{0} and {1} are found on {2} pesos", "Benigno Sr.", "Corazon Aquino", denomination);
                break;
            case "1000":
                Console.WriteLine("{0}, {1}, {2} are found on {3} pesos", "Jose Abad Santos", "Vicente Lim", "Josefa Llanes Escoda", denomination);
                break;
            default:
                Console.WriteLine("Invalid Denomination: {0}", denomination);
                break;
        }
    }
}
