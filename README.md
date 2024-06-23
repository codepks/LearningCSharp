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
	
## Implicit and Dynamic variables

**var** : <br> It is designed to handle some special-case situations like LINQ(Language-Integrated Query). <br>

**dynamic** : <br>
	- You can get the actual type of the dynamic variable at runtime by using GetType() method
 	- The dynamic type changes its type at the run time based on the value present on the right-hand side.
  	- It can also be used to pass the dynamic parameters

```
public static void addstr(dynamic s1, dynamic s2) 
    { 
        Console.WriteLine(s1 + s2); 
    } 
  
    // Main method 
    static public void Main() 
    { 
  
        // Calling addstr method 
        addstr("G", "G"); 
        addstr("Geeks", "forGeeks"); 
        addstr("Cat", "Dog"); 
        addstr("Hello", 1232); 
        addstr(12, 30); 
    } 
```
 
## Binary Literal and Digit separators
C# 7.0 onwards some changes were made in repesenting the variable literal <br>
1. Binary literals : used as '0b' to represetn the binary literals. Often used in bit masking
```
	// Creating binary literals  
	// by prefixing with 0b 
	var num1 = 0b1001; 
	var num2 = 0b01000011; 
```

2. Digit Separators : TO simplify the long numerical digits
```
	// Without Using digit separators 
	long x = 100000022200000202; 
	long z = 10000000020; 
	
	Console.WriteLine("X: {0}", x); 
	Console.WriteLine("Z: {0}", z); 
	
	// Using digit separators 
	long num1 = 1_00_10_00_00_00; 
	var num2 = 0b_010_000_000_000_000_000_000_000_000; 
	long num3 = 1_00_00_00_00_00_00; 
	var num4 = 0b_1_1000_0000_1000_0000_0011_0000_0000_1000_0001; 
	
	Console.WriteLine("Num1: {0}", num1); 
	Console.WriteLine("Num2: {0}", num2); 
```
ura
# Acess Modifiers
There are 4 access modifiers (public, protected, internal, private)
<br>
**Assembly** Means namespace. <br>

1. **internal** : We can acess this within current assembly only. It is a **default access modifier**
2. **protected internal** : Acess is given to the current assembly or namespace and that too in the derived classes only

## Boxing Unboxing

### Boxing
1. Boxing converts a Value Type variable into a Reference Type variable, and Unboxing achieves the vice-versa.
2. **Value** Type variables are always stored in **Stack memory**, while **Reference** Type variables are stored in **Heap memory**.
```
int num = 23; // 23 will assigned to num
Object Obj = num; // Boxing
```
### Unboxing
1. Create a Value Type integer i to unbox the value from obj.
2. This is done using the casting method, in which we explicitly specify that obj must be cast as an int value.
3. Thus, the Reference Type variable residing in the heap memory is copied to stack 

Why do we need it: <br>
For example, the old collection type ArrayList only eats objects. That is, it only stores references to somethings that live somewhere. Without boxing you cannot put an int into such a collection. But with boxing, you can.

## Params
For multiple arguments just like **variadic templates inc ++** we use params. <br>
But only one parameter is allowed in this case.


```
namespace Examples { 
	
class Geeks { 
	
	// function containing params parameters 
	public static int Add(params int[] ListNumbers) 
	{ 
		int total = 0; 
		
		// foreach loop 
		foreach(int i in ListNumbers) 		{ 
			total += i; 
		} 
		return total; 
	} 
		
	// Driver Code	 
	static void Main(string[] args) 
	{ 	
		int y = Add(12,13,10,15,56); 	
		// Displaying result 
		Console.WriteLine(y); 
	} 
	} 
} 

```

## Type Casting
### Downcasting - implicit
For converting like int to float, the conversions are implicit and no keyword is required. Eg. 
- int to float
- float ot double

  ### Upcasting - explcit
  We need to use keywords to make this lossy conversion possible. E.g.
  - float to int (ToInt32)
  - double to float (ToDouble)


## Properties
Properties can be used as if they are public data members, but they are actually special methods called accessors<br>
```
class Geeks {

// Declare roll_no field
private int roll_no;

// Declare roll_no property
public int Roll_no
 { 

   get 
     {
         return roll_no;
      }

   set 
     {
         roll_no = value;
      }
}
}
```

Note: 
1. we can’t use accessor modifiers on an interface

## Nullable types
1. From c# 2.0 we can provide null values to only **Value type** and not Reference type
2. from c# 8.0 onwards we can explicitly define if a **Feference type** can or cannot hold a value

```
int? j = null;
Nullable<int> j = null;

```

Usage:
The main use of nullable type is in database applications. Suppose, in a table a column required null values, then you can use nullable type to enter null values.

## Structures
It comes under value type.

# Keywords
## is keyword
It checks if the object is of the same type as the type it is checked against.

```
public class G1 { }
 
public class G2 : G1 { }
 
public class G3 { }

G1 obj1 = new G1(); 
         
G2 obj2 = new G2(); 
 
Console.WriteLine(obj1 is G1); //shows as true
 
Console.WriteLine(obj1 is Object); //shows as true

Console.WriteLine(obj2 is G1); //shows as true

Console.WriteLine(obj1 is G3); //shows as false
```

## as operator
**as** operator returns object when type and operator are compatible else it returns null.
```
expression is type ? (type)expression : (type)null
```

In the example below **as** sometimes comes as null and sometime not based on compatibility
```
object[] obj = new object[5];
        obj[0] = new Geeks1();
        obj[1] = new Geeks2();
        obj[2] = "C#";
        obj[3] = 334.5;
        obj[4] = null;
 
        for (int j = 0; j < obj.Length; ++j) {
 
            // using as operator
            string str = obj[j] as string;
 
            Console.Write("{0}:", j);
 
            // checking for the result
            if (str != null) {
                Console.WriteLine("'" + str + "'");
            }
            else {
                Console.WriteLine("Is is not a string");
            }
        }
```

**is** operator returns boolean whereas **as** operator returns type itself

## Static keyword

### static classes
static classes 
1. can only contain static members
2. static constructor
3. not allowed to create objects
4. they are **sealed**, hence cannot be inherited

```
static class Tutorial {
 
    // Static data members of Tutorial
    public static string Topic = "Static class";
}
 
// Driver Class
public class GFG {
 
    // Main Method
    static public void Main()
    {
 
        // Accessing the static data members of Tutorial
        Console.WriteLine("Topic name is : {0} ", Tutorial.Topic);
    }
```

### static variable
When a static member variable is created then same copy of the member variable is updated across all the objects.

### static members
1. Called without creatiing any objects
2. It can access all the static and non-static members of the class

### static constructor
It is invoked **only once** that too before the instance contructor.

```
class G1 {
 
    // It is invoked before the first
    // instance constructor is run.
    static G1()    {
        Console.WriteLine("Example of Static Constructor");
    }
 
    public G1(int j)    {
        Console.WriteLine("Instance Constructor " + j);
    }
 
    public string g1_detail(string name, string branch)    {
        return "Name: " + name + " Branch: " + branch;
    }
 
    public static void Main()    {
 
        G1 obj = new G1(1); //static constructor is called here only as it runs once for the first instance
        Console.WriteLine(obj.g1_detail("Sunil", "CSE"));
        G1 ob = new G1(2);
        Console.WriteLine(ob.g1_detail("Sweta", "ECE"));
    }
```

Note : In C#, if static keyword is used with the class, then the static class always contain static members.

## typeof keyword
It is used to get the type of the object

## readonly and const keyword
1. const keyword value is same throughout
2. readonly variable is assigned only when declaring or in the constructor of the same class

```
class GFG {
 
    // readonly variables
    public readonly int myvar1;
    public readonly int myvar2;
 
    // Values of the readonly 
    // variables are assigned
    // Using constructor
    public GFG(int b, int c)
    {
 
        myvar1 = b;
        myvar2 = c;
        Console.WriteLine("Display value of myvar1 {0}, "+
                        "and myvar2 {1}", myvar1, myvar2);
    }
}
```

## ref keyword

1. For value type, we can use ref to pass the value type as a reference
```
subtractValue(ref b);
public static void subtractValue(ref int b)
{
	b -= 5;
}
```

2. For reference type
not required generally

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
# IEnumerable
1. IEnumerable in C# is an interface that defines one method: GetEnumerator(), which returns an IEnumerator object.
2. This interface is found in the System.Collections namespace and is a key part of the .NET Framework.
3. It allows you to iterate over a collection of objects using constructs like foreach loops12.
4. When you implement IEnumerable<T>, you can use it to create LINQ queries or leverage the yield keyword (for C# only) to build efficient iterators

# Yield
The yield keyword in C# allows you to create custom iterators for your code. When you encounter yield in a method or operator, it signals the C# compiler to generate code for a custom iterator. Here’s how it works: <br>

`yield return` : Use this form to provide the next value in an iteration. For example:

```
IEnumerable<int> ProduceEvenNumbers(int upto)
{
    for (int i = 0; i <= upto; i += 2)
    {
        yield return i;
    }
}
// Output: 0 2 4 6 8
```

# ObservableCollections <T>
It is collection dynamic data which provides notification when items get added/removed/refreshed.

[source](https://www.youtube.com/watch?v=ISwIiOmgMCc&ab_channel=SubhamoyBurman)

```
using System;
using System.Collections.ObjectModel;

namespace HarryPotterBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the Harry Potter book names
            ObservableCollection<string> harryPotterBooks = new ObservableCollection<string>
            {
                "Harry Potter and the Philosopher's Stone",
                "Harry Potter and the Chamber of Secrets",
            };

            // Subscribe to CollectionChanged event
            harryPotterBooks.CollectionChanged += (sender, e) =>
            {
                if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
                {
                    Console.WriteLine("The collection changed (book added).");
                }
                else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
                {
                    Console.WriteLine("The collection changed (book removed).");
                }
            };

            // Add a book
            harryPotterBooks.Add("New Book");

            // Remove a book
            harryPotterBooks.Remove("Harry Potter and the Philosopher's Stone");
        }
    }
}

```
