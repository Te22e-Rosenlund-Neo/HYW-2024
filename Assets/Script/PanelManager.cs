using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PanelManager : MonoBehaviour
{
    

    public GameObject DefaultPanel;
    public bool LoggedIn = false;

    //list that contains all panels
    public List<GameObject> Panels = new();

    void Awake(){
        //makes sure only one panel is visible at launch
        OpenPanel(DefaultPanel);
    }
    
    public void OpenPanel(GameObject PanelID){
//disables all other panels
        foreach(GameObject Panel in Panels){
            Panel.SetActive(false);
        }
//sets designated panel to true
        PanelID.SetActive(!PanelID.activeSelf);
    }

    public void OpenProfile(){
        foreach(GameObject Panel in Panels){
            Panel.SetActive(false);
        }

        if(LoggedIn == false){
            Panels[3].SetActive(true);
        }else if(LoggedIn == true){
            Panels[4].SetActive(true);
        }
    }
    
    public void SettingPanelOpen(GameObject PanelID){
foreach(GameObject Panel in Panels){
            Panel.SetActive(false);
        }
//sets designated panel to true
        PanelID.SetActive(!PanelID.activeSelf);
        DefaultPanel.SetActive(true);

    }
    }
    




