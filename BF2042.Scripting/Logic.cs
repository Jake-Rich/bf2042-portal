using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BF2042.Scripting
{
    public static class Logic
    {
        public static ActionValue IfTrue( BoolValue state, ActionValue callback )
        {
            // TODO: Gotta figure out if I want to put a logic static class or just jump off the bools (or both?)
            throw new NotImplementedException();
        }

        public static ActionValue IfFalse( BoolValue state, ActionValue callback )
        {
            return IfTrue( state.Invert(), callback );
        }

        // Generic will force equal objects to be compared
        public static ActionValue IfEqual( CommonValue value1, CommonValue value2 )
        {
            // Can't really check types since you could reassign array indexes at runtime
            throw new NotImplementedException();
        }
    }

    // This can do new() with curly brackets to act like a normal function scopes, interesting idea
    public class Function : ActionValue, IEnumerable<ActionValue>
    {
        public Function()
        {

        }

        public Function( ActionValue action )
        {
            Add( action );
        }

        internal List<ActionValue> Actions { get; } = new List<ActionValue>();

        public void Add( ActionValue value )
        {
            Actions.Add( value );
        }

        public IEnumerator<ActionValue> GetEnumerator()
        {
            return Actions.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Actions.GetEnumerator();
        }
    }

    public class Condition : ActionValue
    {
        public Condition( BoolValue value )
        {

        }
    }

    public class IfTrue : Function
    {
        public IfTrue( BoolValue value )
        {

        }
    }

    public class IfFalse : Function
    {
        public IfFalse( BoolValue value )
        {

        }
    }

    public class WhileLoop : Function
    {
        public WhileLoop( BoolValue condition )
        {

        }
    }

    public class Wait : ActionValue
    {
        public Wait( NumberValue time )
        {

        }
    }
}
