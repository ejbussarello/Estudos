using System;

namespace Estudos.Praticos;

public static class TryCatch
{
    public static void TryCatchExemplo()
    {
        try
        {
            Process1();
        }
        catch
        {
            Console.WriteLine("An exception has occurred");
        }

        Console.WriteLine("Exit program");

        static void Process1()
        {
            try
            {
                WriteMessage();
            }
            catch
            {
                Console.WriteLine("Exception caught in Process1");
            }

        }

        static void WriteMessage()
        {
            double float1 = 3000.0;
            double float2 = 0.0;
            int number1 = 3000;
            int number2 = 0;

            Console.WriteLine(float1 / float2);
            Console.WriteLine(number1 / number2);
        }
    }

    public static void TryCatchExemplo2()
    {
        checked
        {
            try
            {
                int num1 = int.MaxValue;
                int num2 = int.MaxValue;
                int result = num1 + num2;
                Console.WriteLine("Result: " + result);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
            }
        }

        try
        {
            string? str = null;
            int length = str.Length;
            Console.WriteLine("String Length: " + length);
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("Error: The reference is null. " + ex.Message);
        }

        try
        {
            int[] numbers = new int[5];
            numbers[5] = 10;
            Console.WriteLine("Number at index 5: " + numbers[5]);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Error: Index out of range. " + ex.Message);
        }

        try
        {
            int num3 = 10;
            int num4 = 0;
            int result2 = num3 / num4;
            Console.WriteLine("Result: " + result2);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
        }

        Console.WriteLine("Exiting program.");
    }

    public static void TryCatchEx()
    {
        try
        {
            OperatingProcedure1();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Exiting application.");
        }

        static void OperatingProcedure1()
        {
            string[][] userEnteredValues = new string[][]
            {
                new string[] { "1", "two", "3"},
                new string[] { "0", "1", "2"}
            };

            foreach(string[] userEntries in userEnteredValues)
            {
                try
                {
                    BusinessProcess1(userEntries);
                }
                catch (Exception ex)
                {
                    if (ex.StackTrace.Contains("BusinessProcess1"))
                    {
                        if (ex is FormatException)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine("Corrective action taken in OperatingProcedure1");
                        }
                        else if (ex is DivideByZeroException)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");

                            // re-throw the original exception
                            throw;
                        }
                        else
                        {
                            // create a new exception object that wraps the original exception
                            throw new ApplicationException("An error occurred - ", ex);
                        }
                    }
                }

            }
        }

        static void BusinessProcess1(string[] userEntries)
        {
            int valueEntered;

            foreach (string userValue in userEntries)
            {
                try
                {
                    valueEntered = int.Parse(userValue);

                    checked
                    {
                        int calculatedValue = 4 / valueEntered;
                    }
                }
                catch (FormatException)
                {
                    FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
                    throw invalidFormatException;
                }
                catch (DivideByZeroException)
                {
                    DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero");
                    throw unexpectedDivideByZeroException;

                }
            }
        }
    }

    public static void TryCatchExemploPratico()
    {
        string[][] userEnteredValues = new string[][]
        {
                    new string[] { "1", "2", "3"},
                    new string[] { "1", "two", "3"},
                    new string[] { "0", "1", "2"}
        };

        try
        {
            Workflow1(userEnteredValues);
            Console.WriteLine("'Workflow1' completed successfully.");

        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("An error occurred during 'Workflow1'.");
            Console.WriteLine(ex.Message);
        }

        static void Workflow1(string[][] userEnteredValues)
        {
            foreach (string[] userEntries in userEnteredValues)
            {
                try
                {
                    Process1(userEntries);
                    Console.WriteLine("'Process1' completed successfully.");
                    Console.WriteLine();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("'Process1' encountered an issue, process aborted.");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                }
            }
        }

        static void Process1(String[] userEntries)
        {
            int valueEntered;

            foreach (string userValue in userEntries)
            {
                bool integerFormat = int.TryParse(userValue, out valueEntered);

                if (integerFormat == true)
                {
                    if (valueEntered != 0)
                    {
                        checked
                        {
                            int calculatedValue = 4 / valueEntered;
                        }
                    }
                    else
                    {
                        throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
                    }
                }
                else
                {
                    throw new FormatException("Invalid data. User input values must be valid integers.");
                }
            }
        }
    }

}
