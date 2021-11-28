namespace BF2042.Scripting
{
    public class OnPlayerFullDead : HookContext
    {
        public PlayerValue DeadPlayer { get { return PlayerValue.EventPlayer; } }
    }
}