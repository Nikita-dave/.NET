using System;
using System.Collections.Generic;

namespace PettyCashLedger
{
    class Program
    {
        public interface IReportable
        {
            string GetSummary();
        }

        public abstract class Transaction: IReportable
        {
            public int Id { get; set; }
            public DateTime Date { get; set; }
            public decimal Amount { get; set; }
            public string Description { get; set; }
            public abstract string GetSummary();
        }

        public class ExpenseTransaction : Transaction
        {
            public string Category { get; set; }
            public override string GetSummary()
            {
                return $"[Expense] Amount: {Amount}, Category: {Category}, Date: {Date.ToLongDateString()}";
            }
        }

        public class IncomeTransaction : Transaction
        {
            public string Source { get; set; }
            public override string GetSummary()
            {
                return $"[Income] Amount: {Amount}, Source: {Source}, Date: {Date.ToLongDateString()}";
            }
        }

        public class Ledger<T> where T: Transaction
        {
            private List<T> transactions = new List<T>();

            public void AddEntry(T entry)
            {
                transactions.Add(entry);
            }

            public List<T> GetTransactionsByDate(DateTime Date)
            {
                List<T> result = new List<T>();

                foreach(T t in transactions)
                {
                    if(t.Date.Date == Date.Date)
                    {
                        result.Add(t);
                    }
                }
                return result;
            }

            public decimal CalculateTotal()
            {
                decimal total = 0;
                foreach (T t in transactions)
                {
                    total+=t.Amount;
                }
                return total;
            }
            public List<T> GetAllTransactions()
            {
                return transactions;
            }
        }
        public static void Main()
        {
            Ledger<IncomeTransaction> incomeTransaction = new Ledger<IncomeTransaction>();
            IncomeTransaction income = new IncomeTransaction();
            income.Id = 1;
            income.Date = DateTime.Today;
            income.Amount = 500;
            income.Description = "Cash replenishment";
            income.Source = "Main Cash";
            incomeTransaction.AddEntry(income);

            Ledger<ExpenseTransaction> expenseTransaction = new Ledger<ExpenseTransaction>();
            ExpenseTransaction expense1 = new ExpenseTransaction();
            expense1.Id= 2;
            expense1.Date = DateTime.Today;
            expense1.Amount = 20;
            expense1.Description = "Stationery";
            expense1.Category = "Office";
            expenseTransaction.AddEntry(expense1);

            ExpenseTransaction expense2 = new ExpenseTransaction();
            expense2.Id= 3;
            expense2.Date = DateTime.Today;
            expense2.Amount = 15;
            expense2.Description = "Team Snacks";
            expense2.Category = "Food";
            expenseTransaction.AddEntry(expense2);

            decimal TotalIncome = incomeTransaction.CalculateTotal();
            decimal TotalExpense = expenseTransaction.CalculateTotal();

            System.Console.WriteLine($"Total spent: {TotalExpense}");
            System.Console.WriteLine($"Total received: {TotalIncome}");
            System.Console.WriteLine($"Net Balance: {TotalIncome-TotalExpense}");

            List<Transaction> allTransactions = new List<Transaction>();
            allTransactions.AddRange(incomeTransaction.GetAllTransactions());
            allTransactions.AddRange(expenseTransaction.GetAllTransactions());

            Console.WriteLine("Summary:");

            for (int i = 0; i < allTransactions.Count; i++)
            {
                Console.WriteLine(allTransactions[i].GetSummary());
            }
        }
    }
}

