# C-Sharp-Fundamentals

### Syntax
C# syntax is inspired from C and C++ languages.

Let's describe syntax using the following program.


**Print Hello World! program**
```
using System;

namespace CSharpFundamentals
{
   class Program
   {
      static void Main(string[] args)
      {

        string message = "Hello World!";
    Console.WriteLine(message);

      }
   }
}
```
Output:
```
Hello World!
```

### Identifiers and Keywords
**Identifiers** are the names we choose for our classes, interfaces, methods, parameters, variables, and so on.

Here are the identifiers in our program.

```
System CSharpFundamentals Program Main args message Console WriteLine
```

**Keywords** are the names that mean something special to the C# compiler. 

Here are the keywords in our program.

```
using namespace class static void string
```

Keywords are *reserved*, which means you can't use them as identifiers.

If you really want to use keyword as identifiers and avoid conflicts, you can do so by prefixing with @. For example, 

```
class class {....} //Not allowed
class @class {....} // Allowed
```
The @ symbol won't be part of the actual identifier. So, *@myClass* is same as *myClass*.

### Variables
**Variables** represents storage locations. Every variable in C# has a data type that determines what values can be stored in it. 

*Data Type determines the size, the range of values that can be stored in memory and operations that can be applied to the variables. More about data types in the next section.*

**Declare (Create) a variable**
Variables can be declared and assigned at once as below.

Syntax:
**type** *variableName* = *value*;

```
int numberOfMonthsInYear = 12 ; // variable of type int, which can store whole numbers like 12, 123 or -123.
```

Variables can also be declared without initial assignment and assign a value later in the program.

```
int numberOfMonthsInYear; // Declare.

numberOfMonthsInYear = 12; // Assign a value.

```

### Data Types

#### Numeric Data Types

##### int
**int** is a 32-bit numeric data type which accepts numeric numbers from -2,147,483,648 to 2,147,483,647.


```
int number = 9;
Console.WriteLine(int): 
Console.WriteLine(int.MaxValue);
Console.WriteLine(int.MinValue); 
```

Output:
```
 9
-2,147,483,648 
 2,147,483,647 
```
