namespace BF2042.Scripting
{
    public class OnPlayerRevived
    {
        public PlayerValue RevivedPlayer { get { return PlayerValue.EventPlayer.FromActionBlock( RuleEventType.OnRevived ); } }
        public PlayerValue MedicPlayer { get { return PlayerValue.EventOtherPlayer.FromActionBlock( RuleEventType.OnRevived ); } }
    }
}