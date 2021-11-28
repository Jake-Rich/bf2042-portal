namespace BF2042.Scripting
{
    public class OnPlayerFullDead
    {
        public PlayerValue DeadPlayer { get { return PlayerValue.EventPlayer.FromActionBlock( RuleEventType.OnPlayerIrreversiblyDead ); } }
    }
}