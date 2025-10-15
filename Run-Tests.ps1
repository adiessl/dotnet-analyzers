$projects = @{
   "NET8"     = "8.0.0"
   "NET9"     = "9.0.0"
   "NET10RC1" = "10.0.100-rc.1.25451.107"
   "NET10RC2" = "10.0.100-rc.2.25502.107"
}

if (Test-Path -Path "./binlogs") {
   Remove-Item -Path "./binlogs" -Recurse -Force
}

foreach ($project in $projects.GetEnumerator()) {
   if (Test-Path -Path "./global.json") {
      Remove-Item -Path "./global.json" -Force
   }

   dotnet new globaljson --sdk-version $project.Value --roll-forward latestFeature

   for ($i = 1; $i -le 3; $i++) {
      Get-ChildItem -Path . -Recurse -Include bin, obj | Remove-Item -Recurse -Force

      dotnet build .\$($project.Key).csproj -bl:.\binlogs\$($project.Key)_$i.binlog
   }
}
