namespace BF2042.Scripting
{
    public interface IOnPlayerDied
    {
        PlayerValue Victim { get; }
        PlayerValue Killer { get; }
    }

    public class OnPlayerDied : IOnPlayerDied
    {
        public PlayerValue Victim { get { return PlayerValue.EventPlayer.FromActionBlock( RuleEventType.OnPlayerDied ); } }
        public PlayerValue Killer { get { return PlayerValue.EventOtherPlayer.FromActionBlock( RuleEventType.OnPlayerDied ); } }
    }

    public class OnPlayerDiedCondition : IOnPlayerDied
    {
        public PlayerValue Victim { get; }
        public PlayerValue Killer { get; }
    }
}