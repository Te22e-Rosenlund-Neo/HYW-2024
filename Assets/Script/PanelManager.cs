using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PanelManager : MonoBehaviour
{
    

    public GameObject DefaultPanel;

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
    



}
