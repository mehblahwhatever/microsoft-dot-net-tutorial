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
                    case 'J':
                        ImplicitExplicitConversions();
                        break;
                    case 'K':
                        WideningCoversions();
                        break;
                    case 'L':
                        ValueAndReferenceTypes();
                        break;
                    case 'M':
                        ConstEnumStructExamples();
                        break;
                    case 'N':
                        ArithmeticOperators();
                        break;
                    case 'O':
                        StringOperators();
                        break;
                    case 'P':
                        ComparisonOperators();
                        break;
                    case 'Q':
                        LogicalOperators();
                        break;
                    case 'R':
                        TypeOperators();
                        break;
                    case 'S':
                        OperatorPrecedence();
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
            // Implicit conversion of an integer to a decimal
            int unitsOrdered = 100;
            decimal unitPrice = 24.5M;
            decimal totalAmount;
            totalAmount = unitsOrdered * unitPrice;
            Console.WriteLine("{0} units at {1:C} a piece comes to a total of {2:C}", unitsOrdered, unitPrice, totalAmount);

            // Implicit conversion of a decimal to an integer will fail
            // int unitsOrdered = 100;
            // decimal unitPrice = 24.5M;
            // int totalAmount;
            // totalAmount = unitsOrdered * unitPrice;
        }

        static void WideningCoversions() {
            ConversionOperators();

            Console.WriteLine();
            Console.WriteLine("Do the same with the Convert class");
            Console.ReadKey();

            // Use the Convert class
            ConvertClass();

            Console.WriteLine();
            Console.WriteLine("Do the same with the Parse method");
            Console.ReadKey();

            // Use the Parse method
            ParseMethod();
        }

        static void ConversionOperators() {
            byte byteValue;
            short shortValue;
            int integerValue;
            long longValue;
            float floatValue;
            double doubleValue;
            decimal decimalValue;
            char charValue;
            string stringValue;

            byteValue = 2;
            shortValue = 100;
            Console.WriteLine("byteValue = {0}, shortValue is {1}", byteValue, shortValue);
            shortValue = (short)(shortValue + byteValue);
            Console.WriteLine("Add them and shortValue is {0}", shortValue);
            Console.WriteLine();

            shortValue = 100;
            integerValue = 1000;
            Console.WriteLine("shortValue is {0}, integerValue is {1}", shortValue, integerValue);
            integerValue = integerValue + (int)shortValue;
            Console.WriteLine("Add them and integerValue is {0}", integerValue);
            Console.WriteLine();

            integerValue = 1000;
            longValue = 3000000;
            Console.WriteLine("integerValue is {0}, longValue is {1}", integerValue, longValue);
            longValue = longValue + (long)integerValue;
            Console.WriteLine("Add them and longValue is {0}", longValue);
            Console.WriteLine();

            longValue = 3000000;
            floatValue = 2000.12341F;
            Console.WriteLine("longValue is {0}, floatValue is {1}", longValue, floatValue);
            floatValue = floatValue + (float)longValue;
            Console.WriteLine("Add them and longValue is {0}", floatValue);
            Console.WriteLine();

            floatValue = 2000.12341F;
            doubleValue = 50000.1234;
            Console.WriteLine("floatValue is {0}, doubleValue is {1}", floatValue, doubleValue);
            doubleValue = doubleValue + (double)floatValue;
            Console.WriteLine("Add them and doubleValue is {0}", doubleValue);
            Console.WriteLine();

            doubleValue = 50000.1234;
            decimalValue = 6000000.1234M;
            Console.WriteLine("doubleValue is {0}, decimalValue is {1}", doubleValue, decimalValue);
            decimalValue = decimalValue + (decimal)doubleValue;
            Console.WriteLine("Add them and decimalValue is {0}", decimalValue);
            Console.WriteLine();

            decimalValue = 6000000.1234M;
            stringValue = "ABC";
            Console.WriteLine("decimalValue is {0}, stringValue is {1}", decimalValue, stringValue);
            stringValue = stringValue + decimalValue.ToString();
            Console.WriteLine("Add them together and stringValue is {0}", stringValue);
            Console.WriteLine();

            charValue = 'A';
            stringValue = "ABC";
            Console.WriteLine("stringValue is {0}, charValue is {1}", stringValue, charValue);
            stringValue = stringValue + charValue.ToString();
            Console.WriteLine("Add them and stringValue is {0}", stringValue);
            Console.WriteLine();
        }

        static void ConvertClass() {
            byte byteValue;
            short shortValue;
            int integerValue;
            long longValue;
            float floatValue;
            double doubleValue;
            decimal decimalValue;
            char charValue;
            string stringValue;

            byteValue = 2;
            shortValue = 100;
            Console.WriteLine("byteValue is {0}, shortValue is {1}", byteValue, shortValue);
            shortValue = Convert.ToInt16(shortValue + byteValue);
            Console.WriteLine("Add them and shortValue is {0}");
            Console.WriteLine();

            shortValue = 100;
            integerValue = 1000;
            Console.WriteLine("shortValue is {0}, integerValue is {1}", shortValue, integerValue);
            integerValue = integerValue + Convert.ToInt32(shortValue);
            Console.WriteLine("Add them and integerValue is {0}", integerValue);
            Console.WriteLine();

            integerValue = 1000;
            longValue = 3000000;
            Console.WriteLine("integerValue is {0}, longValue is {1}", integerValue, longValue);
            longValue = longValue + Convert.ToInt64(integerValue);
            Console.WriteLine("Add them and longValue is {0}", longValue);
            Console.WriteLine();

            longValue = 3000000;
            floatValue = 2000.12341F;
            Console.WriteLine("longValue is {0}, floatValue is {1}", longValue, floatValue);
            floatValue = floatValue + Convert.ToSingle(longValue);
            Console.WriteLine("Add them and longValue is {0}", floatValue);
            Console.WriteLine();

            floatValue = 2000.12341F;
            doubleValue = 50000.1234;
            Console.WriteLine("floatValue is {0}, doubleValue is {1}", floatValue, doubleValue);
            doubleValue = doubleValue + Convert.ToDouble(floatValue);
            Console.WriteLine("Add them and doubleValue is {0}", doubleValue);
            Console.WriteLine();

            doubleValue = 50000.1234;
            decimalValue = 6000000.1234M;
            Console.WriteLine("doubleValue is {0}, decimalValue is {1}", doubleValue, decimalValue);
            decimalValue = decimalValue + Convert.ToDecimal(doubleValue);
            Console.WriteLine("Add them and decimalValue is {0}", decimalValue);
            Console.WriteLine();

            decimalValue = 6000000.1234M;
            stringValue = "ABC";
            Console.WriteLine("decimalValue is {0}, stringValue is {1}", decimalValue, stringValue);
            stringValue = stringValue + Convert.ToString(decimalValue);
            Console.WriteLine("Add them together and stringValue is {0}", stringValue);
            Console.WriteLine();

            charValue = 'A';
            stringValue = "ABC";
            Console.WriteLine("stringValue is {0}, charValue is {1}", stringValue, charValue);
            stringValue = stringValue + Convert.ToString(charValue);
            Console.WriteLine("Add them and stringValue is {0}", stringValue);
            Console.WriteLine();
        }

        static void ParseMethod() {
            byte byteValue;
            short shortValue;
            int integerValue;
            long longValue;
            float floatValue;
            double doubleValue;
            decimal decimalValue;
            char charValue;
            string stringValue;

            byteValue = 2;
            shortValue = 100;
            Console.WriteLine("byteValue is {0}, shortValue is {1}", byteValue, shortValue);
            shortValue = Int16.Parse((shortValue + byteValue).ToString());
            Console.WriteLine("Add them and shortValue is {0}");
            Console.WriteLine();

            shortValue = 100;
            integerValue = 1000;
            Console.WriteLine("shortValue is {0}, integerValue is {1}", shortValue, integerValue);
            integerValue = integerValue + Int32.Parse(shortValue.ToString());
            Console.WriteLine("Add them and integerValue is {0}", integerValue);
            Console.WriteLine();

            integerValue = 1000;
            longValue = 3000000;
            Console.WriteLine("integerValue is {0}, longValue is {1}", integerValue, longValue);
            longValue = longValue + Int64.Parse(integerValue.ToString());
            Console.WriteLine("Add them and longValue is {0}", longValue);
            Console.WriteLine();

            longValue = 3000000;
            floatValue = 2000.12341F;
            Console.WriteLine("longValue is {0}, floatValue is {1}", longValue, floatValue);
            floatValue = floatValue + Single.Parse(longValue.ToString());
            Console.WriteLine("Add them and longValue is {0}", floatValue);
            Console.WriteLine();

            floatValue = 2000.12341F;
            doubleValue = 50000.1234;
            Console.WriteLine("floatValue is {0}, doubleValue is {1}", floatValue, doubleValue);
            doubleValue = doubleValue + Double.Parse(floatValue.ToString());
            Console.WriteLine("Add them and doubleValue is {0}", doubleValue);
            Console.WriteLine();

            doubleValue = 50000.1234;
            decimalValue = 6000000.1234M;
            Console.WriteLine("doubleValue is {0}, decimalValue is {1}", doubleValue, decimalValue);
            decimalValue = decimalValue + Decimal.Parse(doubleValue.ToString());
            Console.WriteLine("Add them and decimalValue is {0}", decimalValue);
            Console.WriteLine();
        }

        static void ValueAndReferenceTypes() {
            object objectOne;
            int numberOne;

            numberOne = 77;
            objectOne = numberOne;

            Console.WriteLine("objectOne is {0}", objectOne);

            string stringOne;
            stringOne = numberOne.ToString();

            Console.WriteLine("stringOne is " + stringOne);
        }

        static void ConstEnumStructExamples() {
            UsingStructs();
            UsingEnumerations();
            UsingStructs();
        }

        static void UsingConstants() {
            const int monthsInYear = 12;
            const int daysInYear = 365;

            Console.WriteLine("There are {0} months and {1} days in a year", monthsInYear, daysInYear);
            Console.WriteLine();
        }

        enum CalendarWeek {
            Sunday = 1,
            Monday = 2,
            Tuesday = 3,
            Wednesday = 4,
            Thursday = 5,
            Friday = 6,
            Saturday = 7
        }

        enum WorkWeek {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }

        static void UsingEnumerations() {
            Console.WriteLine("Sunday is day " + (int)CalendarWeek.Sunday + " in the calendar week");
            Console.WriteLine();
            Console.WriteLine("Sunday is day " + (int)WorkWeek.Sunday + " in the work week");
            Console.WriteLine();
        }

        struct Author {
            public string FirstName;
            public string LastName;
            public string Company;
            public string Title;
        }

        static void UsingStructs() {
            Author author1;
            author1.FirstName = "Ken";
            author1.LastName = "Getz";
            author1.Title = "Sr. Consultant";
            author1.Company = "MCW Technologies";

            Author author2;
            author2.FirstName = "Robert";
            author2.LastName = "Green";
            author2.Title = "Sr. Consultant";
            author2.Company = "MCW Technologies";

            Console.WriteLine("{0} {1} is a {2} with {3}", author1.FirstName, author1.LastName, author1.Title, author1.Company);
            Console.WriteLine("{0} {1} is a {2} with {3}", author2.FirstName, author2.LastName, author2.Title, author2.Company);
        }

        static void ArithmeticOperators() {
            double totalAmount = 100;
            double result;

            Console.WriteLine("totalAmount is {0}", totalAmount);
            Console.WriteLine();

            result = totalAmount + 100;
            Console.WriteLine("totalAmount + 100 is {0}", result);

            result = totalAmount - 50;
            Console.WriteLine("totalAmount - 50 is {0}", result);

            result = totalAmount * 6;
            Console.WriteLine("totalAmount * 6 is {0}", result);

            result = totalAmount / 17;
            Console.WriteLine("totalAmount / 17 is {0}", result);

            result = totalAmount % 17;
            Console.WriteLine("totalAmount % 17 is {0}", result);

            result = totalAmount % 17.5;
            Console.WriteLine("totalAmount % 17.5 is {0}", result);

            result = ++totalAmount;
            Console.WriteLine("++totalAmount is {0}", result);

            result = --totalAmount;
            Console.WriteLine("--totalAmount is {0}", result);
        }

        static void StringOperators() {
            string author1 = "Ken";
            string author2 = "Robert";
            string greeting = author1 + " and " + author2 + " say hello";

            Console.WriteLine(greeting);
        }

        static void ComparisonOperators() {
            int number1 = 100;
            int number2 = 200;

            Console.WriteLine("number1 = {0}, number2 = {1}", number1, number2);

            Console.WriteLine("number1 == number2: {0}", number1 == number2);

            Console.WriteLine("number1 != number2: {0}", number1 != number2);

            Console.WriteLine("number1 + 200 > number2: {0}", number1 + 200 > number2);

            Console.WriteLine("number1 < number2 - 100: {0}", number1 < number2 - 100);

            Console.WriteLine("number1 >= number2: {0}", number1 >= number2);

            Console.WriteLine("number1 <= number2: {0}", number1 <= number2);
        }

        static void LogicalOperators() {
            int number1 = 100;
            int number2 = 200;
            int number3 = 1000;
            int number4 = 2000;
            string author1 = "Ken";
            string author2 = "Robert";
            string author;

            if ((number1 < number2) & (number3 < number4)) {
                Console.WriteLine("Both are true: {0} < {1}, {2}, < {3}", number1, number2, number3, number4);
            }

            author = "Robert";
            if ((author == author1) | (author == author2)) {
                Console.WriteLine("Either Ken or Robert wrote this example");
            }

            if (!(number1 > number2)) {
                Console.WriteLine("{0} is not > {1}", number1, number2);
            }

            if ((author1 == "Andy") && (author2 == "Robert")) {
                Console.WriteLine("Andy and Robert wrote this course");
            }

            if ((author1 == "Ken") || (author2 == "Robert")) {
                Console.WriteLine("Ken wrote this course and Robert may also have");
            }
        }

        static void TypeOperators() {
            object object1;

            object1 = 7;
            if (object1 is int) {
                Console.WriteLine("object1 = 7 and is type Integer");
            }

            object1 = 7M;
            if (object1 is decimal) {
                Console.WriteLine("object1 = 7M and is type Decimal");
            }

            object1 = "Tuesday";
            if (object1 is string) {
                Console.WriteLine("object1 = \"Tuesday\" and is type String");
            }

            object1 = 2045.75F;
            Console.WriteLine("object1 is type {0}", object1.GetType());
        }

        static void OperatorPrecedence() {
            int firstAmount = 100;
            int secondAmount = 200;
            int thirdAmount = 300;

            if (firstAmount > 50 && secondAmount > 300 || thirdAmount < 500) {
                Console.WriteLine("firstAmount > 50");
                Console.WriteLine("Also, either secondAmount > 300 or thirdAmount < 500");
            }

            if ((firstAmount > 50 && secondAmount > 300) || thirdAmount < 500) {
                Console.WriteLine("Both firstAmount > 50 and secondAmount > 300");
                Console.WriteLine("Or thirdAmount < 500");
            }


        }
    }
}
