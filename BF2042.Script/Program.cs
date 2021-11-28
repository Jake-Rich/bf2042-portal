using BF2042.Scripting;

namespace BF2042.Script
{
    class Program
    {
        static void Main( string[] args )
        {
            new ExampleScript();
        }
    }

    public class JakeVariables : VariableContext
    {
        public PlayerVariable PlayerScore { get; set; }
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
            Hooks.OnPlayerJoinedGame( context =>
            {
                // They don't have a state when joining but sure
                context.AddCondition( context.JoiningPlayer.IsProne );

                // Example of setting variables
                context.AddCallback( Variables.PlayerScore.Set( context.JoiningPlayer, 20 ) );
            } );

            Hooks.OnPlayerSpawned( context =>
            {
                // Teleport AI players 50 meters up in the air when they join
                context.AddCallback( Logic.IfTrue( context.DeployingPlayer.IsAI, context.DeployingPlayer.Teleport( context.DeployingPlayer.GetPosition() + new VectorValue( 0, 50, 0 ) ) ) );
            } );

            Hooks.OnGameModeStarted( context =>
            {
                context.AllPlayers.RandomValue().Kill();
                context.GlobalChatMessage( "Hello crazies" );

                new IfTrue( context.AllPlayers.RandomValue().IsDead );
                {
                    context.AllPlayers.RandomValue().Kill();
                };

                new WhileLoop( context.AllPlayers.RandomValue().IsDead );
                {
                    context.AllPlayers.RandomValue().Kill();
                }

                context.AllPlayers.RandomValue().IsDead.IfTrue( context.GlobalChatMessage( "Random player dead :(" ) );

                context.AllPlayers.RandomValue().Kill();
            } );

            Hooks.Example( context => new Function()
            {
                context.AllPlayers.First().Kill(),

                new IfTrue( context.AllPlayers.First().IsAlive )
                {
                    context.AllPlayers.Last().Kill(),
                },

                new WhileLoop( context.DeadPlayer.IsInAir )
                {
                    new Wait( 1 ),
                    context.GlobalChatMessage( "Spam every second" ),
                }
            } );
        }
    }
}
