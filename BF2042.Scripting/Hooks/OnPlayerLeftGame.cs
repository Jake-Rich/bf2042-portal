namespace BF2042.Scripting
{
    public class OnPlayerLeftGame
    {
        public PlayerValue LeftPlayer { get { return PlayerValue.EventPlayer.FromActionBlock( RuleEventType.OnPlayerLeaveGame ); } }
    }
}