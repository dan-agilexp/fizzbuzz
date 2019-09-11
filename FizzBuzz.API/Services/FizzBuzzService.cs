namespace FizzBuzz.API.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public string GetFizzBuz(int inputNumber)
        {
            if (inputNumber % 3 == 0 && inputNumber % 5 == 0)
            {
                return "FizzBuzz";

            }else if (inputNumber % 3 == 0)
            {
                return "Fizz";
            }
            else if (inputNumber % 5 == 0)
            {
                return "Buzz";
            }
            

            return inputNumber.ToString();
        }
    }
}