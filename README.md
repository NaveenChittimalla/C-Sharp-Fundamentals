# C-Sharp-Fundamentals

### Syntax
C# syntax is inspired from C and C++ languages.

Let's describe syntax using the following program.


###### Print Hello World! program
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
###### Output:
```
Hello World!"
```

### Identifiers and Keywords


### Data Types

#### Numeric Data Types

##### int
int is a 32-bit numeric data type which accepts numeric numbers from -2,147,483,648 to 2,147,483,647.


```
int number = 9;
Console.WriteLine(int): 
Console.WriteLine(int.MaxValue);
Console.WriteLine(int.MinValue); 
```
###### Output:
```
 9
-2,147,483,648 
 2,147,483,647 
```
