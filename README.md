
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

## if else
Same as C++

## Switch Statement
Except for the not allowing fallthrough for empty case body

## Loops
foreach is something different
```
  foreach (int num in numbers)  
        {  
            if (num > maxSoFar)  
            {  
                maxSoFar = num;  
            }  
        }
```

## Throw
```
  static void displaysubject(string sub1)
    {
        if (sub1  == null)
            throw new NullReferenceException("Exception Message");
             
    }
```

In order to throw invalid object, make a class and derive it from Exception class..

# Class
1. A class can inherit from multiple interfaces

## Nested Class
1. It can access the public, static and private members of the outer class
```
namespace NestedClass
{
    public class Person
    {
        public string name = string.Empty;     
        private int rollNo;
        protected string className = string.Empty;

        public Person(string name, int rollno, string classname) { 
            this.name = name;
            this.rollNo = rollno;
            this.className = classname;
        }

        public class Student
        {
            public string name = string.Empty;
            public int rollNo = 0;          

            public Student() { }

            public int getPersonRoll( Person person)            {
                return person.rollNo;
            }
        }
    }


    public class MainClass
    {
        static void Main(string[] args)
        {
            Person personObj = new Person("prashant", 2, "Xa");
            Person.Student studentObj = new Person.Student();
            Console.WriteLine(studentObj.getPersonRoll(personObj));
        }
    }
}
````
In the example above the child class is able to access the private members of the parent class

## Cracking Sealed Singleton class with Friend Function
```
using System;

namespace NestedClass
{
    public sealed class Singleton
    {
        private static Singleton? instance; // The single instance

        private Singleton() // Private constructor
        {
            // Initialization logic (if needed)
            counter++;
        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton(); // Lazy initialization
            }
            return instance;
        }

        public static int counter = 0;

        public class ChildSingleton
        {
            public Singleton? getSingletonObject()
            {
                Singleton.instance = new Singleton();
                return instance;
            }
        }
    }

    class InheritChild : Singleton.ChildSingleton
    {
        public void MakemulutipleInstance()
        {
            getSingletonObject();
        }
    }

    public class MainClass
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.GetInstance();
            Console.WriteLine($"counter is : {Singleton.counter}");

            Singleton singleton2 = Singleton.GetInstance();
            Console.WriteLine($"counter is : {Singleton.counter}");

            Singleton.ChildSingleton childSingleton = new Singleton.ChildSingleton();   

            childSingleton.getSingletonObject();
            Console.WriteLine($"counter is : {Singleton.counter}");

            InheritChild inheritChild = new InheritChild();
            inheritChild.getSingletonObject();
            Console.WriteLine($"counter is : {Singleton.counter}");

        }
    }
}
```

## Early and Late Binding
1. Early binding is when you try to call the class method and you know which class the method blongs to
2. Late binding is when you call the class method which is virtual class and you do not know if that would be called or not

```
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The cat meows");
    }
}
```

## Constructor Overloading
Parametric Constructor having different types and number

## Inheritance
Multiple inheritance is not allowed in C#, only mulitple interface inheritance is allowed.

## Abstract Classes
1. Abstract classes may or may not contain function definitions.
2. The one not containing the function definitions are tagged as `abstract` 
3. Abstract classes are only meant for inheritance, so you cannot create their objects

```
abstract class Shape {
 
    // abstract method
    public abstract int area();
}
```

## Static Class
In Static classes :
1. It contains only Static members
2. It contains only Static methods
3. You cannot make objects of it

```
static class Author {
 
    // Static data members of Author
    public static string A_name = "Ankita";
    public static string L_name = "CSharp";
    public static int T_no = 84;
 
    // Static method of Author
    public static void details()
    {
        Console.WriteLine("The details of Author is:");
    }
}
 
// Driver Class
public class GFG {
 
    // Main Method
    static public void Main()
    {
 
        // Calling static method of Author
        Author.details();
 
        // Accessing the static data members of Author
        Console.WriteLine("Author name : {0} ", Author.A_name);
        Console.WriteLine("Language : {0} ", Author.L_name);        
    }
}
```

## Partial Classes
1. It is used when you want to chop the functionalities of the class into multiple files
2. It needs to be under same namespace
3. It should have the same accessibility as public, private or protected
4. If any part is declared as sealed or abstract then it means for the class overall

Geeks1.cs
```
public partial class Geeks {
	private string Author_name;
	private int Total_articles;

	public Geeks(string a, int t)
	{
		this.Authour_name = a;
		this.Total_articles = t;
	}
}
```

Another partial class having just one method in it
Geek2.cs 
```
public partial class Geeks {
	public void Display() 
	{
		Console.WriteLine("Author's name is : " + Author_name);
		Console.WriteLine("Total number articles is : " + Total_articles);
	}
}
```

## Shallow and Deep Copy - Different from C++
If we code like this, then both object1 and object2 will point to the same address:
```
 Company c1 = new Company(548, "GeeksforGeeks",
                             "Sandeep Jain");
 // Performing Deep copy							 
 Company c2 = c1;
```

In the above case, in both the objects C1 and C2 you will have value type and reference referencing same address

### Avoiding Value type copy
Shallow Copy
```
 class Company
 {
     public int GBRank;
     public CompanyDescription desc;

     public Company(int gbRank, string c, string o)
     {
         this.GBRank = gbRank;
         desc = new CompanyDescription(c, o);
     }

     // method for cloning object 
     public object Shallowcopy()  {
         return this.MemberwiseClone();
     }
}

Main()
{
	 Company c2 = (Company)c1.Shallowcopy();  
}
```
Here, it is called shallow copy because value type can be unaffected but reference type is still unaffected

### Deep Copy
1. For making reference type too as unaffected we need to perform deep copy
2. Here you create can call the method to create a different object itself
```
class Company { 
      
    public int GBRank; 
    public CompanyDescription desc; 
  
    public Company(int gbRank, string c,  string o)  { 
        this.GBRank = gbRank; 
        desc = new CompanyDescription(c, o); 
    } 
      
    // returning a different object itself
    public Company DeepCopy()  { 
        Company deepcopyCompany = new Company(this.GBRank, desc.CompanyName, desc.Owner);                              
        return deepcopyCompany; 
    } 
}
```

## Creating array of objects
```
Circle[] circleArray = new Circle[2];
 
// Initialize the objects
circleArray[0] = new Circle();
circleArray[1] = new Circle();
```

## Initialization of Objects
List initialization
```
class Geeks
{
    public int val;
    public string author_name { get; set; }
    public int author_id { get; set; }
    public int total_article { get; set; }
}

class GFG
{

    // Main method
    static public void Main()
    {

        // Initialize fields using 
        // an object initializer
        Geeks obj = new Geeks()
        {
            val = 1,
            author_name = "Ankita Saini",
            author_id = 102,
            total_article = 178
        };
       
    }
}
```

## Object list creation
```
var author1 = new Geeks() { author_name = "Soniya", author_id = 103, total_article = 120 };
var author2 = new Geeks() { author_name = "Siya", author_id = 106, total_article = 90 };
var author3 = new Geeks() { author_name = "Arpita", author_id = 111, total_article = 130 };

List<Geeks> author = new List<Geeks>() { author1, author2, author3 };
```

# Methods
## Method Parameters
### Named Parameters
Names can be used againts the arguments and arguments can be in any order
```
public class GFG { 
  
    // addstr contain three parameters 
    public static void addstr(string s1, string s2, string s3) 
    { 
        string result = s1 + s2 + s3; 
        Console.WriteLine("Final string is: " + result); 
    } 
  
    // Main Method 
    static public void Main() 
    { 
        // calling the static method with named  
        // parameters without any order 
        addstr(s1: "Geeks", s2: "for", s3: "Geeks"); 
                     
    } 
} 
```

### Ref Parameters
It is for passing the value type variables by reference
```
// C# program to illustrate the 
// concept of ref parameter 
using System; 

class GFG { 

	public static void Main() { 
		string val = "Dog"; 
		CompareValue(ref val); 
		Console.WriteLine(val); 
	} 

	static void CompareValue(ref string val1) { 
		if (val1 == "Dog") { 
			Console.WriteLine("Matched!"); 
		} 
		val1 = "Cat"; 
	} 
} 

```

### Out Parameter
```
class GFG { 
	static public void Main() { 
		int num; 
		AddNum(out num); 
		Console.WriteLine("The sum of"	+ " the value is: {0}",num); 					
	} 

	public static void AddNum(out int num) 	{ 
		num = 40; 
		num += num; 
	} 
} 

```
It is just like `ref` parameter but ref parameter needs to be initialized before being passed as an argument


### Dynamic Parameters
1. `var` variables are deduced at the compile time whereas `dynamic` variables are deduced at run time.
2. `var` type needs to be initialized at the time of declaration whereas it is not true for `dynamic` type
3. For `var` variable, once type one deduced it cannot be reassigned to different type whereas dynamic type it can be reassigned to different type

Here the compiler will throw an error because the compiler has already decided the type of the myvalue variable using statement 1 that is an integer type
```
var myvalue = 10; // statement 1
myvalue = “GeeksforGeeks”; // statement 2
```

Here, the compiler will not throw an error though the type of the myvalue is an integer
```
dynamic myvalue = 10; // statement 1
myvalue = “GeeksforGeeks”; // statement 2
```

Note : **We can also use it as function parameters**
<br> C# 7  onwards one can use var parameters too in function parameters

### Params Keyword
In order to pass multiple variables of the **same type** one can use `params` keyword
```
// C# program to illustrate params 
using System; 
namespace Examples { 

class Geeks { 
	public static int mulval(params int[] num) 	{ 
		int res = 1; 
		foreach(int j in num) 		{ 
			res *= j; 
		} 
		return res; 
	} 

	static void Main(string[] args) 	{ 
		int x = mulval(20, 49, 56, 69, 78); 
		Console.WriteLine(x); 
	} 
   } 
} 
```

Sending optional/default parameters using params keyword
```
 static public void my_mul(int a, params int[] a1)     { 
        int mul = 1; 
        foreach(int num in a1)         { 
            mul *= num; 
        } 
        Console.WriteLine(mul * a); 
    } 
  
    // Main method 
    static public void Main()     { 
        my_mul(1); 
        my_mul(2, 4); 
        my_mul(3, 3, 100); 
    }

 static public void my_mul(int a, params int[] a1)     { 
        int mul = 1; 
        foreach(int num in a1)         { 
            mul *= num; 
        } 
        Console.WriteLine(mul * a); 
    } 
  
    // Main method 
    static public void Main()     { 
        my_mul(1); 
        my_mul(2, 4); 
        my_mul(3, 3, 100); 
    }
```

## in paramets
1. It does not allow changing of the input value but ref allow
2. It is like `const& int varName`


## Method Overriding
### Virtual function overriding
Same as C++

### Base keyword
We can call the parent class function in the derived class function using `base` keyword
```
public class web {
    string name = "GeeksForGeeks";
    public virtual void showdata()    {
        Console.WriteLine("Website Name: " + name);
    }
}

class stream : web {
    string s = "Computer Science";
    public override void showdata()    {
        base.showdata();
	Console.WriteLine("About: " + s);
    }
}
```

### Instantiating Base class constructor in derived class
public class DerivedClass : clssA
{
    public DerivedClass() : base() { }
    public DerivedClass(int i, int j) : base(i, j) { }
}



## Hidden Methods
1. If the parent class and the base class have the same name functions then the derived class function might shadow the base class function and warning would be generated
2. To avoid the warning we use `new` keyword in the derived class function name
```
public class My_Family { 
  
    public void member() 
    { 
        Console.WriteLine("Total number of family members: 3"); 
    } 
} 
  
// Derived Class 
public class My_Member : My_Family { 
  
    // Reimplement the method of the base class 
    // Using new keyword 
    // It hides the method of the base class 
    public new void member()  
    { 
        Console.WriteLine("Name: Rakesh, Age: 40 \nName: Somya, "+ 
                               "Age: 39 \nName: Rohan, Age: 20 "); 
    } 
}
```
Now the base class function is hidden from the derived class without any warning.

### calling base class function casting way
```
public class My_Family { 
	public void member() 	{ 
		Console.WriteLine("Total number of family members: 2"); 
	} 
} 

// Derived Class 
public class My_Member : My_Family { 
	
	public new void member() { 

		Console.WriteLine("Name: Rakesh, Age: 40 "+ "\nName: Somya, Age: 39"); 
	} 
} 

class GFG { 
	static public void Main() { 

		My_Member obj = new My_Member(); 
		((My_Family)obj).member(); 
	} 
} 
```

## Anonymous Methods
1. C# has related anonymous methods(lambdas) and delegates
2. Just like you associate a function with a delegate and later call the delegate with the parameters to invoke the function
3. ...In a similar way you can create a **disposeable** function using using keyword `delegate` and associate that disposable function to your delegate of the same signature

```
// C# program to illustrate how to 
// create an anonymous function 
using System; 

class GFG { 
public delegate void petanim(string pet); 
static public void Main() 
{ 

	// An anonymous method with one parameter 
	petanim p = delegate(string mypet) 
	{ 
		Console.WriteLine("My favorite pet is: {0}", mypet); 
	}; 
	p("Dog"); 
} 
} 
```
In the code above we created a delegate `petanim` and later associated it with a disposable function `delegate(string mypet)` and later triggered that delegate. <br>

They can also access the outer variables without any issue. <br>

You can even pass this anonymous function to a function with a delegate parameter which can be invoked later.

```
namespace AnonmymousDelegate
{
    public delegate void printName(string name);
    class Anonymous
    {
        public static void PrintNameFunction(printName pt)  {
            pt("Something");
        }

        static void Main()
        {
            printName p = delegate (string name)  {
                Console.WriteLine(name);
            };
	    //Invoking the function via delegate object
            p("Hello World");

	    //Passing the lambda function to the function to be lated invoked by delegate
            PrintNameFunction(delegate (string name)
            {
                Console.WriteLine(name);
            });

        }
    }
}
```
Note:
1. An anonymous method does not access in, ref, and out parameter of the outer scope.
2. Just like you can subscrbe a normal function to an event, similar can be done in case of anonymous function
```
MyButton.Click += delegate(Object obj, EventArgs ev) 
{ 
    System.Windows.Forms.MessageBox.Show("Complete without error...!!"); 
} 
```
 
## Partial Methods
1. Declaration and defition can be in separate classes too due to partial classes
2. We use `partial` keyword at one place and do declaration and another `partial` to do te defintion
Class11.cs
```
public partial class Circle { 
   partial void area(int p);
```
Class12.cs
```
public partial class Circle { 
	partial void area(int r) { 
		Console.WriteLine("Area is : {0}", A); 
	} 
} 
```

## Extension Methods
We can extend functionality of a class by making a `static` class and mentioning `this <className> <param name>` in the paremter list at first position <br>
This works even for `sealed` classes
```

namespace ExtensionMethods
{
    public class Geeeks
    {
        public void someFunction1() {
            Console.WriteLine("Hello 1");
        }

        public void someFunction2() {
            Console.WriteLine("Hello 2");
        }
    }

    public static class ExtendedGeeks {
        public static void someFunction3(this Geeeks geeeks) {
            Console.WriteLine("Hello 3");
        }
    }


    class ExtendedGeeksTest {
        static void Main(string[] args) {
            Geeeks g = new Geeeks();
            g.someFunction1();
            g.someFunction2();
            g.someFunction3();
        }
    }
}
```

## Local Function
1. It is like a normal function within a function but does not have a access modifier
2. It is like a proper lambda function with all the function bodies and parameters
3. It can use `generics`
4. It can use `ref/out` parameters
5. It can use `params` too

```
public class Program {
	public static void Main()
	{
		int x = 40;
		int y = 60;

		// Local Function
		void AddValue(int a, int b) {
			Console.WriteLine("Value of a is: " + a);
		}
		AddValue(79, 70);
	}
}
```

# Delegates
Anonymous Methods(C# 2.0) and Lambda expressions(C# 3.0) are compiled to delegate types in certain contexts. Sometimes, these features together are known as anonymous functions.

```
public delegate void someDelegate(string name);
```
1. When you declare thsi line then internally define the parameteric constructor which take only string paramter
2. Thereby, when you make an object of `someDelegate` you need to to inialize the object by passing 

```
namespace ExtensionMethods
{
    public delegate void someDelegate(string name);
    
    public class Geeks
    {
        public void someFunction(string myName)  {
            Console.WriteLine(myName);
        }

        public void someMethod(someDelegate myName)   {
            myName("Hello from the other side");
        }
    }

    class GeeksTest {
        static void Main(string[] args)   {
            Geeks obj = new Geeks();
            someDelegate someDel = new someDelegate(obj.someFunction);
            someDel("Hello World"); //invoking via delegate inside main function

            obj.someMethod(someDel); //invoking via delegate in some other function
        }
    }
}
```

## Multicast Delegates
It is used to add more subscription of the functions to the delegates
```
namespace ExtensionMethods
{
    public delegate void someDelegate(string name);
    public class Geeks
    {
        public void someFunction(string myName) {
            Console.WriteLine(myName);
        }

        public void someFunction2(string myName)  {
            Console.WriteLine(myName);
        }

        public void someMethod(someDelegate myName)  {
            myName("Hello from the other side");
        }
    }

    class GeeksTest {
        static void Main(string[] args) {
            Geeks obj = new Geeks();
            someDelegate someDel = new someDelegate(obj.someFunction); //doing object initialization
	    someDelegate someDel = obj.someFunction; //other way of doing the same as above
            someDel += obj.someFunction2;

            someDel("Hello World"); //call some1 and some2

            obj.someMethod(someDel); //this also calls some1 and some2
        }
    }
}
```

## Predicate Delegate

1. Predicate delega works for `boolean` return kind of function which has only **one input parameter**
'''
 public class Geeks
 {
     public bool someFunction3(string someStr) {
         Console.WriteLine(someStr);
         return true;
     }
 }



 class GeeksTest {
     static void Main(string[] args) 
     {
         Geeks geeks = new Geeks();

         Predicate<string> predicate = geeks.someFunction3;
         predicate("Hello");

         Predicate<string>  predicate1 = (x) => { Console.WriteLine(x); return true; };
         predicate1("Hello 2");
     }
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
