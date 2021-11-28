namespace BF2042.Scripting
{
    public class OnPlayerJoinGame
    {
        public PlayerValue JoiningPlayer { get { return PlayerValue.EventPlayer.FromActionBlock( RuleEventType.OnPlayerJoinGame ); } }
    }
}