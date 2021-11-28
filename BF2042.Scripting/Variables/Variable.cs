using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BF2042.Scripting
{
    public class Variable
    {
        public UniversalValue Get()
        {
            throw new NotImplementedException();
        }

        public void Set( CommonValue value )
        {
            throw new NotImplementedException();
        }
    }

    public class PlayerVariable
    {
        public UniversalValue Get( PlayerValue player )
        {
            throw new NotImplementedException();
        }

        public UniversalValue Set( PlayerValue player, CommonValue value )
        {
            throw new NotImplementedException();
        }
    }

    public class TeamVariable
    {
        public UniversalValue Get( TeamVariable team )
        {
            throw new NotImplementedException();
        }

        public UniversalValue Set( TeamVariable team, CommonValue value )
        {
            throw new NotImplementedException();
        }
    }
}
