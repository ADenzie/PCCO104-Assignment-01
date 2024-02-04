using System;

class Program {
    static void Main() {
        Console.Write("Enter the denomination: ");
        string denomination = Console.ReadLine();

        switch (denomination)
        {
            case "1":
                Console.WriteLine("Jose Rizal");
                break;
            case "5":
                Console.WriteLine("Emilio Aguinaldo");
                break;
            case "10":
                Console.WriteLine("Andres Bonifacio, Apolinario Mabini");
                break;
            case "20":
                Console.WriteLine("Manuel L. Quezon");
                break;
            case "50":
                Console.WriteLine("Sergio Osmena");
                break;
            case "100":
                Console.WriteLine("Manuel Roxas");
                break;
            case "200":
                Console.WriteLine("Diosdado Macapagal");
                break;
            case "500":
                Console.WriteLine("Benigno Sr. and Corazon Aquino");
                break;
            case "1000":
                Console.WriteLine("Jose Abad Santos, Vicente Lim, Josefa Llanes Escoda");
                break;
        }
    }
}