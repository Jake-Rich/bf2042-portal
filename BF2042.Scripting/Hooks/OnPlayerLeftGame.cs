namespace BF2042.Scripting
{
    public class OnPlayerLeftGame : HookContext
    {
        public PlayerValue LeftPlayer { get { return PlayerValue.EventPlayer; } }
    }
}