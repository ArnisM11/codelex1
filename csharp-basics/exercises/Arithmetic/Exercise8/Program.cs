namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var employee1, employee2, employee3;
            decimal salary1,salary2, salary3;
            int hours1,hours2,hours3;

            salary1 = 7.50m;
            salary2 = 8.20m;
            salary3 = 10.00m;

            hours1 = 35;
            hours2 = 47;
            hours3 = 73;



        }
        public static string calculateSalary(decimal basePay,int hoursWorked)
        {
            if (basePay<8.00m || hoursWorked>60)
            {
                return "Too low salary or too many hours worked.";
            }
            if(hoursWorked <= 40)
            {
                return (hoursWorked * basePay).ToString();
            }
            else if (hoursWorked > 40)
            {

            }
            return "error";
        }
    }
}