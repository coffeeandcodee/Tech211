
# Quick Lab navigation
#### :scroll:[LAB1: Unit Tests](./LAB1_UnitTests/LAB1_UnitTests/Program.cs ) :scroll:[LAB2: Operations and control flow](./Week 2/LAB2_OperatorsAndControlFlow/Op_CtrlFlow_Tests/Exercises_Tests.cs)

# MONDAY 27/03
## :exclamation: The coding has begun :exclamation:

Began the week with a brief discussion of what makes languages different, and the contexts they're suitable in. The differences between interpreted (e.g JavaScript, Python, Ruby) and compiled languages (C#, C++, Java).
RIP Fido. 

The evolution of the .NET framework was outlined throughout discussion.

|.NET variation  |Year  | Features|
|------          |----- |---|
|.NET framework  |2002-2014| Platform dependent / Windows only
|.NET Core       |2015-2019| WINDOWS SPECIFIC Cross-compatibility introduced
|.NET            |2020-present| Enhanced cross-compatibility 
 
The latest edition of .NET, (just) .NET, has introduced a greater level of cross-compatibility. Code can now be written for all sorts of purposes including desktop and web apps, cloud, mobile apps, games and AI

Started our first C# "solution" which can be found in the Week 2 folder.

# TUESDAY 28/03

Operators, control flow, and even unit testing via NUnit (:exclamation:). A lot of good stuff covered today, highly immersing. When using && and ||, The operator short-circuiting situations were quite interesting to look at, for example:

``` c#
if (Method1() && Method2())
    {
        Console.WriteLine("Both methods declared below executed");
    }

    bool Method1()
    {
        Console.WriteLine("This method will always execute!");
        Random rand = new Random();
        int oneOrTwo = rand.Next(1, 3);
        bool result = (oneOrTwo == 2) ? true : false;
        return result;
    }
    bool Method2()
    {
        Console.WriteLine("Might execute, it might not ¯_(ツ)_¯");
        return true;
    }

```
Method2 is actually being called in the conditional, as in aside from the value it returns, the actual method and everything it entails will run. This is only given Method1 returns true. If Method1 returns false, then the compiler can conclude the conditional evaluates to false and there is no need to evaluate Method2, hence no shrug face.

# Wednesday 29/03
Today we went over exception handling. 

``` c#
   try
        {
            var text = File.ReadAllText("C://Users//Ahmed//OneDrive//Documents//Sparta Global//Tech211//Week 2//TypesOfErrors.txt");
            Console.WriteLine(text);
        } 
        catch (FileNotFoundException e)
        {
            Console.WriteLine("File not found");
            Console.WriteLine(e.Message);
        }
```
Prime example of a try-catch sequence that can be been in the "ExceptionsApp" solution.

.NET "variation" differences further detailed
First - .NET Framework. Each windows platform used a different set of locally installed libararies (not in the .exe)

Next - .NET core, created the Standard Library which is packaged into the .exe. It's "cross platform" for windows platforms (desktop, mobile, server etc)

Now - .NET, everything is in the Standard library (AI, IoT, etc.) and in the .exe, and cross platform between OS's as well

# Thursday 30/03

Today we had a thorough investigation into data types and the potentially insidious mishaps that can arrive when data manipulation isn't fully understood.
We've heard numerous times that C# is Statically Types, and we learnt exactly what that means. Variables MUST be declared with known type, and variable type cannot be changed

```c#
int n = 10;
var x = n;
//2 - type safe.Type of variable CANNOT be changed
//n = "string"; <---- Won't compile

//C# is MEMORY SAFE
 //Has a garbage collector
 //Types have a fixed memory size. Types cannot be changed, so we know how much memory we'll need
 n = 1000;
//Size of n in memory is still 64  bits
  ```
We also learnt that C# is memory safe, meaning programmers don't need to worry as much about memory related bugs. This differentiates C# from a language
like C++, where memory management is far more relevant.

# Friday 31/03

Had a closer look at methods and method signatures. Learnt that methods can also return tuples. An important distinction for methods that return tuples is that the data returned must be explicitly named

```c#
private static (int weeks, int days) CalculateDaysAndWeeks(int days)
        {
            int noWeeks = days / 7;
            int remainingDays = days % 7;
            return (weeks: noWeeks, days: remainingDays);
        }
```

Methods can also be provided default arguments that can be overwritten. However, default values must be last in the method signature.

```c#
private static int Method(int x, string y = "Default")
        {
            Console.WriteLine(y);
            return x;
        }

```
