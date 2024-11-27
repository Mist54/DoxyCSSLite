using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    /// \brief A class that provides a variety of mathematical operations such as addition, subtraction, multiplication, division, and utilities.
    public class MathOperations
    {
        /// \brief Adds two integers and returns the result.
        /// \param a The first integer to add.
        /// \param b The second integer to add.
        /// \return The sum of the two integers.
        /// \exception OverflowException Thrown if the addition results in an overflow.
        /// \code
        /// MathOperations math = new MathOperations();
        /// int result = math.Add(5, 3);
        /// Console.WriteLine(result); // Outputs: 8
        /// \endcode
        public int Add(int a, int b)
        {
            checked // Ensures overflow exceptions are caught
            {
                return a + b;
            }
        }

        /// \brief Subtracts the second integer from the first and returns the result.
        /// \param a The integer to subtract from.
        /// \param b The integer to subtract.
        /// \return The difference between the two integers.
        /// \code
        /// MathOperations math = new MathOperations();
        /// int result = math.Subtract(10, 4);
        /// Console.WriteLine(result); // Outputs: 6
        /// \endcode
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        /// \brief Multiplies two integers and returns the result.
        /// \param a The first integer to multiply.
        /// \param b The second integer to multiply.
        /// \return The product of the two integers.
        /// \exception OverflowException Thrown if the multiplication results in an overflow.
        /// \code
        /// MathOperations math = new MathOperations();
        /// int result = math.Multiply(4, 6);
        /// Console.WriteLine(result); // Outputs: 24
        /// \endcode
        public static int Multiply(int a, int b)
        {
            checked // Ensures overflow exceptions are caught
            {
                return a * b;
            }
        }

        /// \brief Divides the first integer by the second and returns the result.
        /// \param a The numerator.
        /// \param b The denominator.
        /// \return The result of the division.
        /// \exception DivideByZeroException Thrown if the denominator is zero.
        /// \code
        /// MathOperations math = new MathOperations();
        /// int result = math.Divide(12, 3);
        /// Console.WriteLine(result); // Outputs: 4
        /// \endcode
        /// \remark This is a function 
        public static int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }
            return a / b;
        }

        /// \brief Calculates the factorial of a non-negative integer.
        /// \param n The integer for which to calculate the factorial.
        /// \return The factorial of the integer.
        /// \exception ArgumentOutOfRangeException Thrown if the input is negative.
        /// \code
        /// MathOperations math = new MathOperations();
        /// int result = math.Factorial(5);
        /// Console.WriteLine(result); // Outputs: 120
        /// \endcode
        public int Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException("n", "Input must be non-negative.");
            }

            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                checked
                {
                    result *= i;
                }
            }
            return result;
        }

        /// \brief Determines if a number is even.
        /// \param number The integer to check.
        /// \return True if the number is even, otherwise false.
        /// \code
        /// MathOperations math = new MathOperations();
        /// bool isEven = math.IsEven(4);
        /// Console.WriteLine(isEven); // Outputs: True
        /// \endcode
        /// \remark This is a function 
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        /// \brief Determines if a number is odd.
        /// \param number The integer to check.
        /// \return True if the number is odd, otherwise false.
        /// \code
        /// MathOperations math = new MathOperations();
        /// bool isOdd = math.IsOdd(5);
        /// Console.WriteLine(isOdd); // Outputs: True
        /// \endcode
        public bool IsOdd(int number)
        {
            return number % 2 != 0;
        }


        /// \brief Calculates the Greatest Common Divisor (GCD) of two integers using the Euclidean algorithm.
        /// \param a The first integer.
        /// \param b The second integer.
        /// \return The GCD of the two integers.
        /// \code
        /// AdvancedMathOperations math = new AdvancedMathOperations();
        /// int gcd = math.GCD(48, 18);
        /// Console.WriteLine(gcd); // Outputs: 6
        /// \endcode
        public int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a);
        }

        /// \brief Calculates the Least Common Multiple (LCM) of two integers.
        /// \param a The first integer.
        /// \param b The second integer.
        /// \return The LCM of the two integers.
        /// \code
        /// AdvancedMathOperations math = new AdvancedMathOperations();
        /// int lcm = math.LCM(4, 6);
        /// Console.WriteLine(lcm); // Outputs: 12
        /// \endcode
        public int LCM(int a, int b)
        {
            return Math.Abs(a * b) / GCD(a, b);
        }

        /// \brief Calculates the power of a base integer raised to an exponent.
        /// \param baseNumber The base integer.
        /// \param exponent The exponent to raise the base integer to.
        /// \return The result of baseNumber raised to the power of exponent.
        /// \exception ArgumentException Thrown if the exponent is negative.
        /// \code
        /// AdvancedMathOperations math = new AdvancedMathOperations();
        /// int power = math.Power(2, 3);
        /// Console.WriteLine(power); // Outputs: 8
        /// \endcode
        public int Power(int baseNumber, int exponent)
        {
            if (exponent < 0) throw new ArgumentException("Exponent must be non-negative.");
            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseNumber;
            }
            return result;
        }

        /// \brief Generates a list containing the Fibonacci sequence up to a specified number of terms.
        /// \param terms The number of terms in the Fibonacci sequence to generate.
        /// \return A list of integers representing the Fibonacci sequence.
        /// \exception ArgumentOutOfRangeException Thrown if terms is less than 1.
        /// \code
        /// AdvancedMathOperations math = new AdvancedMathOperations();
        /// List<int> fibonacci = math.GenerateFibonacci(5);
        /// Console.WriteLine(string.Join(", ", fibonacci)); // Outputs: 0, 1, 1, 2, 3
        /// \endcode
        public List<int> GenerateFibonacci(int terms)
        {
            if (terms < 1) throw new ArgumentOutOfRangeException(nameof(terms), "Terms must be at least 1.");

            List<int> sequence = new List<int> { 0, 1 };
            for (int i = 2; i < terms; i++)
            {
                int nextTerm = sequence[i - 1] + sequence[i - 2];
                sequence.Add(nextTerm);
            }
            return sequence.GetRange(0, terms);
        }


        /// \brief Calculates the square root of an integer.
        /// \param number The integer to calculate the square root for.
        /// \return The integer part of the square root.
        /// \exception ArgumentOutOfRangeException Thrown if the number is negative.
        /// \code
        /// MathOperations math = new MathOperations();
        /// int sqrt = math.SquareRoot(16);
        /// Console.WriteLine(sqrt); // Outputs: 4
        /// \endcode
        /// \remark This is a function 
        public int SquareRoot(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Cannot compute square root of a negative number.");
            }

            int result = 0;
            int bit = 1 << 30;

            while (bit > number)
            {
                bit >>= 2;
            }

            while (bit != 0)
            {
                if (number >= result + bit)
                {
                    number -= result + bit;
                    result = (result >> 1) + bit;
                }
                else
                {
                    result >>= 1;
                }
                bit >>= 2;
            }
            return result;
        }


        /// \brief Calculates the least common multiple (LCM) of two integers.
        /// \param a The first integer.
        /// \param b The second integer.
        /// \return The least common multiple of the two integers.
        /// \see GCD(int, int)
        /// \remark LCM is useful in problems involving addition or subtraction of fractions.
        /// \warning This method may throw an `OverflowException` for large values of a and b.
        /// \code
        /// AdvancedMathOperations math = new AdvancedMathOperations();
        /// int lcm = math.LeastCommonMultiple(12, 15);
        /// Console.WriteLine(lcm); // Outputs: 60
        /// \endcode
        /// \remark This is a function 
        public int LeastCommonMultiple(int a, int b)
        {
            return Math.Abs(a * b) / GCD(a, b);
        }

        /// \brief Checks whether a given number is prime.
        /// \param number The number to check.
        /// \return True if the number is prime, otherwise false.
        /// \see Factorial(int)
        /// \remark A prime number is a number greater than 1 that has no divisors other than 1 and itself.
        /// \bug This implementation is not optimized for very large numbers.
        /// \warning Avoid using this method for numbers greater than 10^7, as performance degrades significantly.
        /// \code
        /// AdvancedMathOperations math = new AdvancedMathOperations();
        /// bool isPrime = math.IsPrime(17);
        /// Console.WriteLine(isPrime); // Outputs: True
        /// \endcode
        /// \remark This is a function 
        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number <= 3) return true;

            if (number % 2 == 0 || number % 3 == 0) return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        

        /// \brief The entry point of the program. Demonstrates the use of the MathOperations class.
        /// \param args An array of command-line arguments.
        /// \code
        /// MathOperations.Main(new string[] {});
        /// \endcode
        public static void Main(string[] args)
        {
            MathOperations math = new MathOperations();

            try
            {
                // Demonstrating addition
                int additionResult = math.Add(10, 15);
                Console.WriteLine($"Addition Result: {additionResult}");

                // Demonstrating subtraction
                int subtractionResult = math.Subtract(20, 5);
                Console.WriteLine($"Subtraction Result: {subtractionResult}");

                // Demonstrating multiplication
                int multiplicationResult = math.Multiply(6, 7);
                Console.WriteLine($"Multiplication Result: {multiplicationResult}");

                // Demonstrating division
                int divisionResult = math.Divide(42, 7);
                Console.WriteLine($"Division Result: {divisionResult}");

                // Demonstrating factorial
                int factorialResult = math.Factorial(5);
                Console.WriteLine($"Factorial Result: {factorialResult}");

                // Checking if numbers are even or odd
                bool isEven = math.IsEven(10);
                bool isOdd = math.IsOdd(7);
                Console.WriteLine($"Is 10 Even? {isEven}");
                Console.WriteLine($"Is 7 Odd? {isOdd}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
