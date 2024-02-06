using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IBM.Watson.Assistant.V2;
using IBM.Cloud.SDK.Utilities;
using IBM.Cloud.SDK.Authentication;
using IBM.Cloud.SDK.Authentication.Iam;
using IBM.Cloud.SDK.DataTypes;
using IBM.Cloud.SDK;
using TMPro;
using IBM.Watson.Assistant.V2.Model;
using System;
using NSubstitute;

public class WatsonAssistantChat : MonoBehaviour
{
    [SerializeField]
    private string assistantApiKey = "<Your Assistant API Key>";

    [SerializeField]
    private string assistantInstanceId = "<Your Assistant Instance ID>";

    [SerializeField]
    private string assistantUrl = "<Your Assistant URL>";

    [SerializeField]
    private TMP_InputField inputField;

    [SerializeField]
    private TMP_Text outputText;


    private AssistantService assistant;

    private bool isProcessing = false;
    private string sessionId;

    private void Start()
    {
        Authenticator authenticator = new IamAuthenticator(apikey: assistantApiKey);
        assistant = new AssistantService("2021-06-14", authenticator);
        assistant.SetServiceUrl(assistantUrl);

        GenerateSessionId();

        StartConversation();
        // Optional: You can call a method here to initiate a conversation with Watson Assistant.
    }


    private void GenerateSessionId()
    {
        sessionId = System.Guid.NewGuid().ToString();
        Debug.Log("generated session correctly");
    }

    private void StartConversation(){
        Debug.Log(assistantInstanceId);
        Debug.Log("trying to generate conversation");
        assistant.CreateSession(OnSessionCreated, assistantInstanceId);
        Debug.Log("Started conversation");
    }

    private void OnSessionCreated(DetailedResponse<SessionResponse> response, IBMError error){
        Debug.Log("Onsessioncreated is called");
        if(error != null){
            Debug.LogError($"Failed to create Watson Assistant session: {error.ErrorMessage}");
            return;
        }

        Debug.Log("Watson Assistant session created successfully.");
        // Handle successful session creation, if needed
    }



    public void SendMessageToAssistant()
    {
        if (isProcessing || inputField.text == "")
            return;

        isProcessing = true;

        // Create a message input for Watson Assistant
        MessageInput messageInput = new MessageInput()
        {
            Text = inputField.text
        };
        Debug.Log("Message constructed correctly");

        string jsonMessageInput = JsonUtility.ToJson(messageInput);

        // Call Watson Assistant
        assistant.Message(OnWatsonResponse, assistantInstanceId, sessionId, messageInput);

        // Clear the input field
        inputField.text = "";
    }

    private void OnWatsonResponse(DetailedResponse<MessageResponse> response, IBMError error)
    {
        Debug.Log("gathering response");
        isProcessing = false;

        if (error != null)
        {
            Debug.LogError($"Error: {error.ErrorMessage}");
            return;
        }
        Debug.Log("Display response");

        // Retrieve and display the response from Watson Assistant
        string outputMessage = response.Result.Output.Generic[0].Text;
        outputText.text += "\n" + outputMessage;
    }
}








