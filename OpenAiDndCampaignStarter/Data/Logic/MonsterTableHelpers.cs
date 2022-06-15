using System.Security.Cryptography;
using OpenAiDndCampaignStarter.Data.Models;
using OpenAiDndCampaignStarter.Data.MonsterTables;

namespace OpenAiDndCampaignStarter.Data.Logic;

public class MonsterTableHelpers
{
    public static DndMonster GetRandom5eMonster()
    {
        var table5eLength = Monsters5e.Monsters.Length;
        
        var randomNumber = RandomNumberGenerator.GetInt32(0, table5eLength - 1);
        
        return Monsters5e.Monsters[randomNumber];
    }
}