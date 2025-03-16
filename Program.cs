namespace MoneyClasses
{
    public class MyException : ApplicationException
    {
        public DateTime TimeException { get; private set; }
        public MyException() : base("Мое исключение")
        {
            TimeException = DateTime.Now;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Money num1 = 100;
            Money num2 = 200;


            try
            {
                Console.WriteLine(num1 + num2);
                Console.WriteLine(num1 - num2);
                Console.WriteLine(num1 * 2);
                Console.WriteLine(num1 / 2);
                Console.WriteLine(num1 == num2);
                Console.WriteLine(num1 != num2);
                Console.WriteLine(num1 > num2);
                Console.WriteLine(num1 < num2);
                Console.WriteLine(num1++);
                Console.WriteLine(num2++);
                Console.WriteLine(num1--);
                Console.WriteLine(num2--);
            }
            catch (Exception ex)
            {
                throw new MyException();
            }
        }
    }
}
