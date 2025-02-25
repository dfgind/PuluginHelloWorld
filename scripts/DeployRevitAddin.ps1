# Define Paths
$addinFolder = "$env:APPDATA\Autodesk\Revit\Addins\2024"
$sourceFolder = "$PSScriptRoot\build"  # Adjust this to your build output folder
$addinFile = "MyRevitPlugin.addin"
$dllFile = "MyRevitPlugin.dll"

# Ensure the Add-ins directory exists
if (!(Test-Path $addinFolder)) {
    New-Item -ItemType Directory -Path $addinFolder -Force
}

# Copy the .dll and .addin files
Copy-Item -Path "$sourceFolder\$addinFile" -Destination "$addinFolder\$addinFile" -Force
Copy-Item -Path "$sourceFolder\$dllFile" -Destination "$addinFolder\$dllFile" -Force

Write-Host "Deployment complete. Restart Revit to load the plugin."