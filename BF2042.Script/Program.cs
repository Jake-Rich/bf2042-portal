using BF2042.Scripting;
using System.IO;

namespace BF2042.Script
{
    class Program
    {
        static void Main( string[] args )
        {
            var script = new ExampleScript();

            File.WriteAllText( "output.xml", script.ToXML() );

            System.Console.WriteLine( "Wrote to file" );
            System.Console.ReadLine();
        }
    }

    public class JakeVariables : VariableContext
    {
        public PlayerVariable PlayerScore { get; set; } = new PlayerVariable();
    }

    public class ExampleScript : PortalScript<JakeVariables>
    {
        public override void Setup( ScriptOptions options )
        {
            options.StrictMode = false;

            ExampleHooks();
        }

        private void ExampleHooks()
        {
            Hooks.OnPlayerJoinedGame( context => new Function()
            {
                // They don't have a state when joining but sure
                // Conditions are also pretty useless compared to if statements, but they are used for "OngoingEvents"
                new Condition( context.JoiningPlayer.IsProne ),

                // Example of setting variables
                //Variables.PlayerScore.Set( context.JoiningPlayer, 20 ),
            } );

            Hooks.OnPlayerSpawned( context => new Function() 
            {
                // Teleport AI players 50 meters up in the air when they join
                new IfTrue( context.DeployingPlayer.IsAI )
                {
                    context.DeployingPlayer.Teleport( context.DeployingPlayer.GetPosition() + new VectorValue( 0, 50, 0 ) )
                },
            } );

            Hooks.OnGameModeStarted( context => new Function()
            {
                context.AllPlayers.RandomValue().Kill(),
                context.GlobalChatMessage( "Hello crazies" ),

                new IfTrue( context.AllPlayers.RandomValue().IsDead )
                {
                    context.AllPlayers.RandomValue().Kill()
                },

                new WhileLoop( context.AllPlayers.RandomValue().IsDead )
                {
                    context.AllPlayers.RandomValue().Kill()
                },

                context.AllPlayers.RandomValue().IsDead.IfTrue( context.GlobalChatMessage( "Random player dead :(" ) ),

                context.AllPlayers.RandomValue().Kill(),
            } );
        }
    }
}
