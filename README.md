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











