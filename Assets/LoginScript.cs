using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LoginScript : MonoBehaviour
{
    public TMP_InputField UsernameInputfield;
    public TMP_InputField PasswordInputfield;

    string CorrectName = "name";
    string CorrectPassword = "password";

    string UsernameInput;
    string passwordInput;

    public void TakeInput(){
        UsernameInput = UsernameInputfield.text;
        passwordInput = PasswordInputfield.text;
        CheckInput(UsernameInput,passwordInput);
    }
    public void CheckInput(string Username, string password){
        if(Username == CorrectName && password == CorrectPassword){
            Debug.Log("correct!");
        }
    }
}
