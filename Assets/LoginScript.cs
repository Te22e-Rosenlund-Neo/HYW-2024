using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LoginScript : MonoBehaviour
{
    public TMP_InputField UsernameInputfield;
    public TMP_InputField PasswordInputfield;

    string UsernameInput;
    string passwordInput;

    public void TakeInput(bool Create){
        UsernameInput = UsernameInputfield.text;
        passwordInput = PasswordInputfield.text;
        if(Create == true){
            CreateAcount(UsernameInput, passwordInput);
        }else{
            Login(UsernameInput, passwordInput);
        }
    }
    void CreateAcount(string UserName, string PassWord){

        PlayerPrefs.SetString(UserName, PassWord);
        // PlayerPrefs.DeleteAll();
    }
    void Login(string UserName, string PassWord){

        if(PlayerPrefs.GetString(UserName) == PassWord){
            Debug.Log("Logged in!");
        }else{
            Debug.Log("Wrong Password or username");
        }

    }
}
