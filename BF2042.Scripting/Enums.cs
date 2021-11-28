using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BF2042.Scripting
{
    public enum ActionBlockType
    {
        // Player

        EnableAllInputRestrictions,
        EnableInputRestriction,
        ReplacePlayerInventory,
        ForceSwitchInventory,
        SetInventoryAmmo,
        SetInventoryMagazineAmmo,
        ApplyMedGadget,
        ForceMandown,
        ForceRevive,
        Resupply,
        Heal,
        DealDamage,
        SetPlayerSoldier,
        SetPlayerMaxHealth,
        SkipMandown,
        Teleport,
        Kill,

        // Chat

        DisplayCustomMessage,
    }

    public enum RuleEventType
    {
        Ongoing,
        OnGameModeEnding,
        OnGameModeStarted,
        OnMandown,
        OnPlayerDeployed,
        OnPlayerDied,
        OnPlayerEarnedKill,
        OnPlayerIrreversiblyDead,
        OnPlayerJoinGame,
        OnPlayerLeaveGame,
        OnRevived,
        OnTimeLimitReached,
    }

    public enum InventorySlot
    {
        Primary,
        Secondary,
        Specality,
        Gadget,
        Grenade,
        Melee,
    }

    public enum MedGadgetTypes
    {
        MedicalCrate,
        MedKit,
    }

    public enum ResupplyGadgetType
    {

    }

    public enum SoldierModel
    {

    }

    public enum PrimaryWeapon
    {

    }

    public enum SecondaryWeapon
    {

    }

    public enum SpecialityItem
    {

    }

    public enum GadgetItem
    {

    }

    public enum GrenadeItem
    {

    }

    public enum MeleeItem
    {

    }

    public enum InputRestrictions
    {
        CameraPitch,
        CameraYaw,
        Crouch,
        CycleAbilityUp,
        CycleAbilityDown,
        FireMode,
        CyclePrimary,
        CycleSecondary,
        Fire,
        Interact,
        Jump,
        MoveForwardBack,
        MoveLeftRight,
        Prone,
        Reload,
        SelectSlot3,
        SelectMelee,
        SelectGadget,
        SelectPrimary,
        SelectSecondary,
        SelectGrenade,
        Sprint,
        Zoom,
    }

    internal enum PlayerValue_Bool
    {
        IsAI,
        IsAlive,
        IsBeingRevived,
        IsCrouching,
        IsDead,
        IsFiring,
        IsInAir,
        IsInteracting,
        IsInVehicle,
        IsInWater,
        IsJumping,
        IsDowned,
        IsOnGround,
        IsParachuting,
        IsProne,
        IsReloading,
        IsReviving,
        IsSprinting,
        IsStanding,
        IsVaulting,
        IsZoomingIn,
    }

    internal enum PlayerValue_Number
    {
        Health,
        InventoryAmmoCount,
        MagazineAmmoCount,
        MaxHealth,
        NormalizedHealth,
        Speed,
    }

    internal enum PlayerValue_Vector
    {
        LinearVelocity,
        Position,
    }


    public class ReplaceInventoryOptions
    {
        public PrimaryWeapon? Primary;
        public PrimaryWeapon? Secondary;
        public SpecialityItem? Speciality;
        public GadgetItem? Gadget;
        public GrenadeItem? Grenade;
        public MeleeItem? Melee;
    }
}
