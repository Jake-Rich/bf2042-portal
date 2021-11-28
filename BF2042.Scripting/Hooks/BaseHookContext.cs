using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BF2042.Scripting
{
    public class BaseHookContext<T> where T : VariableContext
    {
        public T Variables { get; }
    }
}
