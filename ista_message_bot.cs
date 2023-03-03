using InstagramApiSharp;
using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;

class Program
{
    static async Task Main(string[] args)
    {
        UserSessionData userSession = new UserSessionData
        {
            UserName = "username",
            Password = "Password"
        };

        var api = InstaApiBuilder.CreateBuilder()
            .SetUser(userSession)
            .Build();

        var loginRequest = await api.LoginAsync();

        if (loginRequest.Succeeded)
        {
            var recipientUsername = "username";
            var messageText = "Hello from InstagramApiSharp!";
            var clientContext = "InstagramApiSharp";

            var recipient = await api.UserProcessor.GetUserAsync(recipientUsername);

            if (recipient.Succeeded && recipient.Value != null)
            {
                var messageResult = await api.MessagingProcessor.SendDirectTextAsync(recipient.Value.Pk.ToString(), messageText, clientContext);

                if (messageResult.Succeeded)
                {
                    Console.WriteLine("Message sent successfully!");
                }
                else
                {
                    Console.WriteLine("Failed to send message: " + messageResult.Info.Message);
                }
            }
            else if (recipient.Succeeded && recipient.Value == null)
            {
                Console.WriteLine($"User '{recipientUsername}' does not exist");
            }
            else
            {
                Console.WriteLine("Failed to get recipient profile: " + recipient.Info.Message);
            }
        }
        else
        {
            Console.WriteLine("Login failed: " + loginRequest.Info.Message);
        }
    }
}
