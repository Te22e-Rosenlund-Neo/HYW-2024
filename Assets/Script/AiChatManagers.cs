using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AiChatManagers : MonoBehaviour
{
    public TMP_InputField input;
    public TMP_Text output;
    string Response1 = "hur långt straff får man för väpnat rån";
    string Response2 = "vad för straff ger stöld";
    public void GatherInput(){
        string text = input.text.ToLower();
        input.text = "";
        output.text = "";
        checkquestion(text);
    }
    public void checkquestion(string text){
        string responsetext;
        if(text == Response1){
             responsetext = "Straffet för grovt väpnat rån är 4-10års fängelse";
        }else if(text == Response2){
             responsetext =  "snatteri kan ge böter eller upp till 6månaders fängelse medans stöld kan ge upp till fängelse på två år"; 
        }else{
             responsetext = "could not be found in database";
        }
    output.text = responsetext;
    }
}
