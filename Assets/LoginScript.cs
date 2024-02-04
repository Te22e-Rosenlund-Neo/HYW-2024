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

//takes user input when interacted with. decides if it should create an account of login
    public void TakeInput(bool Create){
        UsernameInput = UsernameInputfield.text;
        passwordInput = PasswordInputfield.text;
        if(Create == true){
            CreateAcount(UsernameInput, passwordInput);
        }else{
            Login(UsernameInput, passwordInput);
        }
    }
    //here we set the password to be a value of the key username. 
    void CreateAcount(string UserName, string PassWord){

        PlayerPrefs.SetString(UserName, PassWord);
        // PlayerPrefs.DeleteAll();
    }

    //we check if the usernames(key) value is the same as the password that was put in
    void Login(string AccUserName, string InputPassWord){

        if(PlayerPrefs.GetString(AccUserName) == InputPassWord){
            Debug.Log("Logged in!");
        }else{
            Debug.Log("Wrong Password or username");
        }

    }
}
