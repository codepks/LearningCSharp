# Introduction
 
 [source](https://github.com/Almantask/CSharp-From-Zero-To-Hero/blob/Chapter1/Lesson/Variables-And-Console/Src/BootCamp.Chapter1/Program.cs)

 Starting (entry) point of a console application is Main
 
 float weight = 80.5f;

 // char is used for storing a single symbol
 // single quotes ('')
 char firstLetter = 'K';

 `var` and `auto` are similar

printing is done lie `Console.WriteLine(sumMoreDecimal);`

# Logical Flow

## Switch Statement
1. In C#, the switch expression can be of integral types, enumerated types, **strings**, or nullable types.
2. The **fall through** is not automatic thus break is optional

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





