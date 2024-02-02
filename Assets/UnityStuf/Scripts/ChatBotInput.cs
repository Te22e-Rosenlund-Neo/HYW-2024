using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.Windows;

public class ChatBotInput : MonoBehaviour
{
    string UserInput;
    string Response;
    public TMP_InputField InputField;
    public Canvas canvas;
    GameObject Panel;
    void Update(){
        
    }

    public void Send(){
        UserInput = InputField.text;
        Debug.Log(UserInput);
    }
    public void Reset(){
        InputField.text = "";
    }
    public void disable(){
        canvas.enabled = false;
    }
 
}
