namespace CODC.Models;

public record Gun
{
    //Standard Information
    //Universal across every Call of Duty game.
    public string Name { get; init; }
    public string Description { get; init; }
    public string Category { get; init; }
    public string WeaponFamily { get; init; }
    public string Game { get; init; }
    public CamoSet Camos { get; init; }
    
    //More Unique Information
    
    //Modern Warfare II Exclusive - Weapon Platforms
    public string WeaponPlatform { get; init; }
    
    //
}