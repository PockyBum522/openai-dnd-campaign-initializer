// ReSharper disable InconsistentNaming because this is for serialization

using JetBrains.Annotations;

namespace OpenAiDndCampaignStarter.Data.Models;

[PublicAPI]
public class OpenAiJsonRequest
{
    public OpenAiJsonRequest(string promptString)
    {
        prompt = promptString;
    }
    
    public string prompt { get; }
    public string model { get; set; } = "text-davinci-002";
    public double temperature { get; set; } = 0.8;
    public int max_tokens { get; set; } = 240;
    public double top_p { get; set; } = 1.0;
    public double frequency_penalty { get; set; } = 0.5;
    public double presence_penalty { get; set; }
}