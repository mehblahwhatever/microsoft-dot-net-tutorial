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


