namespace BF2042.Scripting
{
    public class OnPlayerEarnsKill
    {
        public PlayerValue Killer { get { return PlayerValue.EventPlayer.FromActionBlock( RuleEventType.OnPlayerEarnedKill ); } }
        public PlayerValue Victim { get { return PlayerValue.EventOtherPlayer.FromActionBlock( RuleEventType.OnPlayerEarnedKill ); } }
    }
}