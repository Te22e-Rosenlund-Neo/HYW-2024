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
public TMP_InputField inputfield;

public GameObject ChatPanel, textObject;

public void GetInput(){
    string text = inputfield.text;
    inputfield.text = "";
    sendMessageToChat(text);
}
public void sendMessageToChat(string text){

if(messagelist.Count >= maxMessages){
    Destroy(messagelist[0].textObject.gameObject);
    messagelist.Remove(messagelist[0]);
}
    Message newmessage  = new Message();

    newmessage.text = text;

   GameObject newtext = Instantiate(textObject, ChatPanel.transform);

    newmessage.textObject = newtext.GetComponent<TMP_Text>();
    newmessage.textObject.text = newmessage.text;

   messagelist.Add(newmessage);

    
   


     


}


}
[Serializable]
public class Message{

public string text;
public TMP_Text textObject;

}


