// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Analyzer.Utilities;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;

namespace Microsoft.CodeQuality.Analyzers.QualityGuidelines
{
    // TODO: Now that this flags all but the last duplicate initializer, we can offer a code fix to remove the flagged ones.
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public sealed class AvoidDuplicateElementInitialization : DiagnosticAnalyzer
    {
        internal const string RuleId = "CA2244";

        private static readonly LocalizableString s_localizableTitle = new LocalizableResourceString(nameof(MicrosoftCodeQualityAnalyzersResources.AvoidDuplicateElementInitializationTitle), MicrosoftCodeQualityAnalyzersResources.ResourceManager, typeof(MicrosoftCodeQualityAnalyzersResources));
        private static readonly LocalizableString s_localizableMessage = new LocalizableResourceString(nameof(MicrosoftCodeQualityAnalyzersResources.AvoidDuplicateElementInitializationMessage), MicrosoftCodeQualityAnalyzersResources.ResourceManager, typeof(MicrosoftCodeQualityAnalyzersResources));
        private static readonly LocalizableString s_localizableDescription = new LocalizableResourceString(nameof(MicrosoftCodeQualityAnalyzersResources.AvoidDuplicateElementInitializationDescription), MicrosoftCodeQualityAnalyzersResources.ResourceManager, typeof(MicrosoftCodeQualityAnalyzersResources));

        internal static DiagnosticDescriptor Rule = new DiagnosticDescriptor(RuleId,
                                                                             s_localizableTitle,
                                                                             s_localizableMessage,
                                                                             DiagnosticCategory.Usage,
                                                                             DiagnosticHelpers.DefaultDiagnosticSeverity,
                                                                             isEnabledByDefault: true,
                                                                             description: s_localizableDescription,
                                                                             helpLinkUri: null,     // TODO: add MSDN url
                                                                             customTags: WellKnownDiagnosticTags.Telemetry);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => ImmutableArray.Create(Rule);

        public override void Initialize(AnalysisContext analysisContext)
        {
            analysisContext.EnableConcurrentExecution();
            analysisContext.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);

            analysisContext.RegisterOperationAction(AnalyzeOperation, OperationKind.ObjectCreation);
        }

        private static void AnalyzeOperation(OperationAnalysisContext context)
        {
            var objectInitializer = (IObjectCreationOperation)context.Operation;
            if (objectInitializer.Initializer == null ||
                objectInitializer.Initializer.Initializers.Length <= 1)
            {
                return;
            }

            var initializedElementIndexes = new HashSet<ImmutableArray<object>>(ConstantArgumentEqualityComparer.Instance);

            for (int i = objectInitializer.Initializer.Initializers.Length - 1; i >= 0; i--)
            {
                if (objectInitializer.Initializer.Initializers[i] is ISimpleAssignmentOperation assignment &&
                    assignment.Target is IPropertyReferenceOperation propertyReference &&
                    propertyReference.Arguments.Length != 0)
                {
                    var values = GetConstantArgumentValues(propertyReference.Arguments);
                    if (!values.IsEmpty && !initializedElementIndexes.Add(values))
                    {
                        var indexesText = string.Join(", ", values.Select(value => value?.ToString() ?? "null"));
                        context.ReportDiagnostic(
                            Diagnostic.Create(Rule, propertyReference.Syntax.GetLocation(), indexesText));
                    }
                }
            }
        }

        /// <summary>
        /// Gets the argument values in parameter order, filling in defaults if necessary, if all
        /// arguments are constants. Otherwise, returns null.
        /// </summary>
        private static ImmutableArray<object> GetConstantArgumentValues(ImmutableArray<IArgumentOperation> arguments)
        {
            var result = new object[arguments.Length];
            foreach (var argument in arguments)
            {
                var parameter = argument.Parameter;
                if (parameter == null ||
                    parameter.Ordinal >= result.Length ||
                    !argument.Value.ConstantValue.HasValue)
                {
                    return ImmutableArray<object>.Empty;
                }

                result[parameter.Ordinal] = argument.Value.ConstantValue.Value;
            }
            return result.ToImmutableArray();
        }

        private sealed class ConstantArgumentEqualityComparer : IEqualityComparer<ImmutableArray<object>>
        {
            public static readonly ConstantArgumentEqualityComparer Instance = new ConstantArgumentEqualityComparer();

            private readonly EqualityComparer<object> _objectComparer = EqualityComparer<object>.Default;

            private ConstantArgumentEqualityComparer() { }

            bool IEqualityComparer<ImmutableArray<object>>.Equals(ImmutableArray<object> x, ImmutableArray<object> y)
            {
                if (x == y)
                {
                    return true;
                }

                return x != null && y != null && x.SequenceEqual(y, _objectComparer);
            }

            int IEqualityComparer<ImmutableArray<object>>.GetHashCode(ImmutableArray<object> obj)
            {
                int hash = 0;
                if (obj != null)
                {
                    foreach (var item in obj)
                    {
                        hash = unchecked((hash * (int)0xA5555529) + _objectComparer.GetHashCode(item));
                    }
                }
                return hash;
            }
        }
    }
}