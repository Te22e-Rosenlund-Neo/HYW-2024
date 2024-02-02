 using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AiChatManager : MonoBehaviour
{

  public TMP_InputField _inputfield;
  string _Input;
  string _AIResponse;
  public TMP_Text _outputfield;

  

//converts what the user typed into string
  public void GatherInput(){
    _Input = _inputfield.text;
    Respond(_Input);
  }

//handles the ai response 
    public void Respond(string Input){
        _AIResponse = "Could not find in database, try again!";
        _outputfield.text = _AIResponse;
    }
    
}



