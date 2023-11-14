namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //For division create two integer variable called a and b

            var a = 17;
            var b = 4;
            var sum = a + b;
            var subtr = a - b;
            var multi = a * b;
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a} + {b} = {sum}, {a} - {b} = {subtr}, {a} * {b} = {multi}, {a} / {b} is {quotient} remainder {remainder}" );
        }
    }
}
