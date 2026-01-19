using System;

class SaleTransaction
{
    public string InvoiceNo;
    public string CustomerName;
    public string ItemName;
    public int Quantity;
    public decimal PurchaseAmount;
    public decimal SellingAmount;
    public string ProfitOrLossStatus;
    public decimal ProfitOrLossAmount;
    public decimal ProfitMarginPercent;

    public static SaleTransaction LastTransaction;
    public static bool HasLastTransaction = false;

    public static void CreateNewTransaction()
    {
        SaleTransaction transaction = new SaleTransaction();

        Console.Write("Enter Invoice No: ");
        transaction.InvoiceNo = Console.ReadLine();
        if (transaction.InvoiceNo == "" || transaction.InvoiceNo == null)
        {
            Console.WriteLine("Invoice No cannot be empty.");
            return;
        }

        Console.Write("Enter Customer Name: ");
        transaction.CustomerName = Console.ReadLine();

        Console.Write("Enter Item Name: ");
        transaction.ItemName = Console.ReadLine();

        Console.Write("Enter Quantity: ");
        transaction.Quantity = Convert.ToInt32(Console.ReadLine());
        if (transaction.Quantity <= 0)
        {
            Console.WriteLine("Quantity must be greater than zero.");
            return;
        }

        Console.Write("Enter Purchase Amount (total): ");
        transaction.PurchaseAmount = Convert.ToDecimal(Console.ReadLine());
        if (transaction.PurchaseAmount <= 0)
        {
            Console.WriteLine("Purchase Amount must be greater than zero.");
            return;
        }

        Console.Write("Enter Selling Amount (total): ");
        transaction.SellingAmount = Convert.ToDecimal(Console.ReadLine());
        if (transaction.SellingAmount < 0)
        {
            Console.WriteLine("Selling Amount cannot be negative.");
            return;
        }

        Calculate(transaction);

        LastTransaction = transaction;
        HasLastTransaction = true;

        Console.WriteLine("Transaction saved successfully.");
        PrintCalculation(transaction);
    }

    public static void ViewLastTransaction()
    {
        if (!HasLastTransaction)
        {
            Console.WriteLine("No transaction available. Please create a new transaction first.");
            return;
        }

        Console.WriteLine("-------------- Last Transaction --------------");
        Console.WriteLine($"InvoiceNo: {LastTransaction.InvoiceNo}");
        Console.WriteLine($"Customer: {LastTransaction.CustomerName}");
        Console.WriteLine($"Item: {LastTransaction.ItemName}");
        Console.WriteLine($"Quantity: {LastTransaction.Quantity}");
        Console.WriteLine($"Purchase Amount: {LastTransaction.PurchaseAmount:F2}");
        Console.WriteLine($"Selling Amount: {LastTransaction.SellingAmount:F2}");
        Console.WriteLine($"Status: {LastTransaction.ProfitOrLossStatus}");
        Console.WriteLine($"Profit/Loss Amount: {LastTransaction.ProfitOrLossAmount:F2}");
        Console.WriteLine($"Profit Margin (%): {LastTransaction.ProfitMarginPercent:F2}");
        Console.WriteLine("--------------------------------------------");
    }

    public static void Recalculate()
    {
        if (!HasLastTransaction)
        {
            Console.WriteLine("No transaction available. Please create a new transaction first.");
            return;
        }

        Calculate(LastTransaction);
        PrintCalculation(LastTransaction);
    }

    private static void Calculate(SaleTransaction t)
    {
        if (t.SellingAmount > t.PurchaseAmount)
        {
            t.ProfitOrLossStatus = "PROFIT";
            t.ProfitOrLossAmount = t.SellingAmount - t.PurchaseAmount;
        }
        else if (t.SellingAmount < t.PurchaseAmount)
        {
            t.ProfitOrLossStatus = "LOSS";
            t.ProfitOrLossAmount = t.PurchaseAmount - t.SellingAmount;
        }
        else
        {
            t.ProfitOrLossStatus = "BREAK-EVEN";
            t.ProfitOrLossAmount = 0;
        }

        t.ProfitMarginPercent = (t.ProfitOrLossAmount / t.PurchaseAmount) * 100;
    }

    private static void PrintCalculation(SaleTransaction t)
    {
        Console.WriteLine($"Status: {t.ProfitOrLossStatus}");
        Console.WriteLine($"Profit/Loss Amount: {t.ProfitOrLossAmount:F2}");
        Console.WriteLine($"Profit Margin (%): {t.ProfitMarginPercent:F2}");
        Console.WriteLine("------------------------------------------------------");
    }
}

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("======= QuickMart Traders ========");
            Console.WriteLine("1. Create New Transaction");
            Console.WriteLine("2. View Last Transaction");
            Console.WriteLine("3. Calculate Profit/Loss");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    SaleTransaction.CreateNewTransaction();
                    break;
                case "2":
                    SaleTransaction.ViewLastTransaction();
                    break;
                case "3":
                    SaleTransaction.Recalculate();
                    break;
                case "4":
                    Console.WriteLine("Thank you. Application closed normally.");
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
