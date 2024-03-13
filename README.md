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
Hello World!
```

### Identifiers and Keywords
**Identifiers** are the names you choose for classes, interfaces, methods, parameters, variables, and so on.

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
class class {....} $${\color{lightgreen}// Not \space allowed}$$
class @class {....} // Allowed
```
Actually, the @ symbol won't be part of the identifier. So, *@myClass* is same as *myClass*.


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
###### Output:
```
 9
-2,147,483,648 
 2,147,483,647 
```
