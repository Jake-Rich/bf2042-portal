using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
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
            context.AddSource( "okthen", SourceText.From( $@"
                    using System;

                    namespace Poop
                    {{
                        public static partial class PoopPoop
                        {{
                            static partial void HelloFrom(string name)
                            {{
                                Console.WriteLine($""Generator says: Hi from '{{name}}'"");
                            }}
                        }}
                    }}
                    " ) );

            foreach( var file in context.AdditionalFiles )
            {
                if ( file.Path.EndsWith( "dump.json" ) )
                {

                }
            }
        }

        public void Initialize( GeneratorInitializationContext context )
        {
            // No initialization required for this one
        }
    }
}
