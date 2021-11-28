namespace BF2042.Scripting
{
    public class OnPlayerDeployed
    {
        public PlayerValue DeployingPlayer { get { return PlayerValue.EventPlayer.FromActionBlock( RuleEventType.OnPlayerDeployed ); } }
    }
}