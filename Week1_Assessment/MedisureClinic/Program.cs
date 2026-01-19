using System;

class PatientBill
{
    public string BillId;
    public string PatientName;
    public bool HasInsurance;
    public decimal ConsultationFee;
    public decimal LabCharges;
    public decimal MedicineCharges;
    public decimal GrossAmount;
    public decimal DiscountAmount;
    public decimal FinalPayable;
    public static PatientBill LastBill;
    public static bool HasLastBill = false;

    public static void CreateNewBill()
    {
        PatientBill bill = new PatientBill();

        Console.Write("Enter Bill Id: ");
        bill.BillId = Console.ReadLine();
        if(bill.BillId == ""|| bill.BillId == null)
        {
            Console.WriteLine("Bill Id cannot be empty.");
            return;
        }
        Console.Write("Enter Patient Name: ");
        bill.PatientName = Console.ReadLine();
        Console.Write("Has Insurance (Y/N): ");
        string temp = Console.ReadLine();
        bill.HasInsurance = (temp =="Y" ||temp=="y");
        Console.Write("Consultation Fee: ");
        bill.ConsultationFee = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Lab Charges: ");
        bill.LabCharges = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Medicine Charges: ");
        bill.MedicineCharges = Convert.ToDecimal(Console.ReadLine());

        bill.GrossAmount = bill.ConsultationFee + bill.LabCharges + bill.MedicineCharges;
        if (bill.HasInsurance)
        {
            bill.DiscountAmount = bill.GrossAmount * 0.1M;
        }
        else
        {
            bill.DiscountAmount = 0;
        }
        bill.FinalPayable = bill.GrossAmount - bill.DiscountAmount;

        LastBill = bill;
        HasLastBill = true;
        Console.WriteLine("Bill created successfully.");
        Console.WriteLine($"Gross Amount: {bill.GrossAmount:F2}");
        Console.WriteLine($"Discount Amount: {bill.DiscountAmount:F2}");
        Console.WriteLine($"Final Payable: {bill.FinalPayable:F2}");
        Console.WriteLine("------------------------------");
    }

    public static void ViewLastBill()
    {
        if (!HasLastBill)
        {
            Console.WriteLine("No bill available to display.");
            return;
        }
        else
        {            
            Console.WriteLine("--------Last Bill------------");
            Console.WriteLine($"BillId: {LastBill.BillId}");
            Console.WriteLine($"Patient: {LastBill.PatientName}");
            Console.WriteLine($"Insured: {LastBill.HasInsurance}");
            Console.WriteLine($"Consultation Fee: {LastBill.ConsultationFee:F2}");
            Console.WriteLine($"Lab Charges: {LastBill.LabCharges:F2}");
            Console.WriteLine($"Medicine Charges: {LastBill.MedicineCharges:F2}");
            Console.WriteLine($"Gross Amount: {LastBill.GrossAmount:F2}");
            Console.WriteLine($"Discount Amount: {LastBill.DiscountAmount:F2}");
            Console.WriteLine($"Final Payable: {LastBill.FinalPayable:F2}");
            Console.WriteLine("------------------------------");
        }
    }

    public static void ClearBill()
    {
        LastBill=null;
        HasLastBill=false;
        System.Console.WriteLine("Last Bill Cleared.");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            System.Console.WriteLine("==========MediSure Clinic Billing ==========");
            Console.WriteLine("1. Create New Bill (Enter Patient Details)");
            System.Console.WriteLine("2. View Last Bill");
            System.Console.WriteLine("3. Clear Last Bill");
            System.Console.WriteLine("4. Exit");
            System.Console.WriteLine("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PatientBill.CreateNewBill();
                    break;

                case "2":
                    PatientBill.ViewLastBill();
                    break;

                case "3":
                    PatientBill.ClearBill();
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
