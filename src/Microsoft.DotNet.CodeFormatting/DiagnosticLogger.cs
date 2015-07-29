// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using Microsoft.CodeAnalysis;

namespace Microsoft.DotNet.CodeFormatting
{
    internal sealed class DiagnosticLogger
    {
        internal static void WriteDiagnostic(Diagnostic diagnostic, IFormatLogger formatLogger)
        {
            if (diagnostic == null || formatLogger == null)
            {
                return;
            }
            formatLogger.WriteLine(diagnostic.ToString());
        }

        internal static void WriteDiagnostics(IEnumerable<Diagnostic> diagnostics, IFormatLogger formatLogger)
        {
            if (diagnostics != null && formatLogger != null)
            {
                foreach (Diagnostic diagnostic in diagnostics)
                {
                    WriteDiagnostic(diagnostic, formatLogger);
                }
            }
        }
    }
}
