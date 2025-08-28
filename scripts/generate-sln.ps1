
# Generate a root solution including all csproj files
$root = Resolve-Path "$PSScriptRoot\.."
Push-Location $root
if(Test-Path CSharpInteractive.sln){ Remove-Item CSharpInteractive.sln }
dotnet new sln -n CSharpInteractive | Out-Null
Get-ChildItem $root -Recurse -Filter *.csproj | ForEach-Object {
  dotnet sln add $_.FullName | Out-Null
}
Pop-Location
Write-Host "Solution generated: CSharpInteractive.sln"
