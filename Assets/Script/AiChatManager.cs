// using System;
// using System.Threading.Tasks;
// using IBM.Cloud.SDK.Authentication.Iam;
// using IBM.Watson.Assistant.V2;
// using IBM.Watson.Assistant.V2.Model;
// using UnityEngine;
// public class Program
// {

// //  static async Task Main()
// //     {
// //         string apiKey = "YOUR_API_KEY";
// //         string apiUrl = "YOUR_ASSISTANT_API_URL";
// //         string assistantId = "YOUR_ASSISTANT_ID";

// //         // Set up IBM Watson Assistant API
// //         IamAuthenticator authenticator = new IamAuthenticator(apiKey);
// //         AssistantService assistant = new AssistantService("2021-06-14", authenticator);
// //         assistant.SetServiceUrl(apiUrl);

// //         // Function to interact with Watson Assistant
// //         async Task<string> GetWatsonAssistantResponseAsync(string inputText)
// //         {
// //             var messageRequest = new MessageInput()
// //             {
// //                 Text = inputText
// //             };

// //             var response = await assistant.MessageAsync(
// //                 assistantId: assistantId,
// //                 input: messageRequest
// //             );

// //             return response.Output.Generic[0].Text;
// //         }

// //         // Your input and output fields
// //         Console.Write("Enter your message: ");
// //         string tmpInput = Console.ReadLine();  // You can replace this with your input field

// //         // Use async/await to interact with Watson Assistant asynchronously
// //         string tmpText = await GetWatsonAssistantResponseAsync(tmpInput);

// //         Console.WriteLine($"Assistant: {tmpText}");  // You can display or use tmpText as needed
// //     }


    
// }



