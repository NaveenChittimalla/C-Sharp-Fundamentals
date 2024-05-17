## ADO.NET - Data Access API

**ADO.NET** is a data access api in .NET platform, to interact with different data sources such as databases (SQL SERVER, ORACLE etc.,) ,XML, Microsoft Access, and other in a standard, and structured approach.

**ADO.NET** has two main components for accessing and manipulating data.
- .NET Data Provider.
- Dataset

### .NET Data Providers
**.NET Data Provider** provides the classes to connect to a database, to store the data to a database, and to retrieve the data from a database.
- SqlConnection class
- SqlCommand class
- SqlDataReader class
- SqlAdapter class

### Dataset 
**Dataset** contains one or more data tables that store the data retrieved from the database in application memory on the server disk and the database connection is closed. Then, the application can manipulate or transform the in-memory data in the data tables. This is referred to as a **disconnected** data architecture. More about this in the coming sections.

![ADO.NET Architecture](/docs/assets/images/ADO-NET-Architecture.png)