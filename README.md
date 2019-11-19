This will generate a nupkg which looks like:

```
➜  analyzer git:(master) ✗ unzip -l analyzer/bin/Debug/SampleAnalyzer.1.0.0.nupkg
Archive:  analyzer/bin/Debug/SampleAnalyzer.1.0.0.nupkg
  Length      Date    Time    Name
---------  ---------- -----   ----
      504  11-19-2019 14:20   _rels/.rels
      601  11-19-2019 14:20   SampleAnalyzer.nuspec
     4096  11-19-2019 19:20   analyzers/dotnet/cs/analyzer.dll
      786  11-19-2019 19:20   build/SampleAnalyzer.targets
      525  11-19-2019 14:20   [Content_Types].xml
      643  11-19-2019 14:20   package/services/metadata/core-properties/33759c952e9a4058b805f2737e1d59d8.psmdcp
---------                     -------
     7155                     6 files
```

Referencing this dummy nupkg in a build _should_ automatically add the analyzers to MSBuild, thus we would automatically get MSBuild build integration for the analyzer.

It's not tested, but it is similar to the default template that https://roslyn-analyzers.readthedocs.io/en/latest/create-nuget-package.html.
