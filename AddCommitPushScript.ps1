if (git status --porcelain){
    echo "New changes detecteed. Execute script? (Y or N)"
    $confirm = Read-Host confirm
        if ($confirm -eq "Y"){
            echo "Adding and committing changes..."
            git add -A
            git commit -m "Update"
            git push origin main
            echo "Done. All changes committed and pushed to remote 
repository."
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
