using System;
using System.Collections.Generic;

namespace BF2042.Scripting
{
    public partial class HookContext
    {
        public Helper Helper { get; } = new Helper();

        public void AddCondition( BoolValue condition )
        {

        }

        public void AddCallback( params ActionValue[] callbacks )
        {
            // TODO: Add to recorder
        }

        public void AddWhile( ActionValue action, BoolValue condition )
        {

        }
    }
}