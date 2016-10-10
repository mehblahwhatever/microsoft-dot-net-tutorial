# Notes

## What is .NET, Anyway?

* 1991: Windows "sits" on top of DOS
	* Windows apps require Windows runtime environment
	* Windows apps provide a consistent API for communicating with drivers, devices, and so on
* 2001: .NET Runtime "sits" on top of Windows
	* .NET apps require .NET runtime environment
	* .NET apps provide a consistent API for working with Windows, data structures, types, and more
* .NET provides an environment that handles data types, memory management, APIs, and much more

## Why .NET?

* Before .NET, software development required mastery of multiple technologies and authoring tools
	* Manually stitched together various programming tools
* For example:
	* Web sites? Required VB Scripting or Jscript and HTML
	* Database apps? SQL/SQL Server
	* Business applications? Visual Basic
	* Office applications? VBA
	* Stremlined graphics? C++

## Advantages of .NET

* .NET provides remedies:
	* Object-oriented view of Windows: .NET Framework encapsulates lots of functionality into classes
	* Application security built in
	* Deploying applications is easier
		* Assembly contains and describes unit of deployment
	* Versioning issues largely handled without effort
	* Assemblies can be digitally signed
	* Unless using COM, no need for registration
	* All .NET languages are interoperable

## .NET Framework Architecture

## Common Language Runtime

* Common Language Runtime (CLR) provides runtime environment for all .NET applications
* CLR's purpose is to load and run applications compiled to Intermediate Language (IL)
	* Each .NET compiler creates IL as its output
* CLR manages .NET base services:
	* Memory management
	* Garbage collection
	* Exception handling
	* Loading/Running applications

## CLR and Running Code

* CLR allows you to run both managed and unmanaged code
	* *Unmanaged* code runs outside the CLR
		* VB6/C++ code compiled without .NET
	* *Managed* code runs "within" the CLR, and benefits from the CLR's features

## CLR and Compilers

* .NET Compilers create Microsoft Intermediate Language (MSIL, or just IL) as output
* At execution time, Just-In-Time (JIT) compiler converts code to native executable

## More about JIT

* JIT compiler takes native processor into account
	* Creates code optimized for the local environment
	* Makes decisions about how to optimize code at runtime
* Only needs to compile the applicaiton once:
	* Compiled "bits" cached locally
	* Performance overhead is very slight, if any
* Remember: .NET Runtime/CLR must be installed on client computers in order to run .NET code

## .NET Framework Base Class Library

* BCL consists of classes that provide base functionality for .NET Framework
	* And many classes that make your life as a developer easier
	* Library of classes used by all .NET applications
* Contains large number of classes (blocks of functionality, including properties, methods, and events) grouped into namespaces
	* Each class within namespace has a unique name
* BCL's namespaces group classes into common blocks of functionality

## Common BCL Namespaces

* System
* System.Data
* System.Diagnostics
* System.Globalization
* System.IO
* System.Text
* System.Text.RegularExpressions
* System.Web
* System.Windows.Forms
* System.Xml

## .NET Languages

* Microsoft provides several .NET languages:
	* Visual Basic, C#, C++, Jscript
	* Other vendors provide other languages
		* Python, Fortran, Cobol, and many more
* How do languages interoperate?
	* .NET provides:
		* Common Language Specification (CLS): Describes how .NET languages should work
		* Common Type System (CTS): Describes how data types should work together
	* In the end: All .NET languages compile to IL

## Examining a .NET Application: Introducing Assemblies

* Compile managed code: create *assembly*
* Theoretically, assembly can contain multiple modules
	* Visual Studio only supports creating single-module assemblies
	* Output looks like EXE or DLL
		* Actually contains compiled IL, and information about the assembly
	* Metadata contains manifest that describes the assembly, procedures and types it exports, and other assemblies it requires

## What's in the Manifest?

* Version, name, culture, security requirements
* List of other files in assembly and cryptographic hash for each file
* List of public types
* List of external required references
* Use ILDASM.EXE to examine contents

## What Can You Create?

* .NET allows you to create a large range of applications
* Visual Studio includes templates for (among others):
	* Windows applications
	* Console applications
	* Class library
	* Windows contol library
	* Web control library
	* Web application
	* XML Web Service

## Working with Profile Settings

* User profiles allow you to control Visual Studio behavior
* Can use pre-set defaults for:
	* Options
	* Menus
	* Key bindings
	* Toolbars
* Pick profile when you first run Visual Studio
	* Or change it any time
* Demonstration saves and restores profile

## Debugging and Handling Exceptions

* No matter how carefully you code
	* You'll make coding errors
	* Errors will occur at runtime
* Three types of errors:
	* Syntax errors
	* Runtime errors
	* Logic errors
* Visual Studio provides powerful tools to help you in your debugging process

## Variables

* Computer programs manage information
* Variables are a way to store information
* Variables exist in memory
* Created at the start of programs or as needed
* Variables have three components
	* Data type
	* Name
	* Value

## Naming Variables

* Variable names must
	* Begin with an alphabetic character or underscore
	* Contain only alphabetic characters, numbers, and underscores
	* Contain at least one alphabetic character or number if they begin with an underscore
	* Be less than 1023 characters
* Variable names should be descriptive and of reasonable length
	* ```A = B + 7```
	* ```EmployeeSalaryAfterRaise = EmployeeSalaryBeforeRaise * 1.05```
	* ```New Salary = CurrentSalary * 1.05```

## Declaring Variables

* To declare a variable and allocate storage space for it in memory, first specify the data type and then specify the variable's name

```cs
int counter1;
int counter2 = 612;

string message1, message2, message3;
message2 = "";
message3 = "Hello";
```

## Variable Lifetime and Scope

* Variable's lifetime is length of time it is available
	* Variable declared in a method will be in memory while method is running
* Variable's scope determines what code can reference it
	* Variable declared in a method will be available only to that method
	* Declare a variable at the class level for it to be available to multiple methods

## Data Types

* All information has a type
* Type defines how information will be stored, used, manipulated, and displayed
* .NET Framework contains structures and classes that represent various types of data
* All data types in Visual Basic and C# are based on a .NET Framework structure or class

## Integer Data Types

* sbyte - based on System.SByte
	* Signed 8-bit integer between -128 and 127
* byte - based on System.Byte
	* 8-bit integer between 0 and 255
* short - based on System.Int16
	* 16-bit integer between -32,768 and 32,767
* ushort - based on System.Int16
	* 16-bit unsigned integer between 0 and 65,535
* int - based on System.Int32
	* 32-bit integer between -2,147,483,648 and 2,147,483,647
* uint - based on System.Int32
	* 32-bit unsigned integer betwen 0 and 4,294,967,295
* long - based on System.Int64
	* 64-bit integer between -9,223,372,036,854,775,808 and 9,223,372,036,854,775,807
* ulong - based on System.Int64
	* 64-bit unsigned integer between 0 and 18,446,744,073,709,551,615

## Choosing an Integer Data Type

* Choose a data type that is appropriate for the data you will store
* Balance memory requirement and performance
	* **int** requires twice as much storage space (4 bytes) than **short** (2 bytes)
	* **int** and **long** are more efficient than **Byte** or **short** because .NET Framework represents numbers as 32-bit or 64-bit values
* Use **int** unless you have valide concerns about memory usage

## Data Types Fields and Methods

* **MinValue** and **MaxValue** represent low and high end of range of values
* **ToString** returns strign representation of value
	* Specify format to control how string is displayed

## Floating-Point Data Types

* float - based on System.Single
	* 32-bit single-precision floating point number between -3.402823E38 and -1.401298E-45 for negative values and 1.401298E-45 and 3.402823E38 for positive values
* double - based on System.Double
	* 64-bit double-precision floating point number between -1.79769313486231570E308 and -4.94065645841246544E-324 for negative values and between 4.94065645841246544E-324 and 1.79769313486231570E308 for positive values
* Use **double** unless you have valide concerns about memory usage

## Decimal Data Type

* Based on System.Decimal
	* 128-bit number between -79,228,162,514,264,337,593,543,950,335 and 79,228,162,514,264,337,593,543,950,335 with no decimal places and between -7.9228162514264337593543950335 and 7.9228162514264337593543950335 with up to 28 decimal places
* Holds numbers of lesser magnitude than floating points but with greater precision
* Use when you need the utmost in precision, especially for financial calculations

## Decimal Data Type Fields and Methods

* **Truncate** returns integer parts and discards fractional part
* **Round** rounds to nearest integer or to a specified number of decimal places
* **Floor** rounds to integer smaller than or equal to the value
* **Ceiling** rounds to integer greater than or equal to the value

## Char Data Type

* Based on System.Char
	* 16-bit numberic value between 0 to 65535
* Holds code points, or character codes, representing a single Unicode character
	* The first 128 code points, numbers 0 through 127, are the ASCII character set

## Char Data Type Methods

* **ConvertFromUtf32** returns Unicode character associated with code point
* **ConvertToUtf32** returns code point associated with Unicode character
* **IsControl** indicates if a tab, carriage return or line feed
* **IsDigit** indicates if a decimal digit
* **IsLetter** indicates if an alphabetic letter
* **IsLetterOrDigit** indicates if a letter or digit
* **IsLower** inidicates if a lower case letter
* **IsNumber** indicates if a number
* **IsPunctuation** indicates if a punctuation mark
* **IsSeparator** inidicates if a separator, such as a space
* **IsUpper** indicates if an upper case letter
* **IsWhitespace** indicates if whitespace

## String Data Type

* Based on System.String
	* Represents a series of 0 to 2 billion characters
* Use escape sequence ```\``` or preface the string with ```@``` to include quotation marks and backslashes in strings
	* ```string greeting1 = "Hello \" Robert\"";```
	* ```string greeting2 = @"Hello ""Robert""";```

## Bool Data Type

* Based on System.Boolean
	* 0 (True) or 1 (False)
* Used to test conditions

```cs
if (firstVariable > secondVariable) {
	Console.WriteLine("{0} is greater than {1}", firstVariable, secondVariable);
}
```

Object Data Type

* Based on System.Object
* Can contain any data type, including another object
* Use **GetType** to determine what type of data is stored
* Contains a pointer to the value in memory, not actual data

## Converting to Another Data Type

* Widening conversion
	* New data type can store all of the values of the original data type
	* Compiler will make the conversion for you
* Narrowing conversion
	* New data type **cannot** store all of the values of the original data type
	* Loss of data could result
	* Need to make the conversion in code
* Make your conversions explicitly in code
	* Code is more readable and understandable
* Use a cast operator
	* ```shortValue = (short)(shortValue + byteValue);```
* **Convert** class includes a conversion method for each data type
	* ```Convert.ToSingle(longValue);```
* **Parse** method converts a string to a data type
	* ```Single.Parse(longValue.ToString());```

## Value Types and Reference Types

* Value type variables directly store their values
	* Stored in the stack, pool of memory allocated by runtime for value types
	* Declared in code and runtime allocates proper amount of memory for them
	* Efficient because space has already been allocated on stack
* Reference type variable store a reference to their values
	* Stored in the heap, a pool of memory whose size is dynamic
	* Value is stored in the stack, but variable stores a reference to value
	* Reference is used to find value each time variable is accessed in code
	* Less efficient than value types
* Boxing
	* A value type is converted to a reference type
	* .NET Framework copies the value to the heap and returns a reference to the value
* Unboxing
	* A reference type is converted to a value type
	* .NET Framework uses the reference to copy the value back into a value type

## Constants

* Declared like variables
* Value cannot be changed in code

## Enumerations

* Collection of related constants
* Has a name and a numeric data type
* Has a number of fields, each with a name and a value

## Structs

* Structs are user defined data types
* Similar to enumerations in that they are a collection of values
* Can contain any data type

## Operators

* Perform an action on one or more values and return the result of the operation
	* Arithmetic operators
	* String operators
	* Assignment operators
	* Comparison operators
	* Logical operators
	* Type operators

## Arithmetic Operators

* Perform basic arithmetic on one or more variables
	* ```+``` adds two numbers or converst a negative number into a positive number
	* ```-``` subtracts two numbers or converts a positive number into a negative number
	* ```*``` multiplies two numbers
	* ```/``` divides two numbers
	* ```%``` divides two numbers and returns only the remainder of the result
	* ```++``` increments a number by 1
	* ```--``` decrements a number by 1

## String Operators

* ```+``` operator concatenates, or adds, two strings together to produce a new string

## Assignment Operators

* Perform similar operations as arithmetic operators
	* ```+=``` adds two numbers or converts a negative number into a positive number
	* ```-=``` subtracts two numbers or converts a positive number into a negative number
	* ```*=``` multiplies two numbers
	* ```/=``` divides two numbers
	* ```%=``` divides two numbers and returns only the remainder of the result

## Comparison Operators

* Used to compare two values
	* ```==``` returns true if two values are equal
	* ```!=``` returns true if two values are not equal
	* ```>``` returns true if the first value is greater than the second
	* ```<``` returns true if the first value is less than the second
	* ```>=``` returns true if the first value is greater than or equal to the second
	* ```<=``` returns true if the first value is less than or equal to the second

## Logical Operators

* Used to compare two expressions
	* ```A & B``` returns true if both A and B are true
	* ```A | B``` returns true if either A or B is true
	* ```! A``` returns true if A is not true
	* ```A ^ B``` returns true if either A or B is true but not both of them are true
	* ```A && B``` returns true if both A and B are true. Does not evaluate B if A is not true
	* ```A || B``` returns true if either A or B is true. Does not evaluate B is A is true

## Type Operators

* Test whether an object is of a particular data type

```cs
object object1;

object1 = 7;
if (object1 is int) {
	Console.WriteLine("object1 = 7 and is type Integer");
}
```

