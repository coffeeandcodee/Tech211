
# WEEK 1


Business week. Week entailed in depth look at Agile methodology and Scrum


Briefly touched over **shells**, and learnt a useful power shell script for
detecting changes and commiting then pushing them if so 

```ps
if (git status --porcelain){
    echo "New changes detecteed. Execute script? (Y or N)"
    $confirm = Read-Host confirm
        if ($confirm -eq "Y"){
            echo "Adding and committing changes..."
            git add -A
            git commit -m "Update"
            git push origin main
            echo "Done. All changes committed and pushed to remote repository."
        } elseif($confirm -eq "N"){
            echo "Aborting script."
        } else {
            echo "Invalid. Please enter Y/r or N/n."
            .\changeCheck.ps1
        }
        else {
            echo "No new changes."
        }
}

```

We learnt markdown although the checkboxes weren't working for me on VSCode

- [ ] I'm hoping this is an unchecked box when I commit this
- [x] I'm hoping this is checked in


# WEEK 2 


## MONDAY 
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

## TUESDAY 

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

