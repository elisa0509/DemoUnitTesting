$ErrorActionPreference = "Stop"

function step($command) {
    write-host ([Environment]::NewLine + $command.ToString().Trim()) -fore CYAN
    & $command
    if ($lastexitcode -ne 0) { throw $lastexitcode }
} 

if (test-path artifacts) { remove-item artifacts -Recurse }

step { dotnet clean Escolar -c Release --nologo -v minimal }
step { dotnet build Escolar -c Release --nologo }
Set-Location -Path Escolar/Escolar.Tests
step { dotnet fixie --configuration Release --no-build } 