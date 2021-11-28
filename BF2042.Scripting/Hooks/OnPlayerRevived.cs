namespace BF2042.Scripting
{
    public class OnPlayerRevived : HookContext
    {
        public PlayerValue RevivedPlayer { get { return PlayerValue.EventPlayer; } }
        public PlayerValue MedicPlayer { get { return PlayerValue.EventOtherPlayer; } }
    }
}