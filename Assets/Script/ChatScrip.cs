using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChatScrip : MonoBehaviour
{

public int maxMessages = 15;
public List<Message> messagelist = new();

public GameObject ChatPanel, textObject;

public void GetInput(TMP_InputField inputfield){
    sendMessageToChat(inputfield.text);
    inputfield.text = "";
}
public void sendMessageToChat(string text){

if(messagelist.Count >= maxMessages){
    Destroy(messagelist[0].textObject.gameObject);
    messagelist.Remove(messagelist[0]);
}

    GameObject newtext = Instantiate(textObject, ChatPanel.transform);

     Message newmessage = new Message
        {
            text = text,
            textObject = newtext.GetComponent<Text>()
        };
    newmessage.textObject.text = text;
    messagelist.Add(newmessage);




}


}
[Serializable]
public class Message{

public string text;
public Text textObject;

}
