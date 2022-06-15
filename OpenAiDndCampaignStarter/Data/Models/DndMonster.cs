using JetBrains.Annotations;

namespace OpenAiDndCampaignStarter.Data.Models;

[PublicAPI]
public class DndMonster
{
    public DndMonster(
        string creatureName, 
        string size, 
        string type, 
        string subType, 
        string lawful, 
        string alignment, 
        int cr, 
        int experience, 
        string biome, 
        string sourceMaterial, 
        int sourcePageNumber,
        string edition)
    {
        CreatureName = creatureName;
        Size = size;
        Type = type;
        SubType = subType;
        Lawful = lawful;
        Alignment = alignment;
        Cr = cr;
        Experience = experience;
        Biome = biome;
        SourceMaterial = sourceMaterial;
        SourcePageNumber = sourcePageNumber;
        Edition = edition;
    }
    
    public string CreatureName { get; }
    public string Size { get; }
    public string Type { get; }
    private string SubType { get; }
    public string Lawful { get; }
    public string Alignment { get; }
    public int Cr { get; }
    public int Experience { get; }
    public string Biome { get; }
    public string SourceMaterial { get; }
    public int SourcePageNumber { get; }
    private string Edition { get; }
}