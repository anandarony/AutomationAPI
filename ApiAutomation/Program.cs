using RestSharp;

public class Program
{
    static void Main(string[] arg)
    {
        var client = new RestClient("https://api.restful-api.dev/objects?id=3&id=5&id=10");

        var request = new RestRequest();

        request.Method = Method.Get;

        RestResponse response = client.Execute(request);

        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
            Console.WriteLine("API call successful.");
            Console.WriteLine(response.Content);  // Prints response
        }
        else
        {
            Console.WriteLine($"Error: {response.StatusCode} - {response.StatusDescription}");
        }
    }
}