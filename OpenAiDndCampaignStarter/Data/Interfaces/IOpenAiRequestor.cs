namespace OpenAiDndCampaignStarter.Data.Logic;

public interface IOpenAiRequestor
{
    Task<string> GetTextCompletionAsync(string promptString);
}