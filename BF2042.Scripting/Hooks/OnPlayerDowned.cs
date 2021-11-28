namespace BF2042.Scripting
{
    public class OnPlayerDowned
    {
        public PlayerValue DownedPlayer { get { return PlayerValue.EventPlayer.FromActionBlock( RuleEventType.OnMandown ); ; } }
    }
}