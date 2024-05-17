# C-Sharp-Fundamental

### Development Workflow Setup

#### Visual Studio Code

- **light-weight** and **Editor based** experience.
- **Extension/add-on** driven customization and tooling.
- **Cross platform**.
- **Open Source**.

#### Visual Studio

- Integrated Development Environment (IDE).
- More **out-of-the-box** customization and tooling.
- **Windows focused**.
- Available in different editions with different licensing models.
    - **Community** edition: free.
    - **Professional**:paid.
    - **Enterprise**: paid and additional features.
[More about editions](https://visualstudio.microsoft.com/vs/compare/)

#### Visual Studio for Mac.

### Syntax
C# syntax is inspired from C and C++ languages.

Let's walkthrough the syntax using the following program.


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

### using Statement
- **using** block can be used on the objects or instances of the classes which inherits from **IDisposable** class and implements **Dispose** method.
- **using** block does ensure that the object's **Dispose** method will always be invoked, no matter if an exception is thrown or not.
- **Dispose** is a method used to clean up resources. In the case of a DB connection, the connection is released or closed, which is important.

***Note: The equivalent of **using** is a **try finally**, which includes a call to **Dispose** within the **finally** block.***

```
namespace CsharpFundamentals
{
    public class MyDisposableClass : IDisposable
    {
        public void Dispose()
        {
            //Clean up any unmanagable resources of MyDisposableClass
        }
    }

    public class DisposeDemo
    {
        public void UsingStatementDemoRun()
        {
            using (MyDisposableClass myDisposableClassObjectInstance = new())
            {
                // Implement logic
            }// using statement ensures to invoke Dispose method of  MyDisposableClass,
             // even if an exception is thrown.  
        }

        public void TryCatchFinallyDemoRun()
        {
            MyDisposableClass myDisposableClassObjectInstance = new();
            try
            {
                // Implement logic
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                myDisposableClassObjectInstance.Dispose();
            }
        }
    }
}
```

Example:

```
namespace CsharpFundamentals
{
    public class SqlConnectionDisposeDemo
    {
        public void UsingStatementDemoRun()
        {
            using (Microsoft.Data.SqlClient.SqlConnection connection = new())
            {
                connection.ConnectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=DisposeDemo;Integrated Security=True;Encrypt=False;Trusted_Connection=True;";
                connection.Open();
            }// using statement ensures to invoke Dispose method of SqlConnection,
             // which internally invokes Close() method of SqlConnection object,
             // even if an exception is thrown.  
        }

        public void TryCatchFinallyDemoRun()
        {
            Microsoft.Data.SqlClient.SqlConnection connection = new();
            try
            {
                // Implement logic
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    //connection.Dispose();
                }
            }
        }
    }
}
```


### Other Resources

- [ADO.NET - Data Access API](/ado-net.md)
