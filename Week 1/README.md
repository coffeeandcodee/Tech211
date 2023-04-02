# 週 1

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
