# My-Portfolio
Portfolio website

MVC concepts

***Action Filters An action filter is an attribute that you can apply to a controller action or an entire controller that modifies the way in which the action is executed. The ASP.NET MVC framework includes several action filters − OutputCache − Caches the output of a controller action for a specified amount of time. HandleError − Handles errors raised when a controller action is executed. Authorize − Enables you to restrict access to a particular user or role.

Types of Filters The ASP.NET MVC framework supports four different types of filters − Authorization Filters − Implements the IAuthorizationFilter attribute. Action Filters − Implements the IActionFilter attribute. Result Filters − Implements the IResultFilter attribute. Exception Filters − Implements the IExceptionFilter attribute.

Filters are executed in the order listed above. For example, authorization filters are always executed before action filters and exception filters are always executed after every other type of filter. Authorization filters are used to implement authentication and authorization for controller actions. For example, the Authorize filter is an example of an Authorization filter.

***COLLECTIONS A collection is a set of similar types of objects that are grouped together. System.Collections namespace contains specialized classes for storing and accessing the data. Each collection class defined in .NET has a unique feature.

Types of collections:

Arrays: Array class is defined in System namespace. Arrays can store any type of data but only one type at a time. The size of the array has to be specified at compilation time. Insertion and deletion reduce performance. Advanced Collections Many times we can’t give number elements in the list and we need to perform different operations like inserting, deleting, sorting, searching, comparing, and so on. To perform these operations efficiently, the data needs to be organized in a specific way. This gives rise to advanced collections. Advanced collections are found in System.Collections namespace. Advanced collections are again divided into two types-

Non-generic collections: Every element in the non-generic collection is stored as a System.Object type Examples-- ArrayList, Stack, Queue, HashTable, and so on. Boxing

Conversion of value type to a reference type is known as boxing. When the value is boxed, CLR allocates a new object on the heap and copies the value of the value type into that instance. CLR returns a reference of newly created objects. This is essentially an upcast as all types are derived from System.Object class. Developers need not use wrapper classes or structures for value types to perform the conversion.

Example-- int speed =80 Object obj= speed; Unboxing

It is an opposite operation of boxing, that is copied from a reference type to a value type on the stack. Explicit casting is required as it is downcast. It is the conversion of a derived type to a base type.

Example-- int speed =80 Object obj= speed // boxing int speed=(int) obj // unboxing Generic collections

These are defined in System.Collections.Generic namespace.

Examples-- Generic list, generic queue, and so on. They are template-based versions of their counterparts. Generics help to define generic functions or classes which avoid repetition of code for different data types. Generic collections are very useful when implementing generic constructs like searching, sorting, stacks, queues, lists, vectors, and so on. These constructs have a generic algorithm that can be implemented for any data type.

***HTTPGET HttpGet method sends data using a query string. The data is attached to URL and it is visible to all the users. However, it is not secure but it is fast and quick. It is mostly used when you are not posting any sensitive data to the server like username, password, credit card info etc.

Some Fact about HttpGet Method It is fast and quick but not secure. It is default method. Because it attached form data in query string, so the data is visible to other users. It uses stack method for passing form variable. Data is limited to max length of query string. It is very useful when data is not sensitive. It creates URL that is easily readable. It can carry only text data.

==HTTPPOST HTTPPost method hides information from URL and does not bind data to URL. It is more secure than HttpGet method but it is slower than HttpGet. It is only useful when you are passing sensitive information to the server.

Some Fact about HttpPost Method Data is sent via HttpPost method, is not visible to user. It is more secured but slower than HttpGet. It uses Heap method for passing form variable. It has no restriction of passing data and can post unlimited form variables. It is used when sending critical data. It can carry both text and binary data.

***HttpPut Same as Post, but normally used for updating an existing resource. ***HttpDelete Delete an existing resource. ***HttpPatch Used for partial update ***HttpHead Same as HttpGET, except server do not return body message.
