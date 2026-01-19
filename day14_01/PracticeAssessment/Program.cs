// using System;

// class EcommerceShop
// {
//     public string Name { get; set; }
//     public string PhoneNumber { get; set; }
// }

// public class InvalidPhoneNumberException : Exception
// {
//     public InvalidPhoneNumberException()
//     {
//         System.Console.WriteLine("Invalid Phone Number");
//     }
// }
// class Program
// {
//     public static EcommerceShop ValidatePhoneNumber(string name, string phoneNumber)
//     {
//         if(phoneNumber.Length == 0)
//         {
//             EcommerceShop EcommerceShop = new EcommerceShop();
//             EcommerceShop.Name = name;
//             EcommerceShop.PhoneNumber = phoneNumber;
//             return EcommerceShop;
//         }
//         else
//         {
//             throw new InvalidPhoneNumberException();
//         }
//     }

//     public static void Main(string[] args)
//     {
//         try
//         {
//             string name = Console.ReadLine();
//             string phoneNumber = Console.ReadLine();

//             EcommerceShop EcommerceShop = ValidatePhoneNumber(name, phoneNumber);
//             System.Console.WriteLine(name);
//             System.Console.WriteLine(phoneNumber);

//         }
//         catch (InvalidPhoneNumberException e)
//         {
            
//             System.Console.WriteLine(e.Message);
//         }
//     }
// }


// using System;

// class EstimateDetails
// {
//     public float ConstructionArea { get; set; }
//     public float SiteArea { get; set; }
// }

// class ConstructionEstimateException : Exception
// {
//     public ConstructionEstimateException()
//     {
//         System.Console.WriteLine("Sorry your Contruction Estimate is not approved");
//     }
// }

// class Program
// {
//     public static EstimateDetails ValidateContructionEstimate(float cons, float site)
//     {
//         if (cons <= site)
//         {
//             EstimateDetails estimate = new EstimateDetails();
//             estimate.ConstructionArea = cons;
//             estimate.SiteArea = site;
//             return estimate;
//         }
//         else
//         {
//             throw new ConstructionEstimateException();
//         }
//     }
//     public static void Main(string[] args)
//     {
//         try
//         {
//             float cons = float.Parse(Console.ReadLine());
//             float site = float.Parse(Console.ReadLine());

//             EstimateDetails estimate = ValidateContructionEstimate(cons, site);
//             System.Console.WriteLine("Valid Constuction Area");
//         }
//         catch (ConstructionEstimateException e)
//         {
//             System.Console.WriteLine(e. Message);
//         }
//     }
// }

// using System;

// class EcommerceShop
// {
//     public string Name { get; set; }
//     public string Password { get; set; }
//     public string ConfirmPassword { get; set; }
// }

// class InsufficientWalletBalanceException : Exception
// {
//     public InsufficientWalletBalanceException()
//     {
//         System.Console.WriteLine("Password Entered does not match");
//     }
// }

// class Program
// {
//     public static EcommerceShop ValidatePassword(string name, string password, string confirmPassword)
//     {
//         if (!password.Equals(confirmPassword))
//         {
//             throw new InsufficientWalletBalanceException();
//         }

//         EcommerceShop EcommerceShop = new EcommerceShop
//         {
//             Name = name,
//             Password = password,
//             ConfirmPassword = confirmPassword
//         };

//         return EcommerceShop;
//     }

//     static void Main(string[] args)
//     {
//         try
//         {
//             System.Console.WriteLine("Enter name: ");
//             string name = Console.ReadLine();
//             System.Console.WriteLine("Enter Password: ");
//             string password = Console.ReadLine();
//             System.Console.WriteLine("Confirm Password: ");
//             string confirmPassword = Console.ReadLine();

//             EcommerceShop EcommerceShop = ValidatePassword(name, password, confirmPassword);
//             System.Console.WriteLine("Registered Successfully");
            
//         }
//         catch  InsufficientWalletBalanceException e)
//         {
            
//            System.Console.WriteLine(e.Message);
//         }
//     }
// }

// using System;

// class EcommerceShop
// {
//     public string UserName { get; set; }
//     public double WalletBalance { get; set; }
//     public double TotalPurchaseAmount { get; set; }
// }

// class InsufficientWalletBalanceException : Exception
// {
//     public InsufficientWalletBalanceException()
//     {
//         System.Console.WriteLine("Insufficient balance in your digital wallet");
//     }
// }

// class Program
// {
//     public EcommerceShop MakePayment(string userName, double walletBalance, double totalPurchase)
//     {
//         if (walletBalance<totalPurchase)
//         {
//             throw new InsufficientWalletBalanceException();
//         }

//         EcommerceShop ecommerce = new EcommerceShop
//         {
//             UserName = userName,
//             WalletBalance = walletBalance,
//             TotalPurchaseAmount = totalPurchase
//         };

//         return ecommerce;
//     }

//     static void Main(string[] args)
//     {
//         try
//         {
//             System.Console.WriteLine("Enter user name: ");
//             string userName = Console.ReadLine();
//             System.Console.WriteLine("Enter Wallet Balance: ");
//             double walletBalance =double.Parse(Console.ReadLine());
//             System.Console.WriteLine("Enter total purchase Amount: ");
//             double totalPurchase = double.Parse(Console.ReadLine());

//             Program program = new Program();

//             EcommerceShop EcommerceShop = program.MakePayment(userName, walletBalance, totalPurchase);
//             System.Console.WriteLine("Payment Successful");
            
//         }
//         catch  (InsufficientWalletBalanceException e)
//         {
            
//            System.Console.WriteLine(e.Message);
//         }
//     }
// }

// using System;
// using System.Collections;
// using System.Net.NetworkInformation;

// class MeditationCenter
// {
//     public int MemberId { get; set; }
//     public int Age { get; set; }
//     public double Weight { get; set; }
//     public double Height { get; set; }
//     public string Goal { get; set; }
//     public double BMI { get; set; }
// }

// class Program
// {
//     public static ArrayList memberList = new ArrayList();

//     public void AddYogaMember(int memberId, int age, double weight, double height, string goal)
//     {
//         MeditationCenter medication = new MeditationCenter
//         {
//             MemberId = memberId,
//             Age = age,
//             Weight = weight,
//             Height = height,
//             Goal = goal
//         };

//         memberList.Add(medication);
//     }

//     public double CalculateBMI(int memberId)
//     {
//         foreach (MeditationCenter m in memberList)
//         {
//             if(m.MemberId == memberId)
//             {
//                double bmi = m.Weight /(m.Height * m.Height);
//                bmi = Math.Floor(bmi*100)/100;
//                m.BMI = bmi;
//                return bmi; 
//             }            
//         }
//         return 0;    
//     }

//     public int CalculateYogaFee(int memberId)
//     {
//         foreach(MeditationCenter m in memberList)
//         {
//             if(m.MemberId == memberId)
//             {
//                 if(m.Goal.Equals("Weight Loss"))
//                 {
//                     if(m.BMI>=25 && m.BMI < 30)
//                     {
//                         return 2000;
//                     }
//                     else if(m.BMI>=30 && m.BMI < 35)
//                     {
//                        return 2500; 
//                     }
//                     else if (m.BMI >= 35)
//                     {
//                         return 3000;
//                     }
//                 }
//                 else if(m.Goal.Equals("Weight Gain"))
//                 {
//                     return 2500;
//                 }
//             }
//         }

//         return 0;
//     }

//     public static void Main(string[] args)
//     {
//         Program p = new Program();
//         System.Console.WriteLine("Enter Member Id: ");
//         int memberId = int.Parse(Console.ReadLine());
//         System.Console.WriteLine("Enter Age: ");
//         int age = int.Parse(Console.ReadLine());
//         System.Console.WriteLine("Enter Weight");
//         double weight = double.Parse(Console.ReadLine());
//         System.Console.WriteLine("Enter height: ");
//         double height = double.Parse(Console.ReadLine());
//         System.Console.WriteLine("Enter Goal: ");
//         string goal = Console.ReadLine();

//         p.AddYogaMember(memberId,age,weight,height,goal);
//         double bmi = p.CalculateBMI(memberId);

//         if (bmi == 0)
//         {
//             System.Console.WriteLine($"{memberId} not present");
//         }
//         else
//         {
//             System.Console.WriteLine("BMI: "+bmi);
//             int fee = p.CalculateYogaFee(memberId);
//             System.Console.WriteLine("Fee: "+fee);
//         }
        
//     }
// }

// using System;
// using System.Collections.Generic;

// class Program
// {
//     public static List<int> NumberList = new List<int>();

//     public void AddNumbers(int Numbers)
//     {
//         NumberList.Add(Numbers);
//     }

//     public double GetGPAScored()
//     {
//         if(NumberList.Count == 0)
//         {
//             return -1;
//         }
//         int sum =0;
//         foreach (int num in NumberList)
//         {
//             sum += num*3;
//         }
//         double gpa = (double)sum/(NumberList.Count*3);
//         return gpa;
//     }

//     public char GetGradeScored(double gpa)
//     {
//         if(gpa<5 || gpa > 10)
//         {
//             return '\0';
//         }else if (gpa == 10)
//         {
//             return 'S';
//         }else if(gpa>=9)
//         {
//             return 'A';
//         }else if(gpa>=8)
//         {            
//             return 'B';
//         }else if (gpa >= 7)
//         {
//             return 'C';
//         }else if(gpa >= 6)
//         {
//             return 'D';
//         }
//         else
//         {
//             return 'E';
//         }
//     }

//     static void Main(string[] args)
//     {
//         Program p = new Program();

//         Console.WriteLine("Enter number of subjects:");
//         int count = int.Parse(Console.ReadLine());

//         for (int i = 0; i < count; i++)
//         {
//             Console.WriteLine("Enter number:");
//             int number = int.Parse(Console.ReadLine());
//             p.AddNumbers(number);
//         }

//         double gpa = p.GetGPAScored();

//         if (gpa == -1)
//         {
//             Console.WriteLine("No Numbers Available");
//         }
//         else
//         {
//             Console.WriteLine("GPA: " + gpa);

//             char grade = p.GetGradeScored(gpa);

//             if (grade == '\0')
//             {
//                 Console.WriteLine("Invalid GPA");
//             }
//             else
//             {
//                 Console.WriteLine("Grade: " + grade);
//             }
//         }
//     }
// }


// using System;
// using System.Linq;
// using System.Collections.Generic;


// class Movie
// {
//     public string Title { get; set; }
//     public string Artist { get; set; }
//     public string Genre { get; set; }
//     public int Ratings { get; set; }
// }

// class Program
// {
//     public static List<Movie> MovieList = new List<Movie>();

//     public void AddMovie(string MovieDetails)
//     {
//         string[] details = MovieDetails.Split(",");

//             Movie movie = new Movie
//             {
//               Title = details[0],
//               Artist = details[1],
//               Genre = details[2],
//               Ratings = Convert.ToInt32(details[3])
//             };
//         MovieList.Add(movie);
//     }

//     public List<Movie> ViewMoviesByGenre(string genre)
//     {
//         return MovieList.Where(m=>m.Genre.Equals(genre,StringComparison.OrdinalIgnoreCase)).ToList();
//     }

//     public List<Movie> ViewMoviesByRatings()
//     {
//         return MovieList.OrderBy(m=>m.Ratings).ToList();
//     }

//     public static void Main(string[] args)
//     {
//         Program p = new Program();
//         System.Console.WriteLine("Enter Number of Movies: ");
//         int n = Convert.ToInt32(Console.ReadLine());

//         for(int i = 0; i < n; i++)
//         {
//             System.Console.WriteLine("Enter movie details: ");
//             string MovieDetails = Console.ReadLine();
//             p.AddMovie(MovieDetails);
//         }

//         System.Console.WriteLine("Enter genre: ");
//         string genre = Console.ReadLine();

//         List<Movie> genreMovie = p.ViewMoviesByGenre(genre);
//         if (genreMovie.Count == 0)
//         {
//             System.Console.WriteLine("No movie found in the genre"+genre);
//         }
//         else
//         {
//             foreach(Movie m in genreMovie)
//             {
//                 System.Console.WriteLine(m.Title+" "+m.Artist+" "+m.Genre+" "+m.Ratings);
//             }
//         }

//         System.Console.WriteLine("Movie sorted by Ratings: ");
//         List<Movie> sortedMovie = p.ViewMoviesByRatings();

//         foreach (Movie m in sortedMovie)
//         {
//             System.Console.WriteLine(m.Title+" "+m.Artist+" "+m.Genre+" "+m.Ratings);
//         }

//     }
// }


using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    public static SortedDictionary<String, long> itemDetails = new SortedDictionary<string, long>();

    public SortedDictionary<String, long> FinditemDetails(long soldCount)
    {
        return new SortedDictionary<String, long>(itemDetails.Where(x => x.Value == soldCount).ToDictionary(x => x.Key, x => x.Value));
    }

    public List<String> FindMinandMaxSolditems()
    {
        List<string> result = new List<string>();
        var minItem = itemDetails.OrderBy(x => x.Value).First();
        var maxItem = itemDetails.OrderByDescending(x => x.Value).First();

        result.Add(minItem.Key);
        result.Add(maxItem.Key);

        return result;
    }

    public Dictionary<string, long> SortByCount()
    {
        return itemDetails.OrderBy(x=>x.Value).ToDictionary(x=>x.Key, x=>x.Value);
    }

    public static void Main(string[] args)
    {
        Program p = new Program();
        
        Console.WriteLine("Enter number of items:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter item name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter sold count:");
            long count = long.Parse(Console.ReadLine());

            itemDetails.Add(name, count);
        }

        Console.WriteLine("Enter sold count to search:");
        long searchCount = long.Parse(Console.ReadLine());

        SortedDictionary<string, long> found =
            p.FinditemDetails(searchCount);

        if (found.Count == 0)
        {
            Console.WriteLine("Invalid sold count");
        }
        else
        {
            foreach (var item in found)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }

        List<string> minMax = p.FindMinandMaxSolditems();
        Console.WriteLine("Minimum sold item: " + minMax[0]);
        Console.WriteLine("Maximum sold item: " + minMax[1]);

        Dictionary<string, long> sorted = p.SortByCount();
        Console.WriteLine("Items sorted by sold count:");

        foreach (var item in sorted)
        {
            Console.WriteLine(item.Key + " " + item.Value);
        }
    }
}
