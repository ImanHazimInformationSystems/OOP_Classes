// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        //creating an object (Variable of a certain calss type)
        Transaction transaction = new Transaction();
        Date date = new Date();


        transaction.month = 1;
        transaction.val = 10.5F;

        Console.WriteLine("Transaction value is " + transaction.val);
    }
}

