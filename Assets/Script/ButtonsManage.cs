using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsManage : MonoBehaviour
{
   public void DisablePanel(GameObject Selection){
        Selection.SetActive(!Selection.activeSelf);
   }
}
