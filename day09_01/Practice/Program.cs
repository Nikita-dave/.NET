// using System;

// class InvalidPriceException : SystemException
// {
//     public InvalidPriceException()
//     {
//         System.Console.WriteLine("Error: Price must be greater than zero");
//     }
//     public InvalidPriceException(string message)
//     {
//         System.Console.WriteLine(message);
//     }
// }

// class InvalidQuantityException : SystemException
// {
//     public InvalidQuantityException()
//     {
//         System.Console.WriteLine("Error: Quantity must be greater than zero");
//     }
//     public InvalidQuantityException(string message)
//     {
//         System.Console.WriteLine(message);
//     }
// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         try
//         {
//             decimal price = Convert.ToDecimal(Console.ReadLine());
//             int quantity = Convert.ToInt32(Console.ReadLine());

//             if (price <= 0)
//             {
//                 throw new InvalidPriceException();
//             }

//             if (quantity <= 0)
//             {
//                 throw new InvalidQuantityException();
//             }

//             decimal total = price *quantity;
//             System.Console.WriteLine("Total price is {0:F1}", total);
//         }
//         catch(InvalidPriceException e)
//         {
//             System.Console.WriteLine(e.Message);
//         }
//         catch (InvalidQuantityException e)
//         {
//             System.Console.WriteLine(e.Message);
//         }
//         catch(FormatException)
//         {
//             System.Console.WriteLine("Error: Please enter a valid number");
//         }
//     }
// }

using System;
class Program
{
    public static void Main(string[] args)
    {
        try
        {
            int tickets = Convert.ToInt32(Console.ReadLine());
            decimal price = Convert.ToDecimal(Console.ReadLine());
            if (tickets <= 0)
            {
                throw new ArgumentException("Error: Number of tickets must be greater than 0.");
            }

            if (price <= 0)
            {
                throw new ArgumentException("Error: Price per ticket must be greater than 0.");
            }

            decimal Total = tickets*price;
            System.Console.WriteLine($"Total ticket cost: {Total}");
        }catch(ArgumentException e)
        {
            System.Console.WriteLine(e.Message);
        }
        catch (FormatException)
        {
            System.Console.WriteLine("Error: Please enter a valid number.");
        }
        catch (Exception)
        {
            System.Console.WriteLine("Error: Please enter a valid number.");            
        }
    }
}
