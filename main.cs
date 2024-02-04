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
                Console.WriteLine("Jose Rizal is found on 1 peso");
                break;
            case "5":
                Console.WriteLine("Emilio Aguinaldo is found on 5 pesos");
                break;
            case "10":
                Console.WriteLine("Andres Bonifacio, Apolinario Mabini is found on 10 pesos");
                break;
            case "20":
                Console.WriteLine("Manuel L. Quezon is found on 20 pesos");
                break;
            case "50":
                Console.WriteLine("Sergio Osmena is found on 50 pesos");
                break;
            case "100":
                Console.WriteLine("Manuel Roxas is found on 100 pesos");
                break;
            case "200":
                Console.WriteLine("Diosdado Macapagal is found on 200 pesos");
                break;
            case "500":
                Console.WriteLine("Benigno Sr. and Corazon Aquino is found on 500 pesos");
                break;
            case "1000":
                Console.WriteLine("Jose Abad Santos, Vicente Lim, Josefa Llanes Escoda is found on 1000 pesos");
                break;
          default:
          Console.WriteLine("No Person is found or Invalid Denomination: " + denomination);
          break;
        }
    }
}