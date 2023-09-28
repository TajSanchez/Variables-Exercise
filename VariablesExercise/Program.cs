namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myName = "Taj";
            int myAge = 31;
            char myInitial = 'T';
            bool isCool = true;
            double favNumber = 79.5;
            decimal myAccount = 500.00m;

            Console.WriteLine($"Hello my name is {myName}, I am {myAge} years old. The first letter in my name starts with {myInitial}. My favorite number is {favNumber}, and I have ${myAccount} in my wallet. All that tells me that I'm petrry cool! {isCool}");
            
        }
    }
}
