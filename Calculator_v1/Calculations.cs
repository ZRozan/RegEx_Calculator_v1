using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GeneralTraining
{
    class Calculations
    {
        public static void StartCalculator()
        {
            bool calculationsRunning;
            double currentResult = 0;
            Calculations calculations = new Calculations();

            do
            {
                Console.WriteLine($"#---- Current value: {currentResult}\n");

                Console.Write("Choose a calculation: +  -  *  /  'S'quared: ");
                string calculationSwitch = Console.ReadLine().ToUpper();

                switch (calculationSwitch)
                {
                    case "+":
                        calculations.Sum(currentResult, out currentResult);
                        break;
                    case "-":
                        calculations.Minus(currentResult, out currentResult);
                        break;
                    case "*":
                        calculations.Multiply(currentResult, out currentResult);
                        break;
                    case "/":
                        calculations.Division(currentResult, out currentResult);
                        break;
                    case "S":
                        calculations.Squared(currentResult, out currentResult);
                        break;
                    default:
                        Console.WriteLine("\n\t# Doof!! #\n~~ That is not an option, buddy.");
                        break;
                }
                Console.WriteLine($"\nRESULT: {currentResult}");
            }
            while (calculationsRunning = AnotherCalculationQuestion());
        }
        public void Sum(double currentValue, out double result)
        {
            List<double> numbers;

            numbers = numbersToCalculate();

            foreach (double value in numbers)
            {
                currentValue += value;
            }
            result = currentValue;
        }
        public void Minus(double currentValue, out double result)
        {
            List<double> numbers;

            double initialValue = currentValue;
            double totalFromInput = 0;

            if (initialValue == 0)
            {
                numbers = numbersToCalculate();

                for (int i = 1; i < numbers.Count(); i++)
                {
                    totalFromInput += numbers[i];
                }
                result = numbers[0] - totalFromInput;
            }
            else
            {
                numbers = numbersToCalculate();

                for (int i = 0; i < numbers.Count(); i++)
                {
                    totalFromInput += numbers[i];
                }
                result = initialValue - totalFromInput;
            }
        }
        public void Multiply(double currentValue, out double result)
        {
            List<double> numbers;

            if (currentValue == 0) { currentValue = 1; }
            numbers = numbersToCalculate();
            for (int i = 0; i < numbers.Count(); i++)
            {
                currentValue *= numbers[i];
            }
            result = currentValue;
        }
        public void Division(double currentValue, out double result)
        {
            double divisor;

            if (currentValue == 0)
            {
                Console.WriteLine("\n\t#---- Choose the divisor: ----#");
                divisor = valuesDivision();
            }
            else
            {
                divisor = currentValue;
            }

            Console.WriteLine($"\n\t#---- {divisor} Divided by: ----#");
            double divident = valuesDivision();

            if (divident == 0)
            {
                Console.WriteLine("You just created a BlackHole. Congrats on destroying everything.");
                result = currentValue;
            }
            else
            {
                result = divisor / divident;
            }

            double valuesDivision()
            {
                double inputValue;

                if (!Double.TryParse(Console.ReadLine(), out inputValue))
                {
                    Console.WriteLine("\n\t#---- This is not a number, you doofus! Do it again. ----#");
                    valuesDivision();
                }
                return inputValue;
            }
        }
        public void Squared(double currentValue, out double result)
        {
            if (currentValue == 0)
            {
                Console.WriteLine("\n\t#---- Choose a Value to calculate the square: ----#");
                bool validNumber = Double.TryParse(Console.ReadLine(), out currentValue);
                if (!validNumber)
                {
                    Console.WriteLine("\nHEY! That is illegal! ò.ó \n\tTry again.");
                    Squared(currentValue, out result);
                }
            }
            result = currentValue * currentValue;
        }
        static bool AnotherCalculationQuestion()
        {
            Console.WriteLine("\n\t#---- Continue? (Y/N) ----#");
            string response = Console.ReadLine().ToUpper();

            switch (response)
            {
                case "Y":
                    Console.Clear();
                    Console.WriteLine("\n\t#---- All right, let's go! ----#\n");
                    return true;
                    break;
                case "N":
                    return false;
                    break;
                default:
                    Console.WriteLine("#-- There are only two options, c'mon... --#");
                    return AnotherCalculationQuestion();
                    break;
            }
        }
        static List<double> numbersToCalculate()
        {
            List<double> numbersList = new List<double>();
            double inputValue;
            bool checkInputValue;

            Console.WriteLine("\n\t#----    Press any letter for the result.   ----#");
            Console.WriteLine("\t#---- Write your values separated by Enter: ----#");

            do
            {
                checkInputValue = Double.TryParse(Console.ReadLine(), out inputValue);
                if (checkInputValue) { numbersList.Add(inputValue); }
            }
            while (checkInputValue);

            return numbersList;
        }
    }
}
