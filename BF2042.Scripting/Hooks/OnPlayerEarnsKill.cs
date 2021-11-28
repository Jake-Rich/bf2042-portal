namespace BF2042.Scripting
{
    public class OnPlayerEarnsKill : HookContext
    {
        public PlayerValue Killer { get { return PlayerValue.EventPlayer; } }
        public PlayerValue Victim { get { return PlayerValue.EventOtherPlayer; } }
    }
}