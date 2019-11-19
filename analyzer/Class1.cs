using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace analyzer
{
    // Useful links here
    // https://docs.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/tutorials/how-to-write-csharp-analyzer-code-fix
    // https://roslyn-analyzers.readthedocs.io/en/latest/create-nuget-package.html

    public class MyAnalyzer : DiagnosticAnalyzer
    {
        // Just a dummy here.
        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => throw new NotImplementedException();

        public override void Initialize(AnalysisContext context)
        {
            throw new NotImplementedException();
        }
    }
}
