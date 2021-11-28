namespace BF2042.Scripting
{
    public class OnPlayerDowned : HookContext
    {
        public PlayerValue DownedPlayer { get { return PlayerValue.EventPlayer; } }
    }
}