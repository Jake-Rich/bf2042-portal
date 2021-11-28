namespace BF2042.Scripting
{
    public enum PortalInstruction
    {
        // Math
        AbsNumber,
        Add_Number,
        Add_Vector,
        AngleDifference,
        BackwardsVector,
        CosineFromDegrees,
        CosineFromRadians,
        CreateVector,
        CrossProduct, //
        DirectionFromAngles,
        DirectionTowards,
        DistanceBetween, //
        Divide_Vector,
        Divide_Number,
        DotProduct,
        DownVector,
        ForwardVector,
        LeftVector,
        WorldToLocalPos,
        WorldToLocalVector,
        Min,
        Max,
        Modulo,
        Multiply_Number,
        Multiply_Vector,
        Normalize,
        RaiseToPower,
        RandomReal,
        RightVector,
        RoundToInteger,
        SineFromDegrees,
        SineFromRadians,
        SquareRoot,
        Subtract_Number,
        Subtract_Vector,
        UpVector,
        VectorTowards,
        LocalToWorldPos,
        LocalToWorldVector,
        Vector_GetX, //
        Vector_GetY, // 
        Vector_GetZ, //

        // Literals
        Literal_Number,
        Literal_Bool,
        Literal_String,

        // Event
        EventPlayer,
        EventOtherPlayer,

        // Team
        GetTeamId_Number,
        GetTeamId_Player,

        // Logic
        And,
        Equals,
        GreaterThan,
        GreaterThanEqualTo,
        IfThenElse,
        LessThan,
        LessThanEqualTo,
        Not,
        NotEqualTo,
        Or,

        // Player
        GetPlayerKills,
        GetPlayerDeaths,
        FarthestPlayerFrom,
        ClosestPlayerTo,
        GetAllPlayers,
        GetInventoryAmmo,
        GetInventoryMagazineAmmo,
        GetPlayerState,
        HasInventory,
        IsInventorySlotActive,
        IsPlayerUsingSolider,

        // Arrays
        Array_Append,
        Array_Slice,
        Array_Count, //
        Array_CurrentArrayElement,
        Array_EmptyArray, // EmptyArray
        Array_FilteredArray,
        Array_FirstOf,
        Array_IsTrueForAll,
        Array_IsTrueForAny,
        Array_Last,
        Array_MappedArray,
        Array_RandomizedArray,
        Array_RandomValueInArray,
        Array_SortedArray,
        Array_ValueInArray,
        Array_RemoveFromArray,
        Array_Contains,
        Array_IndexOf,
    }
}
