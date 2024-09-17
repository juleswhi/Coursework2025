New-Item -ItemType Directory -Force -Path "images" | Out-Null

$files = Get-ChildItem -Path . -Recurse -File |
         Where-Object { $_.Extension -eq '.cs' } |
         Where-Object { $_.Name -notlike '*.Designer.cs' } |
         Where-Object { $_.Name -notlike '*.AssemblyAttributes.cs' } |
         Where-Object { $_.Name -notlike '*.AssemblyInfo.cs' } |
         Where-Object { $_.Name -notlike '*.g.cs' } |
         Select-Object FullName

# Iterate through each file and run the freeze command
foreach ($file in $files) {
    # Assuming freeze is a PowerShell cmdlet or function
    $relativeFilename = Split-Path -Leaf $file.FullName
    freeze $file.FullName -o images/$relativeFilename.svg --theme "gruvbox" --font.family "Jetbrains Mono" --font.size 12 --margin 20,60,20,40
}
