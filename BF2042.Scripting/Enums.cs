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

    public enum Enum_InventorySlots
    {
        Primary,
        Secondary,
        Specality,
        Gadget,
        Grenade,
        Melee,
    }

    [Name( "Enum_MedGadgetTypes" )]
    public enum Enum_MedGadgetTypes
    {
        MedicalCrate,
        MedKit,
    }

    [EnumSelection( "ResupplyTypesItem", "ResupplyTypes" )]
    public enum Enum_ResupplyTypes
    {

    }

    [EnumSelection( "Enum_SoldierStateNumber", "SoldierStateBool" )]
    public enum PlayerModelType
    {

    }

    [EnumSelection( "PrimaryWeaponsItem", "PrimaryWeaponsAlexandria" )]
    public enum Enum_PrimaryWeapons
    {

    }

    [EnumSelection( "Enum_SoldierStateNumber", "SoldierStateBool" )]
    public enum Enum_SecondaryWeapons
    {
        BF3_Medic_RU,
        BF3_Medic_US,
        BF3_Engineer_RU,
        BF3_Engineer_US,
        BF3_Support_RU,
        BF3_Support_US,
        BF3_Recon_RU,
        BF3_Recon_US,


        BC2_Medic_RU,
        BC2_Medic_US,
        BC2_Engineer_RU,
        BC2_Engineer_US,
        BC2_Support_RU,
        BC2_Support_US,
        BC2_Recon_RU,
        BC2_Recon_US,


        US_1942_Medic,
        US_1942_Support,
        US_1942_Assault,
        US_1942_Scout,
        US_1942_AntiTank,
        UK_1942_Medic,
        UK_1942_Support,
        UK_1942_Assault,
        UK_1942_Scout,
        UK_1942_AntiTank,
        GE_1942_Medic,
        GE_1942_Support,
        GE_1942_Assault,
        GE_1942_Scout,
        GE_1942_AntiTank,
    }

    [EnumSelection( "Enum_SoldierStateNumber", "SoldierStateBool" )]
    public enum SpecialityItem
    {

    }

    [EnumSelection( "OpenGadgetsItem", "OpenGadgetsAlexandria" )]
    public enum Enum_CharacterGadgets
    {

    }

    [EnumSelection( "ThrowablesItem", "ThrowablesAlexandria" )]
    public enum Enum_Throwables
    {

    }

    [EnumSelection( "Enum_SoldierStateNumber", "SoldierStateBool" )]
    public enum Enum_MeleeWeapons
    {

    }

    [EnumSelection( "Enum_SoldierStateNumber", "SoldierStateBool" )]
    public enum Enum_Factions
    {

    }

    [EnumSelection( "RestrictedInputsItem", "RestrictedInputs" )]
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

    [EnumSelection( "SoldierStateNumberItem", "SoldierStateNumber" )]
    internal enum Enum_SoldierStateBool
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

    [EnumSelection( "SoldierStateNumberItem", "SoldierStateNumber" )]
    internal enum Enum_SoldierStateNumber
    {
        Health,
        InventoryAmmoCount,
        MagazineAmmoCount,
        MaxHealth,
        NormalizedHealth,
        Speed,
    }

    [EnumSelection( "SoldierStateVectorItem", "SoldierStateVector" )]
    internal enum Enum_SoldierStateVector
    {
        LinearVelocity,
        Position,
    }


    public class ReplaceInventoryOptions
    {
        public Enum_PrimaryWeapons? Primary;
        public Enum_PrimaryWeapons? Secondary;
        public SpecialityItem? Speciality;
        public Enum_CharacterGadgets? Gadget;
        public Enum_Throwables? Grenade;
        public Enum_MeleeWeapons? Melee;
    }
}
