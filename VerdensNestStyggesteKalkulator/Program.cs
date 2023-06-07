namespace VerdensNestStyggesteKalkulator
{
    /*
     Der du ser "#region Ignorer" kan du trykke på - tegnet på venstre siden for å minimere den delen av koden.
     Det er for å lage en meny du kan navigere med piltastene. Det er kult men unødvendig. Helt på bunn ligger
     ligger en versjon av koden uten denne delen.
     */
    internal class Program : Menu
    {
        readonly Calculator calc = new();
        private static void Main(string[] args)
        {
            #region Ignorer
            Options = new List<Option>
            {
                new("Ops", ChooseOperation),
                new("Help", () => Console.WriteLine(HelpText())),
                new("Exit", () => Environment.Exit(0)),
            };

            var index = 0;
            WriteMenu(Options, Options[index]);

            ConsoleKeyInfo keyinfo;

            do
            {
                keyinfo = Console.ReadKey(true);
                switch (keyinfo.Key)
                {
                    case ConsoleKey.DownArrow:
                        {
                            if (index + 1 < Options.Count)
                            {
                                index++;
                                WriteMenu(Options, Options[index]);
                            }
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        {
                            if (index - 1 >= 0)
                            {
                                index--;
                                WriteMenu(Options, Options[index]);
                            }

                            break;
                        }
                    case ConsoleKey.Enter:
                        Options[index].Selected.Invoke();
                        index = 0;
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
            } while (keyinfo.Key != ConsoleKey.X);
            #endregion
            Console.ReadKey(true);
        }

        #region Ignorer
        private static void ChooseOperation()
        {
            Console.Clear();
            Options = new List<Option>
            {
                new("Add", () => Start(Mode.Add)),
                new("Divide", () => Start(Mode.Divide)),
                new("Multiply", () => Start(Mode.Multiply)),
                new("Subtract", () => Start(Mode.Subtract)),
                new("Help", () =>  Console.WriteLine(HelpText())),
                new("Exit", () => Environment.Exit(0)),
            };
            const int index = 0;
            WriteMenu(Options, Options[index]);
        }

        private static void WriteMenu(List<Option> options, Option selectedOption)
        {
            Console.Clear();
            foreach (var option in options)
            {
                Console.Write(option == selectedOption ? @"> " : @" ");
                Console.WriteLine(option.Name);
            }
        }
        #endregion

        private static void Start(Mode mode)
        {
            Console.Clear();
            Console.WriteLine($"Please enter two numbers you would like to perform the {mode} operation on, seperated by a space...");
            var input = Console.ReadLine();

            #region Ignorer
            if (!string.IsNullOrEmpty(input) && input.ToLower() == "help") Console.WriteLine(HelpText());
            if (!string.IsNullOrEmpty(input) && input.ToLower() == "ops") ChooseOperation();
            if (!string.IsNullOrEmpty(input) && input.ToLower() == "exit") Environment.Exit(0);
            #endregion

            if (string.IsNullOrEmpty(input)) Start(mode);

            var inputArray = CleanInput(input, mode);
            dynamic numberArray = new dynamic[inputArray.Length];

            if (Convert.ToDecimal(inputArray[0]) % 1 == 0 && Convert.ToDecimal(inputArray[1]) % 1 == 0)
            {
                numberArray[0] = Convert.ToDecimal(inputArray[0]);
                numberArray[1] = Convert.ToDecimal(inputArray[1]);
            }
            else
            {
                numberArray[0] = Convert.ToInt32(inputArray[0]);
                numberArray[1] = Convert.ToInt32(inputArray[1]);
            }

            switch (mode)
            {
                case Mode.Add:
                    Console.WriteLine(Calculator.Add(numberArray[0], numberArray[1]));
                    break;
                case Mode.Divide:
                    Console.WriteLine(Calculator.Divide(numberArray[0], numberArray[1]));
                    break;
                case Mode.Multiply:
                    Console.WriteLine(Calculator.Multiply(numberArray[0], numberArray[1]));
                    break;
                case Mode.Subtract:
                    Console.WriteLine(Calculator.Subtract(numberArray[0], numberArray[1]));
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
            Start(mode);
        }

        public static string[] CleanInput(string input, Mode mode)
        {
            if (!input.Any(x => char.IsWhiteSpace(x))) 
            {
                Console.WriteLine("You have to seperate your numbers with a space");
                Start(mode);
            }

            var inputTrim = input.Replace(" ", "");
            if (!inputTrim.Any(x => char.IsDigit(x)))
            {
                Console.WriteLine("You can only enter digits");
                Start(mode);
            }

            return input.Split(' ');
        }

        private static string HelpText()
        {
            string[] allCommands = {
                "'Ops' to return to the operation selection menu",
                "'Help' to view a list of all availble commands.",
                "'Exit' to exit the application."
            };
            var availableCommands = allCommands.Aggregate("", (current, command) => current + ("     " + command + "\n"));
            Console.Clear();
            var stringToReturn = "Available commands: \n" + availableCommands;
            return stringToReturn;
        }

        public enum Mode
        {
            Add,
            Divide,
            Multiply,
            Subtract
        }
    }
}

/*

using System;
using static VerdensNestStyggesteKalkulator.Program;

namespace VerdensNestStyggesteKalkulator
{

    internal class Program
    {
        Calculator calc = new Calculator();

        private static void Main(string[] args)
        {
            Console.WriteLine("Please choose a mode of operation:\n1. Add\n2. Divide\n3. Multiply\n4. Subtract");
            var chosenMode = Console.ReadLine().ToLower();
            switch (chosenMode)
            {
                case "1":
                    Start(Mode.Add);
                case "Add":
                    Start(Mode.Add);
                case "2":
                    Start(Mode.Divide);
                case "Divide":
                    Start(Mode.Divide);
                case "3":
                    Start(Mode.Multiply);
                case "Multiply":
                    Start(Mode.Multiply);
                case "4":
                    Start(Mode.Subtract);
                case "Subtract":
                    Start(Mode.Subtract);
                default:
                    break;
            ]
        }

        private static void Start(Mode mode)
        {
            Console.Clear();
            Console.WriteLine($"Please enter two numbers you would like to perform the {mode} operation on, seperated by a space...");

            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) Start(mode);

            var inputArray = CleanInput(input, mode);
            dynamic numberArray = new dynamic[inputArray.Length];

            if (Convert.ToDecimal(inputArray[0]) % 1 == 0 && Convert.ToDecimal(inputArray[1]) % 1 == 0)
            {
                numberArray[0] = Convert.ToDecimal(inputArray[0]);
                numberArray[1] = Convert.ToDecimal(inputArray[1]);
            }
            else
            {
                numberArray[0] = Convert.ToInt32(inputArray[0]);
                numberArray[1] = Convert.ToInt32(inputArray[1]);
            }

            switch (mode)
            {
                case Mode.Add:
                    Console.WriteLine(Calculator.Add(numberArray[0], numberArray[1]));
                    break;
                case Mode.Divide:
                    Console.WriteLine(Calculator.Divide(numberArray[0], numberArray[1]));
                    break;
                case Mode.Multiply:
                    Console.WriteLine(Calculator.Multiply(numberArray[0], numberArray[1]));
                    break;
                case Mode.Subtract:
                    Console.WriteLine(Calculator.Subtract(numberArray[0], numberArray[1]));
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
            Start(mode);
        }

        public static string[] CleanInput(string input, Mode mode)
        {
            if (!input.Any(x => char.IsWhiteSpace(x)))
            {
                Console.WriteLine("You have to seperate your numbers with a space");
                Start(mode);
            }

            var inputTrim = input.Replace(" ", "");
            if (!inputTrim.Any(x => char.IsDigit(x)))
            {
                Console.WriteLine("You can only enter digits");
                Start(mode);
            }

            return input.Split(' ');
        }

        public enum Mode
        {
            Add,
            Divide,
            Multiply,
            Subtract
        }
    }
}
*/