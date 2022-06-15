using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using OpenAiDndCampaignStarter.Data.Models;

namespace OpenAiDndCampaignStarter.Data.Logic;

public class OpenAiRequestor : IOpenAiRequestor
{
    private readonly IHttpClientFactory _httpClientFactory;

    public OpenAiRequestor(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<string> GetTextCompletionAsync(string promptString)
    {
        var requestModel = new OpenAiRequest(promptString);

        var jsonRequest = JsonConvert.SerializeObject(requestModel);

        var jsonResponse = await PostHttpMessage("https://api.openai.com/v1/completions", jsonRequest);

        var responseObject = JsonConvert.DeserializeObject<OpenAiResponse>(jsonResponse);

        return responseObject?.choices[0].text ?? "";
    }

    private async Task<string> PostHttpMessage(string url, string jsonMessage)
    {
        var httpClient = _httpClientFactory.CreateClient();
        
        httpClient.DefaultRequestHeaders.Authorization = 
            new AuthenticationHeaderValue("Bearer", Secrets.SECRET_API_KEY);
            
        httpClient.Timeout = TimeSpan.FromSeconds(30);

        var contentString = new StringContent(jsonMessage, Encoding.UTF8, "application/json");
        
        // Initialize the request content and Send the POST
        var response = await httpClient.PostAsync(url, contentString);

        //Check for error status
        response.EnsureSuccessStatusCode();

        //Get the response content
        return await response.Content.ReadAsStringAsync();
    }    
}