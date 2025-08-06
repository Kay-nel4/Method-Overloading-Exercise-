using System.ComponentModel;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Add(4, 7);
            Add(5.4m, 6.9m);
            Add(0, 1, true);
        }

        public static int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
            return sum;
        }
        
        public static decimal Add(decimal num1, decimal num2)
        {
            decimal answer = num1 + num2;
            Console.WriteLine(answer);
            return answer;
        }

        public static bool Add(int num1, int num2, bool money)
        {
            var sum = num1 + num2;
            
            if (money == true && sum >= 2)
            {
                Console.WriteLine($"${sum} dollars");
            }
            else if (money == true && sum < 2)
            {
                Console.WriteLine($"Just ${sum} dollar?");
            }

            return money; 

        }
    }   
    
    
}
