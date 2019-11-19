using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;

namespace analyzer
{
    // Useful links here
    // https://docs.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/tutorials/how-to-write-csharp-analyzer-code-fix
    // https://roslyn-analyzers.readthedocs.io/en/latest/create-nuget-package.html

    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class MyAnalyzer : DiagnosticAnalyzer
    {
        // Just a dummy here.
        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } = ImmutableArray.Create(
            new DiagnosticDescriptor("TEST001", "msg", "msg", "TEST", DiagnosticSeverity.Warning, true)
        );

        public override void Initialize(AnalysisContext context)
        {
            context.RegisterSyntaxNodeAction(nodeContext =>
            {
                nodeContext.ReportDiagnostic(Diagnostic.Create(SupportedDiagnostics[0], nodeContext.Node.GetLocation()));
            }, ImmutableArray.Create(SyntaxKind.ClassDeclaration));
        }
    }
}
