using CODC.Models;
using System.Collections.Generic;
namespace CODC.Working_Files;

public class DataInit
{
    //Standard Metadata
    private string game;
    private string category;
    private string family;
    private string platform;
    private string description;
    
    //The Wall of Lists

    public List<Gun> mw2 = new();
    
    public void Init()
    {
        MW2();
    }
    
    //The Wall of Functions
    private void MW2()
    {
        game = "Modern Warfare 2";
        
        List<string> withCamos = new List<string>
        {
            "M4A1", "FAMAS", "SCAR-H", "TAR-21", "FAL", "M16A4", "ACR", "F2000", "AK-47",
            "MP5K", "UMP45", "Vector", "P90", "Mini-Uzi",
            "L86 LSW", "RPD", "MG4", "AUG HBAR", "M240",
            "Intervention", "Barrett .50cal", "WA2000", "M14 EBR",
            "Riot Shield",
            "PP2000", "G18", "M93 Raffica", "TMP",
            "SPAS-12", "AA-12", "Striker", "Ranger", "M1014", "Model 1887",
            "USP .45", ".44 Magnum", "M9", "Desert Eagle",
            "AT4-HS", "Thumper", "Stinger", "Javelin", "RPG-7"
        };
        
        CamoSet camo = new CamoSet(["Woodland", "Digital", "Urban", "Blue Tiger", "Red Tiger", "Fall"], 
            ["5 Headshots", "15 Headshots", "30 Headshots", "75 Headshots", "150 Headshots", "250 Headshots"], 
            [false, false, false, false, false, false], 
            null, null, null, null, null, null);
        
        for (int i = 0; i < withCamos.Count; i++)
        {
            if (i <= 8)
                category = "Assault Rifles";
            else if (i <= 13)
                category = "Submachine Guns";
            else if (i <= 18)
                category = "Light Machine Guns";
            else if (i <= 22)
                category = "Sniper Rifles";

            family = i switch
            {
                0 => "M4", 1 => "FAMAS", 2 => "SCAR", 3 => "TAR-21", 4 => "FAL", 5 => "M16", 6 => "ACR", 7 => "F2000", 8 => "AK",
                9 => "MP5", 10 => "UMP45", 11 => "Vector", 12 => "P90", 13 => "Uzi",
                14 => "L86 LSW", 15 => "RPD", 16 => "MG4", 17 => "AUG", 18 => "M240",
                19 => "Intervention", 20 => "Barrett .50cal", 21 => "WA2000", 22 => "M14 EBR",
                23 => "Riot Shield",
                24 => "PP2000", 25 => "G18", 26 => "M93 Raffica", 27 => "TMP",
                28 => "SPAS-12", 29 => "AA-12", 30 => "Striker", 31 => "Ranger", 32 => "M1014", 33 => "Model 1887",
                34 => "USP .45", 35 => "Magnum", 36 => "M9", 37 => "Desert Eagle",
                38 => "AT4", 39 => "Thumper", 40 => "Stinger", 41 => "Javelin", 42 => "RPG"
            };

            description = i switch
            {
                0 => "Fully automatic, all purpose weapon. The first assault rifle the user gets upon unlocking loadout creation. Solid all-rounder.",
                1 => "3 round burst. Higher rate of fire, but manual bursts.",
                2 => "Fully automatic, all purpose weapon. Much slower fire rate than standard assault rifles, but with significantly higher damage.",
                3 => "Fully automatic, all purpose weapon. Less accurate, higher damage, and a bit lower fire rate than standard.",
                9 => "Fully automatic, close range. The first submachine gun the user unlocks, standard material.",
                10 => "Fully automatic, close range. Slightly lower fire rate with a bump in damage and accuracy.",
                11 => "Fully automatic, high fire rate. Sprays bullets, but consequently has lower damage.",
                14 => "Fully automatic, large magazines.",
                _ => "No description written."
            };

            mw2.Add(i <= 22
                ? new Gun
                {
                    Name = withCamos[i], Description = description, Category = category, WeaponFamily = family,
                    Game = game, Camos = camo
                }
                : new Gun
                {
                    Name = withCamos[i], Description = description, Category = category, WeaponFamily = family,
                    Game = game
                });
        }
    }
}