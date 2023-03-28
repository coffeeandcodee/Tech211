
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
