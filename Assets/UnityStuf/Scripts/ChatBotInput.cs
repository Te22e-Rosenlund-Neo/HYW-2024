using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;

public class ChatBotInput : MonoBehaviour
{
    string UserInput;
    string Response;
    public TMP_InputField InputField;

    void Update(){
        
    }

    void Input(){
        UserInput = InputField.text;
    }
 
}
