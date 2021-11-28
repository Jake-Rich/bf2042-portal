using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BF2042.Scripting.CodeGen
{
    [Generator]
    public class MySourceGenerator : ISourceGenerator
    {
        public void Execute( GeneratorExecutionContext context )
        {
            
        }

        public void Initialize( GeneratorInitializationContext context )
        {
            // No initialization required for this one
        }
    }
}
