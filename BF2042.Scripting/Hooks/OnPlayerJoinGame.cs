namespace BF2042.Scripting
{
    public class OnPlayerJoinGame : HookContext
    {
        public PlayerValue JoiningPlayer { get { return PlayerValue.EventPlayer; } }
    }
}