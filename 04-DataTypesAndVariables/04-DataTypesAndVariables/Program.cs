using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesAndVariables {
    class Program {
        static void Main(string[] args) {
            // Main Menu Code
            string[] SELECTIONS = {
                "Variable Scope",
                "Minimum and Maximum Values",
                "Converting to Strings",
                "Decimal Literals",
                "Decimal Data Type",
                "Char Data Type",
                "String Data Type",
                "Boolean Data Type",
                "Object Data Type",
                "Implicit Conversions",
                "Widening Conversions",
                "Value and reference types",
                "Constants, Enumerations, Structures",
                "Arithmetic Operators",
                "String Operators",
                "Comparison Operators",
                "Logical Operators",
                "Type Operators",
                "Operator Precedence"
            };

            char userSelection = ' ';
            do {
                Console.WriteLine();
                switch (userSelection) {
                    case 'A':
                        VariableLifetime();
                        VariableScope();
                        ShowTotalAmount();
                        break;
                    case 'B':
                        MinMaxValues();
                        break;
                    case 'C':
                        FormattingWithToString();
                        break;
                    case 'D':
                        DecimalLiterals();
                        break;
                    case 'E':
                        DecimalDataTypes();
                        break;
                    case 'F':
                        CharDataType();
                        break;
                    case 'G':
                        StringDataType();
                        break;
                    case 'H':
                        BooleanDataType();
                        break;
                    case 'I':
                        ObjectDataType();
                        break;
                    default:
                        Console.WriteLine("Option not available for {0}.", userSelection);
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

                for (char i = 'A'; i <= 'S'; i++) {
                    Console.WriteLine("{0}: {1}", i, SELECTIONS[i - 'A']);
                }
                Console.WriteLine();
                Console.WriteLine("Enter an option <X to exit>:");

                userSelection = Console.ReadKey().KeyChar;
            } while (userSelection != 'X');
        }

        static void VariableLifetime() {
            int totalAmount = 100;
            totalAmount = totalAmount + 100;
        }

        static int totalAmount;

        static void VariableScope() {
            totalAmount = 100;
            ShowTotalAmount();
        }

        static void ShowTotalAmount() {
            Console.WriteLine("Total amount in {0}", totalAmount);
        }

        static void MinMaxValues() {
            // Integer data types
            Console.WriteLine(
                "A byte valiable can be between {0} and {1}",
                byte.MinValue, byte.MaxValue);
            Console.WriteLine(
                "An sbyte variable can be between {0} and {1}",
                sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine(
                "A ushort valriable can be between {0} and {1}",
                ushort.MinValue, ushort.MaxValue);
            Console.WriteLine(
                "An int variable can be between {0} and {1}",
                int.MinValue, int.MaxValue);
            Console.WriteLine(
                "A uint variable can be between {0} and {1}",
                uint.MinValue, uint.MaxValue);
            Console.WriteLine(
                "A long variable can be between {0} and {1}",
                long.MinValue, long.MaxValue);
            Console.WriteLine(
                "A ulong variable can be between {0} and {1}",
                ulong.MinValue, ulong.MaxValue);
            Console.WriteLine();

            // Floating point data types
            Console.WriteLine(
                "A single variable can be betwwen {0} and {1}",
                Single.MinValue, Single.MaxValue);
            Console.WriteLine(
                "A double variable can be between {0} and {1}",
                Double.MinValue, Double.MaxValue);
            Console.WriteLine();

            // Decimal point data types
            Console.WriteLine(
                "A decimal variable can be between {0} and {1}",
                Decimal.MinValue, Decimal.MaxValue);
            Console.WriteLine();

            // DateTime data types
            Console.WriteLine(
                "A DateTime variable can be between {0} and {1}",
                DateTime.MinValue, DateTime.MaxValue);
        }

        static void FormattingWithToString() {
            int totalAmount = 1000;

            Console.WriteLine("The value of intVariable is " + totalAmount.ToString());
            Console.WriteLine("intVariable in general format is " + totalAmount.ToString("g"));
            Console.WriteLine("intVariable in decimal format is " + totalAmount.ToString("d"));
            Console.WriteLine("intVariable in number format is " + totalAmount.ToString("n"));
            Console.WriteLine("intVariable in currency format is " + totalAmount.ToString("c"));
            Console.WriteLine("intVariable in hexadecimal format is " + totalAmount.ToString("x"));
        }

        static void DecimalLiterals() {
            decimal totalAmount;
            totalAmount = 45.61M;
            Console.WriteLine(totalAmount);
        }

        static void DecimalDataTypes() {
            decimal totalAmount;
            totalAmount = 45.61M;
            decimal totalDollars, totalCents;

            totalDollars = decimal.Truncate(totalAmount);
            totalCents = totalAmount - totalDollars;

            Console.WriteLine("The restaurant bill is {0:C}", totalAmount);
            Console.WriteLine("You pay the {0:C}, and I'll pay the {1:C}", totalDollars, totalCents);
            Console.WriteLine();

            totalAmount = 45.674586748657M;
            Console.WriteLine("The total amount is {0}", totalAmount);
            Console.WriteLine("Rounded to 0 decimal places, this value is {0}", Decimal.Round(totalAmount));
            Console.WriteLine("Rounded to 4 decimal places, this value is {0}", Decimal.Round(totalAmount, 4));
            Console.WriteLine();

            totalAmount = -45.61M;
            Console.WriteLine("Profit last month was {0}", totalAmount);
            Console.WriteLine();

            decimal totalDollars1;
            decimal totalDollars2;
            totalDollars1 = Decimal.Floor(totalAmount);
            totalDollars2 = Decimal.Ceiling(totalAmount);

            Console.WriteLine("Rounding down this number is {0}", totalDollars1);
            Console.WriteLine("Roundign up this number is {0}", totalDollars2);
        }

        static void CharDataType() {
            Console.WriteLine("Code point 82 is {0}", char.ConvertFromUtf32(82));
            Console.WriteLine("The code point of R is {0}", char.ConvertToUtf32("R", 0));
            Console.WriteLine();

            char charVariable1 = 'A';
            char charVariable2 = '7';
            char charVariable3 = '+';

            Console.WriteLine("A is a control character: {0}", char.IsControl(charVariable1));
            Console.WriteLine("A is a digit: {0}", char.IsDigit(charVariable1));
            Console.WriteLine("A is a letter: {0}", char.IsLetter(charVariable1));
            Console.WriteLine("A is lowercase: {0}", char.IsLower(charVariable1));
            Console.WriteLine("7 is a number: {0}", char.IsNumber(charVariable2));
            Console.WriteLine("7 is punctuation: {0}", char.IsPunctuation(charVariable2));
            Console.WriteLine("+ is a separator: {0}", char.IsSeparator(charVariable3));
            Console.WriteLine("+ is a symbol: {0}", char.IsSymbol(charVariable3));
            Console.WriteLine("+ is white space: {0}", char.IsWhiteSpace(charVariable3));
        }

        static void StringDataType() {
            string greeting1 = "Hello \"Robert\"";
            string greeting2 = @"Hello ""Robert""";

            Console.WriteLine(greeting1);
            Console.WriteLine(greeting2);
            Console.WriteLine();

            Console.WriteLine("The file is on \\server\allcode.");
            Console.WriteLine("The file is on \\\\server\\allcode.");
            Console.WriteLine(@"The file is on \\server\allcode.");
        }

        static void BooleanDataType() {
            int firstVariable = 7;
            int secondVariable = 6;
            if (firstVariable > secondVariable) {
                Console.WriteLine("{0} is greater than {1}", firstVariable, secondVariable);
            }
        }

        static void ObjectDataType() {
            object anything;
            anything = 7;
            Console.WriteLine("{0} is {1}", anything, anything.GetType());

            anything = 65.76;
            Console.WriteLine("{0} is {1}", anything, anything.GetType());

            anything = "A";
            Console.WriteLine("{0} is {1}", anything, anything.GetType());
        }

        static void ImplicitExplicitConversions() {

        }
    }
}
