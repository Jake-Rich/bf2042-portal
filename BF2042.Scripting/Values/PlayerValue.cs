namespace BF2042.Scripting
{
    public class PlayerValue : CommonValue
    {
        public static PlayerValue EventPlayer { get { return new PlayerValue( PortalInstruction.EventPlayer ); } }
        public static PlayerValue EventOtherPlayer { get { return new PlayerValue( PortalInstruction.EventOtherPlayer ); } }

        internal PlayerValue( PortalInstruction instruction, params CommonValue[] values ) : base( instruction, values )
        {

        }

        public TeamValue GetTeam()
        {
            return new TeamValue( PortalInstruction.GetTeamId_Player, this );
        }

        public NumberValue GetKillCount()
        {
            return new NumberValue( PortalInstruction.GetPlayerKills, this );
        }

        public NumberValue GetDeathCount()
        {
            return new NumberValue( PortalInstruction.GetPlayerDeaths, this );
        }

        public NumberValue GetWeaponReserveAmmo( InventorySlot slot )
        {
            return new NumberValue( PortalInstruction.GetInventoryAmmo, this, EnumValue.Create( slot ) );
        }

        public NumberValue GetWeaponMagazineAmmo( InventorySlot slot )
        {
            return new NumberValue( PortalInstruction.GetInventoryMagazineAmmo, this, EnumValue.Create( slot ) );
        }

        public ActionValue ApplyMedGadget( MedGadgetTypes type )
        {
            return new ActionValue( ActionBlockType.ApplyMedGadget, this, EnumValue.Create( type ) );
        }

        public ActionValue Down()
        {
            return new ActionValue( ActionBlockType.ForceMandown, this );
        }

        [Action]
        public ActionValue Revive()
        {
            return new ActionValue( ActionBlockType.ForceRevive, this );
        }

        [Action]
        public ActionValue SetActiveSlot( InventorySlot slot )
        {
            return new  ActionValue( ActionBlockType.ForceSwitchInventory, this, EnumValue.Create( slot ) );
        }

        [Action]
        public ActionValue SetAllInputRestrictions( BoolValue enabled )
        {
            return new ActionValue( ActionBlockType.ForceSwitchInventory, this, enabled );
        }

        [Action]
        public ActionValue SetInputRestriction( InputRestrictions restriction, BoolValue state )
        {
            return new ActionValue( ActionBlockType.EnableInputRestriction, this, state );
        }

        [Action]
        public ActionValue Resupply( ResupplyGadgetType type )
        {
            return new ActionValue( ActionBlockType.Resupply, this, EnumValue.Create( type ) );
        }

        [Action]
        public ActionValue Heal( NumberValue amount, PlayerValue sourcePlayer = null )
        {
            return new ActionValue( ActionBlockType.Heal, this, amount, sourcePlayer );
        }

        [Action]
        public ActionValue DealDamage( NumberValue amount, PlayerValue source = null )
        {
            return new ActionValue( ActionBlockType.DealDamage, this, amount, source );
        }

        public ActionValue Kill()
        {
            return new ActionValue( ActionBlockType.Kill, this );
        }

        [Action]
        public ActionValue SetSoldierModel( SoldierModel model )
        {
            return new ActionValue( ActionBlockType.SetPlayerSoldier, this, EnumValue.Create( model ) );
        }

        [Action]
        public ActionValue SetMaxHealth( NumberValue amount )
        {
            return new ActionValue( ActionBlockType.SetPlayerMaxHealth, this, amount );
        }

        [Action]
        public ActionValue SetCanBeWounded( BoolValue state )
        {
            return new ActionValue( ActionBlockType.ForceMandown, this, state );
        }

        [Action]
        public ActionValue Teleport( VectorValue position, NumberValue rotation = null )
        {
            // Check if position null for just rotation
            return new ActionValue( ActionBlockType.Teleport, this, position, rotation );
        }

        [Action]
        public ActionValue SetRotation( NumberValue rotation )
        {
            return Teleport( null, rotation );
        }

        [Action]
        public ActionValue ReplaceInventory( ReplaceInventoryOptions options )
        {
            return new ActionValue( ActionBlockType.ReplacePlayerInventory,
                EnumValue.CreateNullable( options.Primary ),
                EnumValue.CreateNullable( options.Secondary ),
                EnumValue.CreateNullable( options.Speciality ),
                EnumValue.CreateNullable( options.Gadget ),
                EnumValue.CreateNullable( options.Grenade ),
                EnumValue.CreateNullable( options.Melee )
                );
        }

        [Action]
        public ActionValue SetReserveAmmoCount( InventorySlot slot, NumberValue amount )
        {
            return new ActionValue( ActionBlockType.SetInventoryAmmo, this, EnumValue.Create( slot ), amount );
        }

        [Action]
        public ActionValue SetMagazineAmmoCount( InventorySlot slot, NumberValue amount )
        {
            return new ActionValue( ActionBlockType.SetInventoryMagazineAmmo, this, EnumValue.Create( slot ), amount );
        }

        #region Number Values

        private NumberValue GetPlayerState_Number( PlayerValue_Number num )
        {
            return new NumberValue( PortalInstruction.GetPlayerState, this, EnumValue.Create( num ) );
        }

        public NumberValue GetHealth()
        {
            return GetPlayerState_Number( PlayerValue_Number.Health );
        }

        public NumberValue GetMaxHealth()
        {
            return GetPlayerState_Number( PlayerValue_Number.MaxHealth );
        }

        public NumberValue GetNormalizedHealth()
        {
            return GetPlayerState_Number( PlayerValue_Number.NormalizedHealth );
        }

        public NumberValue GetActiveWeaponReserveAmmo()
        {
            return GetPlayerState_Number( PlayerValue_Number.InventoryAmmoCount );
        }

        public NumberValue GetActiveWeaponMagazineAmmo()
        {
            return GetPlayerState_Number( PlayerValue_Number.MagazineAmmoCount );
        }

        public NumberValue GetCurrentSpeed()
        {
            return GetPlayerState_Number( PlayerValue_Number.Speed );
        }

        #endregion

        #region Bool Values

        private BoolValue GetPlayerState_Bool( PlayerValue_Bool num )
        {
            return new BoolValue( PortalInstruction.GetPlayerState, this, EnumValue.Create( num ) );
        }

        public BoolValue IsAI { get { return GetPlayerState_Bool( PlayerValue_Bool.IsAI ); } }
        public BoolValue IsAlive { get { return GetPlayerState_Bool( PlayerValue_Bool.IsAlive ); } }
        public BoolValue IsBeingRevived { get { return GetPlayerState_Bool( PlayerValue_Bool.IsBeingRevived ); } }
        public BoolValue IsCrouching { get { return GetPlayerState_Bool( PlayerValue_Bool.IsCrouching ); } }
        public BoolValue IsDead { get { return GetPlayerState_Bool( PlayerValue_Bool.IsDead ); } }
        public BoolValue IsFiring { get { return GetPlayerState_Bool( PlayerValue_Bool.IsFiring ); } }
        public BoolValue IsInAir { get { return GetPlayerState_Bool( PlayerValue_Bool.IsInAir ); } }
        public BoolValue IsInteracting { get { return GetPlayerState_Bool( PlayerValue_Bool.IsInteracting ); } }
        public BoolValue IsInVehicle { get { return GetPlayerState_Bool( PlayerValue_Bool.IsInVehicle ); } }
        public BoolValue IsInWater { get { return GetPlayerState_Bool( PlayerValue_Bool.IsInWater ); } }
        public BoolValue IsJumping { get { return GetPlayerState_Bool( PlayerValue_Bool.IsJumping ); } }
        public BoolValue IsDowned { get { return GetPlayerState_Bool( PlayerValue_Bool.IsDowned ); } }
        public BoolValue IsOnGround { get { return GetPlayerState_Bool( PlayerValue_Bool.IsOnGround ); } }
        public BoolValue IsParachuting { get { return GetPlayerState_Bool( PlayerValue_Bool.IsParachuting ); } }
        public BoolValue IsProne { get { return GetPlayerState_Bool( PlayerValue_Bool.IsProne ); } }
        public BoolValue IsReloading { get { return GetPlayerState_Bool( PlayerValue_Bool.IsReloading ); } }
        public BoolValue IsReviving { get { return GetPlayerState_Bool( PlayerValue_Bool.IsReviving ); } }
        public BoolValue IsSprinting { get { return GetPlayerState_Bool( PlayerValue_Bool.IsSprinting ); } }
        public BoolValue IsStanding { get { return GetPlayerState_Bool( PlayerValue_Bool.IsStanding ); } }
        public BoolValue IsVaulting { get { return GetPlayerState_Bool( PlayerValue_Bool.IsVaulting ); } }
        public BoolValue IsZoomingIn { get { return GetPlayerState_Bool( PlayerValue_Bool.IsZoomingIn ); } }

        #endregion

        #region Vector Values

        private VectorValue GetPlayerState_Vector( PlayerValue_Vector num )
        {
            return new VectorValue( PortalInstruction.GetPlayerState, this, EnumValue.Create( num ) );
        }

        public VectorValue GetLinearVelocity()
        {
            return GetPlayerState_Vector( PlayerValue_Vector.LinearVelocity );
        }

        public VectorValue GetPosition()
        {
            return GetPlayerState_Vector( PlayerValue_Vector.Position );
        }

        #endregion
    }
}