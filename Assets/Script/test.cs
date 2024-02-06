using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IBM.Watson.Assistant.V2.Model;
using System.Collections.Generic;
using System;
using IBM.Watson.Assistant.V2;
using IBM.Cloud.SDK.Utilities;
using IBM.Cloud.SDK.Authentication;
using IBM.Cloud.SDK.Authentication.Iam;
using IBM.Cloud.SDK.DataTypes;
using IBM.Cloud.SDK;
using TMPro;
using IBM.Watson.Assistant.V2.Model;

public class test : MonoBehaviour
{
 public void CreateSession()
        {
            IamAuthenticator authenticator = new IamAuthenticator(
                apikey: "Y3Svoxhw0DTXAU9OlaWE6ABEX-jb5VPkizLUYyljhA1X");

            AssistantService service = new AssistantService("2020-04-01", authenticator);
            service.SetServiceUrl("https://api.eu-de.assistant.watson.cloud.ibm.com/instances/0585783d-2bb4-45dc-bf1a-83590e2791a5");

            var result = service.CreateSession(
                OnSessionCreated,
                assistantId: "47c9e8bb-7de2-48bc-ba75-739c328bcea8"
                );

            Console.WriteLine(result);

            bool sessionId = result;
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
}
