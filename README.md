
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
	- like garbage collectionf
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

### Casting using as vs explicit casting
1. as will return null if the casting fails - mainly helpful in polymorphism
2. explicit casting with throw `InvalidCastException` error if the casting fails

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
## Importance of Assembly Name
1. Whenver we build a .dll file we provide the important meta data along
2. It consists of Assembly name
3. The next need is of the class or interface name in order to access the object
4. So full path of the object become `AssemblyName.ClassName`


## Implementing interface via Lambda expression

```
object ICloneable.Clone() => Clone(); //This line implements the Clone method from the ICloneable interface
```

Creating shallow copy of current instance
```
public FinePSFConfigItem Clone()
{
    var clone = (FinePSFConfigItem) MemberwiseClone();
    clone.IsSelected = false;
    return clone;
}
```

## Memberwise vs copyfrom

**What is difference between copyfrom and memberwiseclone in the code below:**
```
public class DefectAttributes : DSViewModelBase, IDefectAttributes
   {
        public object Clone() => MemberwiseClone();

        DefectAttributes() : base() { }

        DefectAttributes(IDefectAttributes defectAttributes) : base()
        {
            CopyFrom(defectAttributes);
        }

        private void CopyFrom(IDefectAttributes defectAttributes)
        {
            RToPlanet = defectAttributes.RToPlanet;
            RThetaToPlanet = defectAttributes.RThetaToPlanet;
            AdcRatio = defectAttributes.AdcRatio;
            Ee = defectAttributes.Ee;
            Adc = defectAttributes.Adc;
        }
```

1. MemberwiseClone
Purpose: The MemberwiseClone method creates a shallow copy of the current object. This method is part of the System.Object class and is protected, meaning it can only be called from within the class itself or a derived class.

2. CopyFrom
Purpose: The CopyFrom method is a custom method defined in the DefectAttributes class. It takes an instance of IDefectAttributes (presumably another DefectAttributes instance or a compatible interface) and copies specific values from that instance to the current instance.
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

## Testing Memberwise Clone
1. Here we have create two structure one without the ICloneable interface and one with the ICloneable interface.
2. In the main function we have create a Point list
3. Created another list which is copying frmo the original list but if the original Point list is affected then the Test like alos gets affected
4. If we try to do the above thing with the structure which has ICloneable interface implemented then it wouldn't happen


```
using System;

class Program
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y) { X = x; Y = y; }
    }

    
    class PointClonable : ICloneable
    {
        public PointClonable(int x, int y) { X = x; Y = y; }
        public int X { get; set; }
        public int Y { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    static void Main(string[] args)
    {
        List<Point> points = new List<Point>(   new Point [] { new Point(1, 2), 
                                                new Point(3, 4), 
                                                new Point(5, 6), 
                                                new Point(7, 8) } );

        foreach (Point item in points)
            Console.WriteLine(item.X + " " + item.Y);

        List<Point> TestPointCloning = new List<Point>();

        foreach (Point item in points)
            TestPointCloning.Add((Point)item);

        Console.WriteLine("Before change");
        foreach (Point item in TestPointCloning)
            Console.WriteLine(item.X + " " + item.Y);
        points[0].X = 10;
        points[0].Y = 20;

        //seems to affect the TestList as well
        Console.WriteLine("After change");
        foreach (Point item in TestPointCloning)
            Console.WriteLine(item.X + " " + item.Y);



        Console.WriteLine("Testing Cloning thing");

        List<PointClonable> PointClonables = new List<PointClonable>(new PointClonable[] { new PointClonable(1, 2),
                                                new PointClonable(3, 4),
                                                new PointClonable(5, 6),
                                                new PointClonable(7, 8) });

        foreach (PointClonable item in PointClonables)
            Console.WriteLine(item.X + " " + item.Y);

        List<PointClonable> TestPointClonableCloning = new List<PointClonable>();

        foreach (PointClonable item in PointClonables)
            TestPointClonableCloning.Add((PointClonable)item.Clone());

        Console.WriteLine("Before change");
        foreach (PointClonable item in TestPointClonableCloning)
            Console.WriteLine(item.X + " " + item.Y);
        PointClonables[0].X = 10;
        PointClonables[0].Y = 20;

        //seems to affect the TestList as well
        Console.WriteLine("After change");
        foreach (PointClonable item in TestPointClonableCloning)
            Console.WriteLine(item.X + " " + item.Y);

    }
}
```

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
[source](https://www.wwt.com/article/how-to-clone-objects-in-dotnet-core)

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

## Using ICloneable
- We can do shallow copy and deep copying using ICloneable
- ICloneable's memeberwise clone only does shallow copy and we need to explicitly write logic for deep copy

The interface
```
public interface ICloneable  
{  
    object Clone();  
}
```

Implemenetation for shallow copy
```
public class Person : ICloneable  
{  
    public string Name { get; set; }  
    public int Age { get; set; }  

    public object Clone()  
    {  
        // Return a shallow copy of the current object  
        return this.MemberwiseClone();  
    }  
}
```
Implementation for deep copy
```
public class Person : ICloneable  
{  
    public string Name { get; set; }  
    public int Age { get; set; }  
    public Address Address { get; set; }  

    public object Clone()  
    {  
        Person clonedPerson = (Person)this.MemberwiseClone();  
        clonedPerson.Address = (Address)this.Address.Clone(); // Assuming Address also implements ICloneable  
        return clonedPerson;  
    }  
}  

public class Address : ICloneable  
{  
    public string Street { get; set; }  
    public string City { get; set; }  

    public object Clone() => this.MemberwiseClone();  
}
```
## Serializing 1
What does adding annotattion of "Serializable" to a class do?
	
Doing it makes it possible to convert the structure to a database structure which could be a SQL data structure or XML data structure!

## Deepcopy using Serialization

```
using System;  
using System.IO;  
using System.Runtime.Serialization;  
using System.Runtime.Serialization.Formatters.Binary;  

[Serializable]  
public class Address  
{  
    public string Street { get; set; }  
    public string City { get; set; }  
}  

[Serializable]  
public class Person  
{  
    public string Name { get; set; }  
    public int Age { get; set; }  
    public Address Address { get; set; }  

    // Method to clone the object deeply using serialization  
    public Person DeepClone()  
    {  
        using (MemoryStream memoryStream = new MemoryStream())  
        {  
            // Create a new BinaryFormatter for serialization  
            IFormatter formatter = new BinaryFormatter();  
            
            // Serialize the current object to the MemoryStream  
            formatter.Serialize(memoryStream, this);  
            
            // Reset the stream position to the beginning before deserialization  
            memoryStream.Seek(0, SeekOrigin.Begin);  

            // Deserialize the object from the MemoryStream  
            return (Person)formatter.Deserialize(memoryStream);  
        }  
    }  
}  

class Program  
{  
    static void Main(string[] args)  
    {  
        // Create an instance of Person  
        Person original = new Person  
        {  
            Name = "John Doe",  
            Age = 30,  
            Address = new Address  
            {  
                Street = "123 Main St",  
                City = "Anytown"  
            }  
        };  

        // Clone the original person  
        Person cloned = original.DeepClone();  

        // Modify the clone  
        cloned.Name = "Jane Doe";  
        cloned.Address.Street = "456 Elm St";  

        // Output both objects to demonstrate they are independent  
        Console.WriteLine($"Original: {original.Name}, Age: {original.Age}, Address: {original.Address.Street}, {original.Address.City}");  
        Console.WriteLine($"Cloned: {cloned.Name}, Age: {cloned.Age}, Address: {cloned.Address.Street}, {cloned.Address.City}");  
    }  
}
```

## Serializing 2
```
using Newtonsoft.Json;

public static class ExtensionMethods
{
  public static T DeepCopy<T>(this T self)
  {
    var serialized = JsonConvert.SerializeObject(self);
    return JsonConvert.DeserializeObject<T>(serialized);
  }
}
```
Now to make a clone, call .DeepCopy() on the object. The following example creates a deep copy of an instance of MyObject, and then alters properties on the clone. The original MyObject instance is therefore not mutated.
```
static void Main(string[] args)
{
  var myObj = new MyObject("original", new NestedObjectProp("nestedPropA", "nestedPropB"));
  
  var myObjClone = myObj.DeepCopy();
  
  myObjClone.ObjectProp = "changed objectProp on clone";
  myObjClone.NestedObjectProp.NestedPropB = "changed nestedPropB on clone";
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

## OrderBy
```
people = people.OrderBy(x => x.LastName);
```
```
(parameters) => (expressions)
```

1. `x` represents 1 person
2. the lambda expression takes `x` as an input and converts it into x.LastName and passes it to OrderBy function
 
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

## Enumeratof of List
```
List<int> list = new List<int> { 1, 2, 3, 4, 6 };
List<int>.Enumerator enumerator = list.GetEnumerator(); // <--->

enumerator.MoveNext(); //gets you 1
enumerator.MoveNext(); //gets you 2

Console.WriteLine(enumerator.Current);
```

Enumerator gets you the pointer of the list

## Lambda Expressions
1. They are bit different from C++
2. Mostly operated on lists
```
// List to store numbers
List<int> numbersList = new List<int>() {36, 71, 12, 15, 29, 18, 27, 17, 9, 34};

// Creates a new list
var squareList = numbersList.Select(x => x * x);
var divBy3List = numbersList.FindAll(x => (x % 3) == 0);
```
Output
```
The list : 36 71 12 15 29 18 27 17 9 34 
Squares : 1296 5041 144 225 841 324 729 289 81 1156 
Numbers Divisible by 3 : 36 12 15 18 27 9 
```
**Non list operations**<br>
Using `Func` first param being input and other being output
```
Func<int, int> square = x => x * x;

Func<int, int, int> add = (x, y) => x + y;
```

`Action` : For no return type
```
Action<string> greet = name =>
{
    string greeting = $"Hello {name}!";
    Console.WriteLine(greeting);
};
```
For printing
```
Action<List<Person>> printList = peopleList =>
{
    foreach (var person in peopleList)
        Console.WriteLine($"{person.name} {person.surname} {person.age}");
};
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
It is used to add more subscription of the functions to the delegates.
Functions subscribe to events with out without delegates
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

Predicate delegate works for `boolean` return kind of function which has only **one input parameter**

```
 public class Geeks {
     public bool someFunction3(string someStr) {
         Console.WriteLine(someStr);
         return true;
     }
 }

 class GeeksTest {
     static void Main(string[] args) {
         Geeks geeks = new Geeks();

         Predicate<string> predicate = geeks.someFunction3;
         predicate("Hello");		//this invoke returns a bool which can be utilized

         Predicate<string>  predicate1 = (x) => { Console.WriteLine(x); return true; };
         predicate1("Hello 2");
     }
 }
 ```

## Action Delegate
It is delegate that works for `void` functions (no return type)
```
 public class Geeks
 {
     public static void someFunction4(string someStr)
     {
         Console.WriteLine(someStr);
     }
 }

class GeeksTest {
    static void Main(string[] args) 
    {
        Geeks geeks = new Geeks();
	Action<string> action = Geeks.someFunction4; ;
        action("Hello Action");			//this invoke returns nothing
    }
}
```

## Func Delegate
It works for the functions with return types only
```
public class Geeks
{
    public static int someFunction5(string someStr) {
        Console.WriteLine(someStr);
        return 0;
    }
}

class GeeksTest {
    static void Main(string[] args) 
    {
        Geeks geeks = new Geeks();
        Func<string, int> func = Geeks.someFunction5; 
	func("Hello");			//this invoke returns integer which can be utilized
    }
}
```

# Constructors
## Static Constructors
1. These contructors are invoked only once during the creation of first instance and in the further instance creation others are invoked
2. They do not have any parameters
3. It doesn't have any access modifiers
4. It can iniatialize only static fields

```
class geeks {
 
    // It is invoked before the first
    // instance constructor is run.
    static geeks()
    {
 
        // The following statement produces
        // the first line of output,
        // and the line occurs only once.
        Console.WriteLine("Static Constructor");
    }
 
    // Instance constructor.
    public geeks(int i)
    {
        Console.WriteLine("Instance Constructor " + i);
    }
}
```

## Copy Constructor
```
class technicalscripter {
    // variables
    private string topic_name;
    private int article_no;
 
    // copy constructor
    public technicalscripter(technicalscripter tech)
    {
        topic_name = tech.topic_name;
        article_no = tech.article_no;
    }
}
```

## Constructor Overloading
We can call the overloaded constructor using `this` keyword
```
public GFG(int l, double w) 
{
	Console.WriteLine("Parameterized Constructor in 2nd Constructor");
	Length = l;
	Width = w;         
}

public GFG(int l, double w, int h) : this(l, w)
{
	Console.WriteLine("Parameterized Constructor in 3rd Constructor");
	Height = h;
}
```

## Desctructor
1. Destructor of class is invoked by Garbage collector in C#.

Synta : Same as C++

# Arrays
1. Arrays in C# are **dynamically** allocated
2. We find their size using their member `length`
3. A jagged array elements are reference types and are initialized to null.
4. Array types are reference types and these hese types implement `IEnumerable`
5. When array stores **primite** data types then it is stored in contiguous memory
6. Whereas in case of **reference** types it is stored in **heap** memory
7. Only Declaration of an array doesn’t allocate memory to the array. For that array must be initialized.
8. The size of arrays can be resized using **resize** keyword

Note : Arrays are of reference type that's why we need to use **new** keyword to initialize them.
```
public class Geeks
{
    public static int[] intArray1 = new int[5];
    public static int[] intArray2 = new int[5] {1,2,3,4,5 };
    public static int[] intArray3 = {1,2,3,4,5};

    //mutlit-dimensional array
    public static int[,] intArray4 = {  { 1, 2 }, 
                                        { 2, 3 },
                                        { 4, 5 } };

    // jagged array of 5 rows
    public static int[][] intArray5 = new int[5][]; 
}



class GeeksTest {
    static void Main(string[] args)     {

        foreach (var item in Geeks.intArray1) {
            Console.WriteLine(item);
        }

        foreach (var item in Geeks.intArray2) {
            Console.WriteLine(item);
        }
    }
}
```

## Jagged Arrays
1. It is array of arrays
2. The array size withing array can vary, that's why jagged arrays
3. No. of **rows will be fixed at declaration** time, but **columns can vary**


Ways to initiallize: <br>
Method 1
```
int[][] jagged_arr = new int[][] 
{
    new int[] {1, 2, 3, 4},
    new int[] {11, 34, 67},
    new int[] {89, 23},
    new int[] {0, 45, 78, 53, 99}
};
```

Method 2
```
int[][] jagged_arr = 
{
    new int[] {1, 2, 3, 4},
    new int[] {11, 34, 67},
    new int[] {89, 23},
    new int[] {0, 45, 78, 53, 99}
};
```

## Array of strings
```
String[] stringarr = new String[] {"Geeks", "GFG", "Noida"};  
```

## Foreach loop in arrays
```
int[] arr = {1, 3, 7, 5, 8, 6, 4, 2, 12}; 
foreach(int i in arr) { 
    if (i == 7) 
    	Console.Write(i + " "); 
} 
```

## Array Class
It is based on **IList** is that's why it is still considered as collection
<br>
Properties
1. Length
2. BinarySearch() : Searches a one-dimensional sorted Array for a value, using a binary search algorithm
3. Clear() : Sets a range of elements in an array to the default value of each element type.

## Sorting
Need to relook

## Length
`arraname.Length`

## Bianary Search
1. To do the binary search in an array, it must be sorted first
```
Array.Sort(arr);
Array.BinarySearch(arr, 9));
```
Searching usng string comparer\
```
int index = Array.BinarySearch(Arr, 1, 4, Obj, StringComparer.CurrentCulture);
```

 ## Comparing Arrays
`Equals(Object)` method which is inherited by Array class from object class is used to check whether an array is equal to another array or not. <br>

```
String[] arr1 = new String[4] { "Sun", "Mon", "Tue", "Thu" };
String[] arr2 = new String[4] { "Sun", "Mon", "Tue", "Thu" };
 
Console.WriteLine(arr1.Equals(arr2));
```

## Length in mutlidimensional array
It gives number of elements in a specified dimension of an Array
```
Console.Write("Total Number of Elements in" + " first dimension of arr: "); 
// using GetLongLength Method 
Console.Write(arr.GetLongLength(0));
```

## Longlength
It is used to get total number of elements in a multidimensional array

## Rank 
To get the dimensionality of an array

## Passing array as arguments
You can easily pass and print it another function unlike C++
```
class GFG {
    static void Result(int[] arr) {
        for(int i = 0; i < arr.Length; i++)        {
            Console.WriteLine("Array Element: "+arr[i]);
        }
    } 
     
    public static void Main() {
                 
        int[] arr = {1, 2, 3, 4, 5};
        Result(arr);
    }
}
```

## Implicitly type
```
var author_names = new[] {"Shilpa", "Soniya", "Shivi", "Ritika"};
```
Used for query expressions

## Object array and Dynamica array
1. USed to store different types of elements
2. Makes code more complex

```
object[] arr = new object[6]; 

arr[0] = 3.899; 
arr[1] = 3; 
arr[2] = 'g'; 
arr[3] = "Geeks"; 
```

### Dynamic Arrays
1. Previousy discussed arrays were static in nature.
2. It is overcome by List<T>

```
List<int> myarray = new List<int>(); 
        myarray.Add(23); 
        myarray.Add(1); 
        myarray.Add(78); 
        myarray.Add(45);
```

## Index out of range
1. If you ask the element out of range, then it throws error
2. This is unlike C/C++ where no index of the bound check is done. The IndexOutOfRangeException is a Runtime Exception thrown only at runtime.

## Reverse array
Simple
```
Array.Reverse(arr);
```

Using CompareTo
```
Array.Sort<int>(arr, new Comparison<int>(
                  (i1, i2) => i2.CompareTo(i1)));
```

Using Delegate
```
// Sort the arr from last to first
        // Normal compare is m-n 
        Array.Sort<int>(arr, delegate(int m, int n)
                                { return n - m; });
```
Can also be written as
```
Array.Sort<int>(arr, (x, y) => { return y - x; }) ;
```

## Using LINQ
The LINQ returns IOrderedIEnumerable, which is converted to Array using ToArray() method. 
```
arr = arr.OrderByDescending(c => c).ToArray();
```

### Get the element which satifies criteria
1. **_FirstOrDefault_**: This method returns the first element of a sequence that satisfies a specified condition or a default value if no such element is found.
```var person1 = people.FirstOrDefault(p => p.Id == 2);```

2. **_SingleOrDefault_**: This method returns the only element of a sequence that satisfies a specified condition or a default value if no such element is found. If more than one element satisfies the condition, it throws an exception.
```var person2 = people.SingleOrDefault(p => p.Id == 4);```

3. **_Where_**: This method filters a sequence of values based on a predicate. It returns all elements that meet the condition, and you can combine it with FirstOrDefault or SingleOrDefault to retrieve a specific element.
``` var person3 = people.Where(p => p.Id == 2).FirstOrDefault();  ```

### Select
The Select method is a LINQ method used to project (transform) each item in the source collection into a new form.

### SelectMany
**Purpose**: SelectMany is used to project each element of a collection to an IEnumerable<T> and flatten the resulting sequences into a single collection. It effectively takes a collection of collections (or an array of arrays) and flattens it into a single collection.

### ForEach
Shorter way of writing for loop
```
ListOfSomething.ForEach(item=>item)
```


Using ForEach for Dictionaries
```
IReadOnlyDictionary<IFinePSFCombination, IFinePSFConfigItem> configItems = ...; // Assume this is initialized  

// Iterate over each key-value pair in the dictionary  
configItems.ToList().ForEach(kvp =>  
{  
    IFinePSFCombination key = kvp.Key;  
    IFinePSFConfigItem value = kvp.Value;   
});
```


### First
The `First` method is part of LINQ (Language Integrated Query) in C# and is used to return the first element in a sequence that satisfies a specified condition.

### Ordering, Summing, Selecting
```
class Person
{
    string name;
    string surname;
    int age;
    public Person(string name, string surname, int age)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
    }

    static void Main(string[] args)    {
        List<Person> people = new List<Person>();

        people.Add(new Person("John", "Doe", 30));
        people.Add(new Person("Jane", "Doe", 25));
        people.Add(new Person("Bob", "Smith", 40));
        people.Add(new Person("Alice", "Johnson", 35));
        people.Add(new Person("Tom", "Lee", 28));
        people.Add(new Person("Emily", "Wong", 22));

        Action<List<Person>> printList = peopleList =>  {
            foreach (var person in peopleList)
                Console.WriteLine($"{person.name} {person.surname} {person.age}");
        };

        Console.WriteLine();

        var peopleLastNameOrderDescending = people.OrderByDescending(p => p.surname).ThenByDescending(p => p.name).ToList();
        printList(peopleLastNameOrderDescending);
        Console.WriteLine();

        var selectPeopleWithAgeGreaterThan30 = people.Where(p => p.age > 30).ToList();
        printList(peopleLastNameOrderDescending);
        Console.WriteLine();

        var sumeAge = people.Sum(x => x.age);
        Console.WriteLine(sumeAge);
        var sumPeopleAgeWithFirst5AscendingNameOrder = people.OrderBy(p => p.name).Sum(x => x.age) ;

    }

}
```


# Array List
1. It is used to create a dynamic array
2. No need to specify the size of the ArrayList.
3. ArrayList represents an ordered collection of an object that can be indexed individually
4. To add elements we use `Add`

Hirerachy: <br>
IEnumberable Interface --> ICollection Interface --> IList Interface --> ArrayList

```
 ArrayList My_array = new ArrayList();
 
        My_array.Add(12.56);
        My_array.Add("GeeksforGeeks");
        My_array.Add(null);
        My_array.Add('G');
        My_array.Add(1234);
```
But List<T> is still better than Array List

## Joining array list
```
// Here we are using AddRange method 
// Which adds the elements of myList 
// Collection in myList again i.e. 
// we have copied the whole myList in it

myList.AddRange(myList);
```

## Remove range
```
public virtual void RemoveRange (int index, int count);
//Example
myList.RemoveRange(2, 2);
```

## ArrayList to Array
While ArrayList is a collection of objects, an Array is collected like-typed variables.

```
ArrayList mylist = new ArrayList(3);
 
mylist.Add("Monday");
mylist.Add("Tuesday");
mylist.Add("Wednesday");

// Copy the data of Arraylist into
// the object Array Using ToArray()
// method
object[] obj1 = mylist.ToArray();
```

Another Method using type casting
```
ArrayList mylist = new ArrayList(5);
 
mylist.Add("Ruby");
mylist.Add("C#");

string[] str = (string[])mylist.ToArray(typeof(string));
```

## Copying ArrayList to Array
It gives error in case of size difference
```
ArrayList myList = new ArrayList(); 
myList.Add("A"); 
myList.Add("B"); 

String[] arr = new String[9]; 
arr[0] = "C"; 
arr[1] = "C++"; 
       
myList.CopyTo(arr);
````

Starting at a particular index
```
myList.CopyTo(arr, 2);
```
## Equality Checker
```
arrlist.Equals(arrlist)
```

# Strings
## Verbatim String Literal – @
Three main uses:
1. Keyword `as` an Identifier
The @ symbol prefixes the keyword, so the compiler takes keyword as an identifier without any error as shown in the below example
```
string[] @for = {"C#", "PHP", "Java", "Python"};
 
foreach (string @as in @for)
{
    Console.WriteLine("Element of Array: {0}", @as);
}
```
2. Storing Path
```
// taking a string and prefix literal with @ symbol. 
// Storing some location of file 
string str1 = @"\\C:\Testing\New\Target";
```

## Class functions
1. Compare()
2. Concat
3. Equals
4. Length

# switch case
You can used strings in switch case
```
string str = "one";
         
switch (str) {
     
case "one":
    Console.WriteLine("It is 1");
    break;

case "two":
    Console.WriteLine("It is 2");
    break;

default:
    Console.WriteLine("Nothing");
```

## String Builder
1.  In situations where you need to perform repeated modifications to a string, we need StringBuilder class
2.  To avoid string replacing, appending, removing or inserting new strings in the initial string C# introduce StringBuilder concept
3.  They are more mutable compared to Strings

```
StringBuilder s = new StringBuilder("HELLO ", 20); 
  
s.Append("GFG"); 
s.AppendLine("GEEKS"); 
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
1. It is like a read only list
2. IEnumerable in C# is an interface that defines one method: GetEnumerator(), which returns an IEnumerator object.
3. This interface is found in the System.Collections namespace and is a key part of the .NET Framework.
4. It allows you to iterate over a collection of objects using constructs like foreach loops12.
5. When you implement IEnumerable<T>, you can use it to create LINQ queries or leverage the yield keyword (for C# only) to build efficient iterators
6.  IEnumerable is read-only and List is not.
7.  If you just need to read, sort and/or filter your collection, IEnumerable is sufficient for that purpose.
8.  Both List<T> and ArrayList implement IEnumberable
9.  You cannot initialize list with IEnumberable. But you can achieve it with putting `ToList()` at the end

# IEnumerable vs IList vs ICollection
## IEnumerable
1. It is a basic list
2. It is read only and you cannot edit
3. It doesn't hold the count of elements inside it, so you need to iterate over to get the count
4. We do filtering in IEnumerable using **where** clause

## ICollection
1. It extends IEnumerable
2. You can **add, remove, update** the collection
3. It holds the count of elements unlike the IEnumerable and no need for iterating over

## IList
1. Extends ICollection
2. Supports **Inserting or removing** from middle of the list

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

# Tuple
1. The word Tuple means “a data structure which consists of the multiple parts
2. you can add elements from 1 to 8.

```
Tuple<string, string, int>My_Tuple2 = new Tuple<string, string, int>("Romil", "Python", 29);

var My_Tuple2 = Tuple.Create(12, 30, 40, 50);
```

Acessing
```
Console.WriteLine("Element of My_Tuple2: " + My_Tuple2.Item1); 
```

1. You can have nested tuples too
2. It implementes `Equals` function too
3. It is of reference type


# ValueTuple
1. It is of `value` type
2. It is faster and easier to use that Tuple

```
//ValueTuple with three elements
ValueTuple<string, string, int> ValTpl2 = new ValueTuple<string,
				string, int>("C#", "Java", 586);
```

Unnamed Member
```
 var author = (20, "Siya", "Ruby");
```

Named Member
```
// ValueTuple with three elements
var library = (Book_id : 2340, Author_name
	       : "Arundhati Roy", Book_name
	       : "The God of Small Things");
```

Unnamed returning
```
static(int, string, string) TouristDetails()
    {
        return (384645, "Sophite", "USA");
    }
 
    // Main method
    static public void Main()
    {
 
        // Store the data provided by the TouristDetails method
        var(Tourist_Id, Tourist_Name, Country) = TouristDetails();
 
        // Display data
        Console.WriteLine("Tourist Details: ");
        Console.WriteLine($ "Tourist Id: {Tourist_Id}");
        Console.WriteLine($ "Tourist Name: {Tourist_Name}");
        Console.WriteLine($ "Country: {Country}");
```

# Indexers and Propeties

## Indexers 
1. Allows class objects to be used as arrays
2. The syntax is similar to properties
3. `this` keyword is always used to declare an indexer.
4. They are also known as **Smart Arrays** or **Parameterized** Property

Note : **this**, **<params>** are the extra one 
```
class IndexerCreation 
{
     private string[] val = new string[3]; 
     public string this[int index] 
    {
        get { 
            return val[index];
        }
        set {
            val[index] = value;
        }
    }
}
 
class main {
     
    public static void Main() {
         
        IndexerCreation ic = new IndexerCreation();
 
        ic[0] = "C";
        ic[1] = "CPP";
	}
}
```
Other points
1. You can overload the indexers too with different data type and params
2. You can also also multi-dimensionality with it


## Properties
1. They are special methods called accessors with getter and setters
2. For read only property you can use on **get** accessor
3. Auto implementation is also there

```
class Myprop { 
    int _number; 
    public int Number 
    { 
        get { 
            return this._number; 
        } 
        set { 
            this._number = value; 
        }
    }
}
```

**Restrictions :** <br>
1. A property cannot be passed via ref or out parameter to a method
2. You cannot overload a property
3. A property should not alter the state of the underlying variable when the get accessor is called


# Ineritance
Advantages
1. Core resuability
2. Code Maintainance
3. Code organization

Disadvantages:
1. Tight coupling
2. Fragile code due to dependency

## Mulitple Ineritance

```
interface IShape {
    double GetArea();
}
 
interface IColor {
    string GetColor();
}
 
class Rectangle : IShape, IColor {
    private double length;
    private double breadth;
    private string color;
 
    public Rectangle(double length, double breadth, string color) {
        this.length = length;
        this.breadth = breadth;
        this.color = color;
    }
 
    public double GetArea() {
        return length * breadth;
    }
 
    public string GetColor()  {
        return color;
    }
}
 
class Program {
    static void Main(string[] args)     {
        Rectangle rect = new Rectangle(5, 10, "blue");
        Console.WriteLine("Area of rectangle: " + rect.GetArea());
        Console.WriteLine("Color of rectangle: " + rect.GetColor());
    }
}
```

## Constructor inheritance
Use `base` keyword
```
class Vehicle
{
    public int speed;
 
    public Vehicle(int speed)
    {
        this.speed = speed;
    }
}
 
class Car : Vehicle
{
    public string model;
 
    public Car(int speed, string model) : base(speed)
    {
        this.model = model;
    }
}
```

## Abstract Classes
1. It cannot be instantiated
2. **abstract** modifier can be used with **indexers**, **events**, and **properties** 

```
public abstract class Animal{
    public abstract string Sound { get; }
 
    public virtual void Move()  {
        Console.WriteLine("Moving...");
    }
}
 
public class Cat : Animal {
    public override string Sound => "Meow";
 
    public override void Move()  {
        Console.WriteLine("Walking like a cat...");
    }
}
```

Note:
1. Vritual methods can have implementation
2. But abstract methods cannot

## Sealed Class
1. It is like `final` keyword in c++
2. Even methods can be sealed too to stop further overriding of methods in further inheritance

## Object class
1. Every class in C# is directly or indirectly derived from the Object class
2. In other programming languages, the built-in types like int, double, float, etc. do not have any object-oriented properties
3. But in C#, we have no need for such wrapping due to the presence of value types that are inherited from the System.ValueType that is further inherited from System.Object.
4. So in C#, value types also work similarly to reference types
5. Reference types directly or indirectly inherit the object class by using other reference types.


Functions
1. **ReferenceEquals(Object, Object)**	: Determines whether the specified Object instances are the same instance.
2. **Finalize()** : Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
3. **Equals(Object, Object)** :	Determines whether the specified object instances are considered equal.
4. **ToString()** : Returns a string that represents the current object

# Interface
```
interface  <interface_name >
{
    // declare Events
    // declare indexers
    // declare methods 
    // declare properties
}
```

## Implement multiple interfaces with same name methods
```
interface G1 { 
    	void mymethod(); 
} 
  
interface G2 { 
   	void mymethod(); 
} 
  
class Geeks : G1, G2 { 
	void G1.mymethod() { 
	    Console.WriteLine("GeeksforGeeks"); 
	} 
	      
	void G2.mymethod() { 
	    Console.WriteLine("GeeksforGeeks"); 
	} 
}
```

## Explicit Interface Implementation
Explicitly telling the compiler that a particular member belongs to that particular interface is called Explicit interface implementation.  Example is same as the section before.


# Multithreading

Initialize the thread object with a function and initiate the thread.
```
class GFG
{
    public static void Main()
    {
        Thread t1 = new Thread(someMethod);
        t1.Start();

        t1.Join(); //Making main thread wait before exit till t1 ends
    }
    public static void someMethod()
    {
        for (int i = 0; i < 10; i++)
        {
            Thread.Sleep(10);
            Console.WriteLine("Doing some work");
        }
    }
}
```

## Threadpool
```
    static void Main() {
        ThreadPool.QueueUserWorkItem(Worker, "Hello, world!");
        Console.WriteLine("Done");
    }
 
    static void Worker(object state)
    {
        string message = (string)state;
        for (int i = 0; i < 10; i++) {
            Console.WriteLine(message);
            Thread.Sleep(100);
        }
    }
```

## Thread Types
### Foreground Thread
1. These are task critical threads which complete their task even after main thread ends
2. They are created by default

```
static void Main(string[] args)
    {
 
        // Creating and initializing thread
        Thread thr = new Thread(mythreadFunc);
        thr.Start();
        Console.WriteLine("Main Thread Ends!!");
    }
```

### Background Thread
1. These are not task critical threads
2. You need to specify if that is a background thread
3. They end with before or with the main thread 
```
static void Main(string[] args)
    {
        Thread thr = new Thread(mythread);
 
        thr.Name = "Mythread";
        thr.Start();
        thr.IsBackground = true;
 
        Console.WriteLine("Main Thread Ends!!");
    }
```

## Main Thread
Getting access to current thread
```
Thread thr;
thr = Thread.CurrentThread;
```

You cannot join the current thread else it wil cause deadlock as it will never end.

## States of thread
1. Unstarted : During the time of declration until `Start()` call
2. Runnable : When `Start()` is called
3. No Running : When methods like `Wait()`, `Sleep()`, `Suspend()` is called
4. Done state : When it finishes

Methods to check states:
1. IsAlive()
2. ThreadState ThreadState{ get; }

Pause/Suspend a thread and resume
1. Suspend() method is called to suspend the thread.
2. Resume() method is called to resume the suspended thread.


## Schedule a thread
A thread is scheduled using `Start()`
```
Start()
Start(Object)
```
Example
```
Thread thr1 = new Thread(obj.Job1); 
Thread thr2 = new Thread(Job2); 

// Start the execution of Thread 
// Using Start(Object) method 
thr1.Start(01); 
thr2.Start("Hello")
```

## Setting Thread Priority
```
Thread T1 = new Thread(work); 
Thread T2 = new Thread(work); 
Thread T3 = new Thread(work); 

// Set the priority of threads 
T2.Priority = ThreadPriority.Highest; 
T3.Priority = ThreadPriority.BelowNormal; 
T1.Start(); 
T2.Start(); 
T3.Start();
```

## Task vs Thread
1. Task is like promise of C#

Maiking functions run parallely <br>
1. Without async await
```
public class GFG{ 

static void Main(string[] args) 
{ 
	Demo(); 
	Console.ReadLine(); 

} 
public static void Demo() { 
	var watch = new System.Diagnostics.Stopwatch(); 
	watch.Start(); 
	StartSchoolAssembly(); 
	TeachClass12(); 
	watch.Stop(); 
	Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms"); 
} 


public static void StartSchoolAssembly() { 
	Thread.Sleep(8000); 
	Console.WriteLine("School Started"); 
} 


public static void TeachClass12() { 
	Thread.Sleep(3000); 
	Console.WriteLine("Taught class 12"); 

} 
} 
```

2. With async/await
```
// C# program for async and await 
using System; 
using System.Threading; 
using System.Threading.Tasks; 

public class GFG{ 

static void Main(string[] args) 
{ 
	Demo(); 
	Console.ReadLine(); 
} 

public static void Demo() { 
	var watch = new System.Diagnostics.Stopwatch(); 
	watch.Start(); 

	var task1 = StartSchoolAssembly(); 
	var task2 = TeachClass12(); 
	Task.WaitAll(task1, task2, task3); 
	watch.Stop(); 
	Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms"); 
	
} 

public static async Task StartSchoolAssembly() { 
	await Task.Run(() => 	{ 
		Thread.Sleep(8000); 
		Console.WriteLine("School Started"); 
	}); 
}

public static async Task TeachClass12() { 
	await Task.Run(() => 	{ 
		Thread.Sleep(3000); 
		Console.WriteLine("Taught class 12"); 
	}); 
} 	
} 

```
**WaitAll()** : Waits for all of the provided Task objects to complete execution within a specified number of milliseconds or until the wait is cancelled.


# Generics

## List
1. List is a generic whereas ArrayList is a non-generic collection
2. The List class implements the ICollection<T>, IEnumerable<T>, IList<T>, IReadOnlyCollection<T>, IReadOnlyList<T>, ICollection, IEnumerable, and IList interface.

```
List<string> my_list1 = new List<string>() { “geeks”, “Geek123”, “GeeksforGeeks” };
```
## Sorted List
1. SortedList is a collection of key/value pairs which are sorted according to keys. Like **Ordered List**
2. By default, this collection sort the key/value pairs in ascending order
3. In SortedList, duplicate keys are not allowed.
4. In SortedList you cannot store keys of different data types

```
SortedList my_slist1 = new SortedList();
 
my_slist1.Add(1.02, "This");
my_slist1.Add(1.07, "Is");
my_slist1.Add(1.04, "SortedList");
my_slist1.Add(1.01, "Tutorial");
```

## Hash Set
1. HashSet is an unordered collection of unique elements like **Unordered Set**
2. The order of the element is not defined. You cannot sort the elements of HashSet.
3. You can do union of elements too ` myhash1.UnionWith(myhash2);`
4. You can do intersection too `myhash1.IntersectWith(myhash2);`

```
HashSet<string> myhash1 = new HashSet<string>();

// Add the elements in HashSet
// Using Add method
myhash1.Add("C");
myhash1.Add("C++");
myhash1.Add("C#");
myhash1.Add("Java");
myhash1.Add("Ruby");
```

## Sorted Set
1. It is like **Ordered Set**
2. In SortedSet, the order of the element is ascending.

```
SortedSet<int> my_Set1 = new SortedSet<int>();
 
my_Set1.Add(101);
my_Set1.Add(1001);
my_Set1.Add(10001);
my_Set1.Add(100001);
Console.WriteLine("Elements of my_Set1:");
```

## Dictionary
1.It is like **unordered Map**
2. A generic collection which is generally used to store key/value pairs

```
  Dictionary<int, string> My_dict1 =  new Dictionary<int, string>(); 
   
  // Adding key/value pairs 
  // in the Dictionary
  // Using Add() method
  My_dict1.Add(1123, "Welcome");
  My_dict1.Add(1124, "to");
  My_dict1.Add(1125, "GeeksforGeeks");
```

Searching
```
foreach(KeyValuePair<int, string> ele1 in My_dict1)
          {
              Console.WriteLine("{0} and {1}",
                        ele1.Key, ele1.Value);
          }
```

## Equality Comparer
```
public Dictionary(IEqualityComparer<TKey> comparer);
```
This constructor allows you to create a new instance of a dictionary while providing a custom IEqualityComparer<TKey> for key comparisons.

Now with this, you can have key to key comparisons using the equility comparer
```
BundleItems = new Dictionary<IFinePSFCombination, FinePSFBundleItem>(new FinePSFCombinationEqualityComparer());
```
Now in above dictionary combination to combination combination will happen using EqualityComparer.

## Sorted Dictionary
It is like **ordered map** and uses **BST** for faster insertion and searching that's why faster but more memory taking compared to sortedList
```
SortedDictionary<int, string> My_sdict = 
            new SortedDictionary<int, string>();
 
        // Adding key/value pair in Sorted 
        // Dictionary Using Add() method
        My_sdict.Add(004, "Ask.com");
        My_sdict.Add(003, "Yahoo");
        My_sdict.Add(001, "Google");
        My_sdict.Add(005, "AOL.com");
        My_sdict.Add(002, "Bing");
        Console.WriteLine("Top Search Engines:");
```

## HashTable
1. It is more thread saef compared to HashSet.
2. Hashtable, you can store elements of the same type and of the different types.

```
Hashtable my_hashtable1 = new Hashtable();
 
// Adding key/value pair 
// in the hashtable
// Using Add() method
my_hashtable1.Add("A1", "Welcome");
my_hashtable1.Add("A2", "to");
my_hashtable1.Add("A3", "GeeksforGeeks");

```

## Stack
```
Stack my_stack = new Stack();
 
// Adding elements in the Stack
// Using Push method
my_stack.Push("Geeks");
my_stack.Push("geeksforgeeks");
my_stack.Push('G');
my_stack.Push(null);
my_stack.Push(1234);
my_stack.Push(490.98);
```

## Queue
```
Queue my_queue = new Queue(); 
  
// Adding elements in Queue 
// Using Enqueue() method 
my_queue.Enqueue("GFG"); 
my_queue.Enqueue(1); 

 my_queue.Dequeue(); 
```

## Linked List
```
LinkedList<String> my_list = new LinkedList<String>();
 
// Adding elements in the LinkedList
// Using AddLast() method
my_list.AddLast("Zoya");
my_list.AddLast("Shilpa");

my_list.Remove(my_list.First);
```
Other function:
1. AddFirst
2. AddLast

## HashTable vs Dictionary
Dictionary
1. Generic
2. Order is maintained
3. In Dictionary, you must specify the type of key and value.
4. The data retrieval is faster than Hashtable due to no boxing/ unboxing.
5. It’s recommended to use ConcurrentDictionary<TKey, TValue> which provides thread-safe operations.


HashTable
1. Non-generic
2. No order is maintained
3. In Hashtable, there is no need to specify the type of the key and value.
4. The data retrieval is slower than Dictionary due to boxing/ unboxing.
5. It is thread safe.

# Events

# EventAggregator

# IDisposable
1. Used for unmanaged resources, those which are not managed by Garbage Collector
 - File Access
 - Network Access
 - Database Access
 - Talking to operating system
 - Anything to do with Graphics
 - Files and Sockets

```
public class UnmanagedResource : IDisposable
{
	public void DoWork() {
		Console.WriteLine{"Starting Connection"};
		Console.WriteLine{"Doing Work"};
	}
	
	public void Dispose() {
		Console.WriteLine{"Starting Connection"};
	}
}
```
Dispose function should be called at the end of the life of UnmanagedResource object

# Using Keyword
1. It is used ro automating calling the Dispose() function.
2. Within `using` curly braces usage the operation is performed especially for IDisposable functions
3. Using keyword makes sure that `Dispose()` method is called even if the exception occurs or devloper forgets to add called `Disposable()` method.

```
using (var obj = new UnmanagedResource())
{
	obj.DoWork();
	//obj.Dipose();		//gets called even if you forget to
}
```

# LINQ Expressions
1. Has very good query capabilities directly into C#

## Need for LINQ
Objective : To query for age between 12 and 20

```
 Student[] studentArray = {
     new Student() { StudentID = 1, StudentName = "John", Age = 18 },
     new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
     new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
     new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
     new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
     new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
     new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
 };
```

Method 1: 
```
 foreach (var std in studentArray) {
     if (std.Age > 12 && std.Age < 20)  {
         Console.WriteLine(std.StudentName);
     }
 }
```

Method 2:
```
var ageBetween12and20 = from student in studentArray
                        where student.Age > 12
                        where student.Age < 20
                        select student;
```

Method 3:
```
var ageBetween12and20v2 = studentArray.Where( x => x.Age > 12 && x.Age < 20 );
```

## Applicability
It is applicable for classes implementing `IQueryable` and `IEnumberable`
1. Enumerable classes
- List
- Dictionary
- HashSet
- Queue
- SortedDictionary
- SortedList
- SortedSet
- LinkedList
- Stack

Functions list : [see the image here](https://www.tutorialsteacher.com/Content/images/linq/Enumerable.png)

2. Queryable classes : Supported by many frameworks
- LINQ to SQL
- Entity Framework
- LINQ to Amazon
- LINQ to LDAP

Functions list : [see this image for functions](https://www.tutorialsteacher.com/Content/images/linq/queryable.png)


## Syntax
```
from <range variable> in <IEnumerable<T> or IQueryable<T> Collection>

<Standard Query Operators> <lambda expression>

<select or groupBy operator> <result formation>
```
[check syntax here in image] (https://www.tutorialsteacher.com/Content/images/linq/linq-query-syntax.png)

```
 IList<string> stringList = new List<string>() {
     "C# Tutorials",
     "VB.NET Tutorials",
     "Learn C++",
     "MVC Tutorials" ,
     "Java"
 };

//Method 1 : Linq Query Syntax
 var tutorials = from stringL in stringList
                 where stringL.Contains("Tutorials")
                 select stringL;

//Method 2 : LINQ Method Syntax
 var tut = stringList.Where(x => x.Contains("Tutorials"));

```
The extension method `Where()` is defined in the Enumerable class.

## Lambda Function Evolution
### Evolution
[image source 1](https://www.tutorialsteacher.com/Content/images/linq/lambda-expression-1.png)

[image source 2](https://www.tutorialsteacher.com/Content/images/linq/lambda-expression-2.png)

### Making a list readonly
```
IReadOnlyCollection<Person> people = new List<Person>  
        {  
            new Person { Name = "Alice", Age = 30 },  
            new Person { Name = "Bob", Age = 25 },  
            new Person { Name = "Charlie", Age = 35 },  
            new Person { Name = "Diana", Age = 28 }  
        }.AsReadOnly(); 
```

### Multiple Params
```
(s, youngAge) => s.Age >= youngage;
```
Above we are check with student age satisfying condition that it is greater than youngage

### Multiple Statements
```
(s, youngAge) =>
{
  Console.WriteLine("Lambda expression with multiple statements in the body");
    
  Return s.Age >= youngAge;
}
```
### Lambda in use
```
Func<Student, bool> isStudentTeenAger = s => s.age > 12 && s.age < 20;
Student std = new Student() { age = 21 };
bool isTeen = isStudentTeenAger(std);// returns false
```
### Func Delegate
Has last parameter as the return type
```
Func<Student, bool> isStudentTeenAger = s => s.age > 12 && s.age < 20;
```

bool is the return type

### Action Delegate
No return type is involved
```
Action<Student> PrintStudentDetail = s => Console.WriteLine("Name: {0}, Age: {1} ", s.StudentName, s.Age)
```

### Using lambda in LINQ
```
Func<Student, bool> func = s => s.Age > 12 && s.Age < 20;
var ageBetween12and20V2 = studentArray.Where(func);
````

## Standard LINQ Functions
```
Filtering	-- Where, OfType
Sorting		-- OrderBy, OrderByDescending, ThenBy, ThenByDescending, Reverse
Grouping	-- GroupBy, ToLookup
Join		-- GroupJoin, Join
Projection	-- Select, SelectMany
Aggregation	-- Aggregate, Average, Count, LongCount, Max, Min, Sum
Quantifiers	-- All, Any, Contains
Elements	-- ElementAt, ElementAtOrDefault, First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault
Set		-- Distinct, Except, Intersect, Union
Partitioning	-- Skip, SkipWhile, Take, TakeWhile
Concatenation	-- Concat
Equality	-- SequenceEqual
Generation	-- DefaultEmpty, Empty, Range, Repeat
Conversion	-- AsEnumerable, AsQueryable, Cast, ToArray, ToDictionary, ToList
```

### Where
Filters the collection based on a given criteria expression and returns a new collection

```
IList<Student> studentList = new List<Student>() { 
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 } 
    };

var filteredResult = from s in studentList
                    where s.Age > 12 && s.Age < 20
                    select s.StudentName;
```

**Index** overload <br>
The second parameter of `Where` can have index overload 
```
var filteredResult = studentList.Where((s, i) => { 
            if(i % 2 ==  0) // if it is even element
                return true;
                
        return false;
    });

foreach (var std in filteredResult)
        Console.WriteLine(std.StudentName);
```

### OfType
Filtering based on casting
```
IList mixedList = new ArrayList();
mixedList.Add(0);
mixedList.Add("One");
mixedList.Add("Two");
mixedList.Add(3);
mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });

// Method 1
var strList = from mix in mixedList.OfType<string>()
              select mix;

//Method 2
var intList = mixedList.OfType<int>();
```

### OrderBy
```
IList<Student> studentList = new List<Student>() { 
    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
    new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
    new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 } 
};

//Method 1
var orderByResult = from s in studentList
                   orderby s.StudentName 
                   select s;
//Method 2
var orderByResult2 = studenList.OrderBy(x => x.StudentName);
```

### ThenBy
Use ThenBy() method after OrderBy to sort the collection on another field in ascending/descending order based on what was done before
```
IList<Student> studentList = new List<Student>() { 
    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
    new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
    new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }, 
    new Student() { StudentID = 6, StudentName = "Ram" , Age = 18 }
};
var thenByResult = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age);

var thenByDescResult = studentList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);
```

**Note : ThenBy or ThenByDescending is NOT applicable in Query syntax.**

### GroupBy
1. The grouping operators create a group of elements based on the given key.
2. We may need to iterate over twice from the resultant query as the result gives a multidimentional list
```
IList<Student> studentList = new List<Student>() { 
        new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
        new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
        new Student() { StudentID = 5, StudentName = "Abram" , Age = 21 } 
    };

// Method 1
var groupedResult = from s in studentList
                    group s by s.Age;

// Method 2
var groupedResult = studentList.GroupBy(s => s.Age);

// Method 3 - Using Lookup
var lookupResult = studentList.ToLookup(s => s.age);

//iterate each group        
foreach (var ageGroup in groupedResult) {
    Console.WriteLine("Age Group: {0}", ageGroup .Key); //Each group has a key 
    foreach(Student s in ageGroup) // Each group has inner collection
        Console.WriteLine("Student Name: {0}", s.StudentName);
}
```



### Join
[Good source of revision](https://www.youtube.com/watch?v=Te2o5qakvZk&list=PL6n9fhu94yhWi8K02Eqxp3Xyh_OmQ0Rp6&index=22&ab_channel=kudvenkat)

1. The Join operator operates on two collections, inner collection & outer collection.
2. It **returns a new collection that contains matching elements from both the collections** which satisfies specified expression.
3. Has 5 params to take care of
	- outer
	- inner
	- outerKeySelector
	- innerKeySelector
	- resultSelector

Examples:
[Example 1](https://github.com/codepks/LearningCSharp/blob/main/LINQ%20Examples/Example%201.cs)

**Syntax 1**<br>

```
var innerJoin = studentList.Join(// outer sequence 
                      standardList,  			// inner sequence 
                      student => student.StandardID,    // outerKeySelector
                      standard => standard.StandardID,  // innerKeySelector
                      (student, standard) => new  	// result selector
		      {
			StudentName = student.StudentName,
			StandardName = standard.StandardName
		      });
```
**Syntax 2**<br>
```
var adcInDataDivadcHazeData = 	from adcNorm in adcInData

			      	//holding elements from both the lists
                              	join adcHaze in adcHazeData

			      	//Tell linking condition
                              	on new { adcNorm.Collector, adcNorm.Throughtput} equals
				   new { adcHaze.Collector, adcHaze.Throughtput }

				// Tell how your output should be like
                              	select new {  adcNorm.Throughtput, 
                                            adcNorm.Collector, adcNorm.ADCInValue,
                                            adcRPPMValue = adcNorm.ADCOutValue / adcHaze.ADCOutValue }; 
```


**Join in Query Syntax vs Method Syntax** <br>
```
var customerDescription =     from cust in customers
			      join od in orders
			      on cust.Name equals od.CustomerName
			      select new { cust.Name, cust.Description };

var customerDescription2 =    customers.Join(orders,
			      cust => cust.Name,		//key selector
			      od => od.CustomerName,		//key selector
			      //order of params should be same as key selectors
			      (cust, od) => new { cust.Name, cust.Description }); 
```

1. The **key selector** for the outer sequence `student => student.StandardID` indicates that take StandardID field of each elements of studentList should be match with the key of inner sequence `standard => standard.StandardID` . If value of both the key field is matched then include that element into **result**.
2. The **last parameter** in Join method is an expression to formulate the **result**. In the above example, result selector includes `StudentName` and `StandardName` property of both the sequence.

### Left OuterJoin
Here we take care of all the non-matching elements too
```
var customerDescription =     from cust in customers
			      join od in orders
			      on cust.Name equals od.CustomerName into eGroup
				from name in eGroup.DefaultIfEmpty //for missing names
			      select new {
					CustomerName = cust.Name,
					CustDesc = d == null ? "No Description" : od.Description
					};
```

### Group Join
[Understand here](https://www.youtube.com/watch?v=Da3akpqjaR4&list=PL6n9fhu94yhWi8K02Eqxp3Xyh_OmQ0Rp6&index=21&ab_channel=kudvenkat)

```
 IList<Student> studentList = new List<Student>() {
 new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
 new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
 new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
 new Student() { StudentID = 4, StudentName = "Ram",  StandardID =2 },
 new Student() { StudentID = 5, StudentName = "Ron" }
 };

 IList<Standard> standardList = new List<Standard>() {
 new Standard(){ StandardID = 1, StandardName="Standard 1"},
 new Standard(){ StandardID = 2, StandardName="Standard 2"},
 new Standard(){ StandardID = 3, StandardName="Standard 3"}
 };
```

**Method Syntax**
1. Keep the outer group based on what do you want to pivot around
2. Here we are pivoting aroung StandardName and thus keeping standardList as the outerkey
```
 var groupJoin = standardList.GroupJoin(studentList, 
    std => std.StandardID, //outerkey
    stud => stud.StandardID, //innerKey
    (stdName, studentNameGroup) => new // outerKey Object, InnerKey list
    {
        //creating the properties for the new list
        StandardNames = stdName.StandardName, // using the StandardName property
        StudentNames = studentNameGroup         // using the studentName property
    } 
                                        );

	// groupJoin consists of groupings of Students based on StandardName
	
	foreach(var stdNames in groupJoin)
	{
	    Console.WriteLine( stdNames.StandardNames ); //printing the outerkey which is a group head
	    foreach (var item in stdNames.StudentNames) //printing the group segregation
	    {
	        Console.WriteLine(item.StudentName);
	    }
	}
```	

 **Output** <br>
    Standard 1
    John
    Moin

    Standard 2
    Bill
    Ram

    Standard 3
		

**Query Syntax**
```
var groupJoin = from std in standardList 
                    join s in studentList 
                    on std.StandardID equals s.StandardID
                    into studentGroup
                    select new { 
		      Students = studentGroup , 
		      StandardName = std.StandardName 
		    };

 foreach (var item in groupJoin) {
     Console.WriteLine(item.StandarFulldName);
     foreach (var stud in item.Students)
         Console.WriteLine(stud.StudentName);
 }
```
In the code above, based **StandardName** groupings in studentList has been made.

1. The **key selector** for the outer sequence `standard => standard.StandardID` indicates that **StandardID** field of each elements in standardList should be match with the key of inner sequence studentList `student => student.StandardID`
2. result selector includes grouped collection `studentGroup` and `StandardName`

# Keywords
## INotifyPropertyChanged
1. The moment you make a strcture/class inherit forlm INotifyPropertyChanged, you make the class observable.
2. You get ```event PropertyChangedEventHandler PropertyChanged``` event
3. You can subscribe to the event with your functions, if your function has the same signature as ```public delegate void PropertyChangedEventHandler(object sender, PropertyChangedEventArgs e);```
4. Now all you have to do it invoke your event in any of the property set calls and BKM is to call the RaisePropertyChanged method ```PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));```

## [RecordElementIgnore] 
makes your intent clear to other developers (or to your future self) that a specific property should not be serialized

## Deserialization
1. It is a process of converting serial data or a byte stream into a data structure
2. The data is typically in a serialized format such as JSON, XML, or binary

Example:
1. Loading configuration data
2. Data is stored in a serialized format in a JSON format
3. We deserialize it to store it in a sttructure format

## Expression
```
public static Expression<Func<DFNormBundleItem, DFNormResultItem>>
            ResultItem => x => x._resultItems[0];
```
In the code above wherever ResultItem is used the lambda expression runs

## ??  null coalescing operator
```
var result = nullableValue ?? defaultValue;
```
1. If nullableValue is not null, the result will be nullableValue.
2. If nullableValue is null, the result will be defaultValue.

Example 1
```
 string displayName = name ?? defaultName;
```
`diplayname` is nullable so it will check if name is null, if it is then it will move next for non-null value i.e. defaultName and if it is non-null then `displayName` will be assigned `defaultName`

Example 2
```
string name = null;  
string nickname = null;  
string defaultName = "Guest";  

string displayName = name ?? nickname ?? defaultName;  
// Result will be "Guest" since both name and nickname are null  
Console.WriteLine(displayName); // Output: Guest
```

Using along with conditional operator
```
class User  
{  
    public string? Name { get; set; }  
}  

User user = null;  
string displayName = user?.Name ?? "Unknown User"; // If user is null, displayName will be "Unknown User"  
Console.WriteLine(displayName);
```

## Expression Bodied Members
```
public TimeSpan Length  
{  
    get { return EndTime.Subtract(StartTime); }  
}
```
The code above can be replaced with :
```
public TimeSpan Length => EndTime.Subtract(StartTime);
```

The => syntax in C# is known as an expression-bodied member. 

# Reactive Programing
## Subject
In the context of Reactive Extensions for .NET (Rx), a Subject<T> is a particular type of observable that can act both as an observer and an observable. Subject<T> allows you to push notifications to subscribers while also being able to subscribe to other observables
```
using System;  
using System.Reactive.Subjects;  

class Program  
{  
    static void Main()  
    {  
        var subject = new Subject<string>();  

        subject.Subscribe(value => Console.WriteLine($"Received: {value}"));  

        subject.OnNext("Hello");  
        subject.OnNext("World");  

        subject.OnCompleted(); // Marks the subject as completed  
    }  
}
```

Output
```
Received : Hello
Received : World
```


Complicated Example<br>
```
rivate void SubscribeToEvents()  
{  
    ProgressVisibilityCommand.CanExecuteChanged += (sender, args) =>  
    {  
        RaisePropertyChanged(nameof(ProgressVisibility));  
    };  
}
```
1. `CanExecuteChanged` is from `EventHandler` delegate and has parameters `senders` and `args`
2. Only same signature functions can subscribe to CanExecuteChanged event

# Observer Design Pattern

**Notification Provider**
1. The notification provider implements the interface `IObserverable<T>` which required you to implement only function function `Subscribe`
2. This function is called by the observers that wish to recieve the notifications from the provider

**Obsever**
1. The observer has to implement the interface `IObserver<T>`
2. For complement implementation he has to implement
 - `OnNext` : which supplies the observer with new or current information
 - `OnError` : which informs the observer that eror has occurred
 - `OnCompleted` : which indicates that the provider has finished sending the notifications

# Nullable double
## Declaration
```
double? _bicellTargetNew = null;
```

## Use Case
```
BicellTargetPrev = latestResult?.BicellTarget;
```
1. Error : cannot convert double? to double in the line below
2. A nullable double can hold double value as well as null value
3. So we need to take care what happens when double is null

Solution
```
BicellTargetPrev = latestResult?.BicellTarget ?? defaultValue; // use a specific default value
```
# Depedency Injection
(source of video)[https://www.youtube.com/watch?v=T1bK0j2dvc0]

1. It is helpful in handling the tight coupling between objects

2. Three ways to do so
 - **Constructor Based Dependency** : Create the dependent object while creating the object `Person person = new Person(home)`
 - **Property Base Dependecny** : Create the object via initializing public property `Person person = new College();`
 - **Method Injection** : Use the dependent object oonly via object when needed `person.GetTreatment(new Hospital)`

3. **Using interfaces** : Reduces coupling and we can achieve single point of changes
4. **Using Containers** : We can map the object to the interface and predecide which object to be called on the usage of the interface using autofac. You don't get to see `new` keyword


# Object Marshalling
Without MarshalByRefObject
In this example, we will create a simple remote object that is passed by value, which means the object is serialized and deserialized when sent across the application domain.

## C# Without MarshalByRefObject
```
using System;  
using System.Runtime.Remoting;  

[Serializable]  
public class MyRemoteObject  
{  
    public int Value { get; set; }  

    public void Increment()  
    {  
        Value++;  
    }  
}  

class Program  
{  
    static void Main()  
    {  
        MyRemoteObject obj = new MyRemoteObject { Value = 10 };  
        Console.WriteLine("Initial Value: " + obj.Value);  

        // Simulating remote call  
        MyRemoteObject remoteObj = obj; // This creates a copy  
        remoteObj.Increment();  

        Console.WriteLine("After Increment (local): " + obj.Value); // Output: 10  
        Console.WriteLine("After Increment (remote): " + remoteObj.Value); // Output: 11  
    }  
}
```

## With MarshalByRefObject
In this example, we will create a remote object that derives from MarshalByRefObject, allowing the client to interact with the server-side instance directly.

C# With MarshalByRefObject
```
using System;  
using System.Runtime.Remoting;  

public class MyRemoteObject : MarshalByRefObject  
{  
    public int Value { get; set; }  

    public void Increment()  
    {  
        Value++;  
    }  
}  

class Program  
{  
    static void Main()  
    {  
        MyRemoteObject obj = new MyRemoteObject { Value = 10 };  
        Console.WriteLine("Initial Value: " + obj.Value);  

        // Simulating remote call  
        MyRemoteObject remoteObj = obj; // This does not create a copy  
        remoteObj.Increment();  

        Console.WriteLine("After Increment (local): " + obj.Value); // Output: 11  
        Console.WriteLine("After Increment (remote): " + remoteObj.Value); // Output: 11  
    }  
}
```

## Key Differences
### Without MarshalByRefObject:

The MyRemoteObject is serialized when passed to the remote context, creating a copy.
Changes made to the remote object do not affect the original object.

### With MarshalByRefObject:

The MyRemoteObject is passed by reference, allowing the client to interact with the same instance.
Changes made to the remote object affect the original object, as they refer to the same instance.


# Reflection
```
using System;  
using System.Reflection;  

public class SampleClass  
{  
    public int MyProperty { get; set; }  

    public void MyMethod()  {  
        Console.WriteLine("Hello from MyMethod");  
    }  
}  

class Program  
{  
    static void Main(string[] args)  {  
        // Create an instance of SampleClass  
        var sample = new SampleClass();  

        // Get the type of SampleClass  
        Type type = sample.GetType();  

        // Display class name  
        Console.WriteLine("Class Name: " + type.Name);  

        // Display properties  
        Console.WriteLine("Properties:");  
        foreach (PropertyInfo prop in type.GetProperties())  {  
            Console.WriteLine($" - {prop.Name} (Type: {prop.PropertyType})");  
        }  

        // Display methods  
        Console.WriteLine("Methods:");  
        foreach (MethodInfo method in type.GetMethods())  {  
            Console.WriteLine($" - {method.Name}");  
        }  

        // Set property value using reflection  
        PropertyInfo property = type.GetProperty("MyProperty");  
        property.SetValue(sample, 10);  

        // Invoke MyMethod using reflection  
        MethodInfo methodInfo = type.GetMethod("MyMethod");  
        methodInfo.Invoke(sample, null);  
        
        // Get the value of MyProperty  
        Console.WriteLine($"MyProperty Value: {property.GetValue(sample)}");  
    }  
}
```
OUTPUT

```
Class Name: SampleClass
Properties:
 - MyProperty (Type: System.Int32)
Methods:
 - get_MyProperty
 - set_MyProperty
 - MyMethod
 - GetType
 - ToString
 - Equals
 - GetHashCode
Hello from MyMethod
MyProperty Value: 10
```

# Regex
1. To search two keywords at once `(?=.*keyword1)(?=.*keyword2)`
2.  If you want to make it case-insensitive, you can add `(?i)` at the beginning of your regex pattern
3.   If your keywords contain spaces or special characters, ensure to escape them appropriately using a backslash `(\).`
