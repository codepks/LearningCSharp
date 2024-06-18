 Starting (entry) point of a console application is Main
 
 float weight = 80.5f;

 // char is used for storing a single symbol
 // single quotes ('')
 char firstLetter = 'K';

 `var` and `auto` are similar

printing is done lie `Console.WriteLine(sumMoreDecimal);`

# Overview
.NET has two components:
1. CLR : For managing execution of the code
2. Libraries : For providing set of in-build functionalities for development
3. Managed code enviroment provides assistance like :
	- like garbage collection
 	- type checking
 	- exception handling
 	- bounds checking
 	- The source code is compiled to Intermediate lang. in form of .exe or ..dll which is taken care later by JIT for running in different platforms(only need to install CLR) where as in unmanaged code it is directly compiled to native code
4. Process of compilation:
	- Code -> MSIL language(intermediate lang.) -> Creates .exe
 	- Launch .exe -> JIT compiles the intermediate lang. to native code for the hardware architecture
5. Unmanaged Code :
	- Code which is directly executed by OS like C++
 	- To get the exe for different OS you need to recompile into the architecture e.g. C++ needs to be compiled separately in Windows and Linux and separate executables are made
  	- Memory managed needs to be done by the developer
	
# Logical Flow

## Switch Statement
1. In C#, the switch expression can be of integral types, enumerated types, **strings**, or nullable types.
2. The **fall through** is not automatic thus break is optional

# Fundamentals
1. Variables are known as identifiers
2. Data types and alias - value type
	- sbyte	System.Sbyte
	- short	System.Int16
	- Int	System.Int32
	- long	System.Int64
	- byte	System.byte
	- ushort System.UInt16
	- uint	System.UInt32
	- ulong	System.UInt64
3. Reference Type
	- String
 	- Object : It is base class for all reference type(predefined or user defined) or value types
		- Value type -> Object type (Boxing)
  		- Object type -> Value type (Unboxing)
4. Unsafe Pointers:
		a. We need to enable unsafe option to run this:
		unsafe
```		
  		{ 
		      
		    // declare variable 
		    int n = 10; 
		      
		    // store variable n address  
		    // location in pointer variable p 
		    int* p = &n; 
		    Console.WriteLine("Value :{0}", n); 
		    Console.WriteLine("Address :{0}", (int)p); 
		} 
```		
	


# String Operations
## Try Parse
```
bool TryParse(string input, out T result);
```
int.TryParse attempts to parse the string "123" into an integer.

Other ways `int.Parse` and `Convert.ToInt32`


## Checking Empty String
```
string.IsNullorEmpty(intputString)
```

Incorrect way
```
if(inputString == "")
```

## String Comparison
```
if(string1.Equals(string2))
```
Incorrect way
```
if(string1==string2)
```

# Loops and Arrays

## Arrays
1. Unlike in C++ where based on declaration variables are allocated value in heap or stack, in C# this is handled by garbage collector.
2. In C++ there is no boundry check where as in C# it returns exception
3. In C++ arrays decays into pointer that's why we need to pass size too whereas this is not a case in C#, the length is carried along.

## Strings
1. In C++, strings are array of characters and its value can be changes for a given index
2. But in C# the strings are immutable i.e the values cannnot be changed, it can only be accessed

### Creation
1. Generally they are initialized using **new** keyword.
2. Althoug we can do it without new keyword too.

With **new** keyword
```
int[] numbers;
numbers = new int[] { 1, 2, 3, 4, 5 };
```

without **new** keyword
```
int[] numbers = { 1, 2, 3, 4, 5 };
```


Default value is **null** so we use **new** keyword with [count] to create array
### Passing arrays

1. Arrays are passed by reference and **primitives** are passed by value.
2. The changes happened in function will persist even after it leaves the function
3. Arrays are not dynamic in nature


```
// Method declaration
int[] CreateArray()
{
    int[] numbers = { 1, 2, 3, 4, 5 };
    return numbers;
}

// Method call
int[] result = CreateArray()
```
Explaination: 
In C#, the numbers array is not destroyed when the CreateArray method returns. This is because arrays in C# are reference types, and when you return an array from a method, you're returning a reference to the array's location in memory, not a copy of the array itself.

<br>

When you call CreateArray() and assign its result to result, result holds a reference to the same array that numbers refers to within the CreateArray method. Therefore, as long as there are references to the array, it remains alive in memory

<br>

## Loops
**For each**
```
foreach(var number in array)
{
  console.writeline(numer);
}
```

# Reference Types and Value Types
Refrence types are 
1. Class Types
```
class MyClass { /* Class definition */ }
MyClass obj = new MyClass();
```
2. Interface Types 
```
interface IMyInterface { /* Interface definition */ }
class MyClass : IMyInterface { /* Class implements IMyInterface */ }
IMyInterface obj = new MyClass();
```
3. Array Types : `int[] numbers = new int[5];`
4. Delegate Types :
```
delegate void MyDelegate(int x);
MyDelegate del = MyMethod;
```
5. String Type
6. Dynamic Type : `dynamic dynObj = GetDynamicObject();`
   

# Files and Errors
## Path using @
1. `@` when used in front a string it makes it a Verbatim
2. It cancels out special symbols

## Files
1. When file is opened for reading and writing, it becomes a stream
2. A stream is a sequence of bytes passing through communication path
3. Unmanaged resources are disposed usign filestream.dispose()
4. 

## Try and Catch
Like in C++ try and catch are used, but here we have **finally** keyword where things withing its braces the statements are executed anyway.
   

# Object Oriented Programming
## Static classes
```
using System;

public static class MathHelper {
    // Static method to add two numbers
    public static int Add(int a, int b)    {
        return a + b;
    }

    // Static method to subtract two numbers
    public static int Subtract(int a, int b)    {
        return a - b;
    }
}

class Program {
    static void Main(string[] args)    {
        // Using static methods of the MathHelper class without creating an instance
        int sum = MathHelper.Add(5, 3);
        int difference = MathHelper.Subtract(8, 2);

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {difference}");
    
}

```

## getter and setter
```
private int _legs;

public int Legs
{
    get { return _legs; }
    set { _legs = value; }
}
```

## Sample Inheritance
```
class Program {
    static void Main()  {
        Bird brd = new Bird("chirai");
        Console.WriteLine(brd.Name);
    }

    class Animal    {
        private string _name { get; set; }

        public string Name  {
            get { return _name; }
            set { _name = value; }
        }
    }

    class Bird : Animal  {
        public Bird(string name)  {
            Name = name;
        }
    }
}
```

## Access specifier inheritancec
In C++ we have 
```
class Bird : public Animal {}
```
We don't have something like public in C# while doing inheritance.

## object keyword
1. **object** is the ultimate base type for all other types in C#
2. any value or reference type can be assigned to a variable of type **object**
3. object is the basis for **boxing and unboxing** in C#
```
int i = 123; // Value type
object obj = i; // Boxing
int j = (int)obj; // Unboxing
```
4. Can be used for **Generics**
```
List<object> objects = new List<object>();
objects.Add("Hello");
objects.Add(123);
objects.Add(new MyClass());
```
5. Type checking : It can be done using **is** or **as** parameter
```
if (obj is string)
{
    Console.WriteLine("Object is a string.");
}
```
6. As a method parameter or return type too
```
if (obj is string)
{
    Console.WriteLine("Object is a string.");
}
```
7. 

# Internal Class

Internal keyword allows you to set internal access specifier. <br>

Internal access specifier allows a class to expose its member variables and member functions to other functions and objects in the current assembly. <br>

Any member with internal access specifier can be accessed from any class or method defined within the application in which the member is defined.  <br>

Use case: <br>
1. Call a class’s private function within the same assembly.
2. In order to test a private function, you can mark it as internal and exposed the dll to the test DLL via InternalsVisibleTo.

```
using System;

namespace RectangleApplication {
   class Rectangle {

      internal double length;
      internal double width;

      double GetArea() {
         return length * width;
      }

      public void Display() {
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
      }
   }

   class Demo {
      static void Main(string[] args) {
         Rectangle rc = new Rectangle();
         rc.length = 10.35;
         rc.width = 8.3;
         rc.Display();
         Console.ReadLine();
      }
   }
}
```



