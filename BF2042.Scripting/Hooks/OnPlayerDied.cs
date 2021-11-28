namespace BF2042.Scripting
{
    public class OnPlayerDied : HookContext
    {
        public PlayerValue Victim { get { return PlayerValue.EventPlayer; } }
        public PlayerValue Killer { get { return PlayerValue.EventOtherPlayer; } }
    }
}