using BF2042.Scripting;
using System;

namespace BF2042.Script
{
    class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine( "Hello World!" );
        }
    }

    public class JakeVariables : VariableContext
    {
        public PlayerVariable PlayerScore { get; set; }
    }

    public class ExampleScript : PortalScript<JakeVariables>
    {
        public override void Setup()
        {
            SetupHooks();
        }

        private void SetupHooks()
        {
            Conditions.OnPlayerDeath( context =>
            {
                context.AddCondition( x=> x.Killer.rea )
                
            } );

            Hooks.OnPlayerJoinedGame( x =>
            {
                x.JoiningPlayer.Teleport( new VectorValue( 1, 2, 3 ) );

                Variables.PlayerScore.Set( x.JoiningPlayer, new NumberValue( 20 ) );
            } );
        }
    }
}
