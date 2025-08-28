param(
  [string]$Configuration = "Debug",
  [int]$DelayMs = 800,
  [switch]$WinFormsOnly
)
$ErrorActionPreference = "Stop"
$ScriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
$Root = Resolve-Path (Join-Path $ScriptDir "..")
$Images = Join-Path $Root "images"
if (!(Test-Path $Images)) { New-Item -ItemType Directory -Path $Images | Out-Null }
Add-Type -AssemblyName System.Windows.Forms
Add-Type -AssemblyName System.Drawing
function Get-TargetFramework([string]$csprojPath) {
  $m = Select-String -Path $csprojPath -Pattern "<TargetFramework>([^<]+)"
  if ($m) { return $m.Matches[0].Groups[1].Value }
  $isWF = Select-String -Path $csprojPath -Pattern "<UseWindowsForms>\s*true\s*<" -Quiet
  if ($isWF) { return "net8.0-windows" }
  return "net8.0"
}
function Capture-FullScreen([string]$outPath) {
  $bounds = [System.Windows.Forms.Screen]::PrimaryScreen.Bounds
  $bmp = New-Object System.Drawing.Bitmap $bounds.Width, $bounds.Height
  $g = [System.Drawing.Graphics]::FromImage($bmp)
  $g.CopyFromScreen($bounds.Location, [System.Drawing.Point]::Empty, $bounds.Size)
  $bmp.Save($outPath, [System.Drawing.Imaging.ImageFormat]::Png)
  $g.Dispose(); $bmp.Dispose()
}
$sln = Join-Path $Root "CSharpInteractive.sln"
Write-Host "Building..." -ForegroundColor Cyan
if (Test-Path $sln) { dotnet build $sln -c $Configuration | Out-Null }
else { Get-ChildItem $Root -Recurse -Filter *.csproj | ForEach-Object { dotnet build $_.FullName -c $Configuration | Out-Null } }
$projDirs = @()
if (-not $WinFormsOnly) { $projDirs += Get-ChildItem (Join-Path $Root "projects") -Directory -ErrorAction SilentlyContinue }
$projDirs += Get-ChildItem (Join-Path $Root "winforms") -Directory -ErrorAction SilentlyContinue
foreach ($dir in $projDirs) {
  $name = $dir.Name
  $csproj = Get-ChildItem $dir.FullName -Filter *.csproj | Select-Object -First 1
  if (-not $csproj) { continue }
  $tf = Get-TargetFramework $csproj.FullName
  $exe = Join-Path $dir.FullName ("bin\{0}\{1}\{2}.exe" -f $Configuration, $tf, $name)
  if (-not (Test-Path $exe)) { Write-Host ("Skip (no exe): {0}" -f $name) -ForegroundColor DarkGray; continue }
  Write-Host ("Launching {0} ..." -f $name) -ForegroundColor Yellow
  $proc = Start-Process $exe -PassThru -WindowStyle Normal
  try {
    Start-Sleep -Milliseconds $DelayMs
    $out = Join-Path $Images ("{0}.png" -f $name)
    Capture-FullScreen $out
    Write-Host ("  Saved: images\{0}.png" -f $name) -ForegroundColor Green
  } catch {
    Write-Warning ("Failed to capture {0}: {1}" -f $name, $_.Exception.Message)
  } finally {
    if (-not $proc.HasExited) {
      $null = $proc.CloseMainWindow()
      Start-Sleep -Milliseconds 200
      try { $proc.Kill() } catch {}
    }
  }
}
Write-Host ("Done. Screenshots saved to: {0}" -f $Images) -ForegroundColor Cyan
