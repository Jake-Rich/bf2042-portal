namespace BF2042.Scripting
{
    public class OnPlayerDeployed : HookContext
    {
        public PlayerValue DeployingPlayer { get { return PlayerValue.EventPlayer; } }
    }
}