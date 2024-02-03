using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ColorSwitch : MonoBehaviour
{
    //_LightMode true => light mode | _LightMode false => dark mode
    private bool _LightMode = true;

    [Header("Mode Panels")]
    public GameObject LightMode;
    public GameObject DarkMode;
    private Color White = new(1f,1f,1f,255f);
    private Color Black = new(0f,0f,0.2f,255f);
    private Color ArticleWhite = new(0.86f,0.86f,0.86f,255f);
    private Color ArticleDark = new(0.2f,0.2f,0.2f,255f);
    private Color IconWhite = new(0.8f,0.8f,0.8f,255f);
    private Color IconDark = new(0.2f,0.2f,0.2f,255f);
    private Color TextWhite = new(1,1,1,255f);
    private Color TextDark = new(0f,0f,0f,255f);

    [Header("Color lists")]
    public List<GameObject> Background = new List<GameObject>();
    public List<GameObject> Articles = new List<GameObject>();
    public List<GameObject> Icons = new List<GameObject>();
    public List<TMP_Text> Texts = new List<TMP_Text>();

    void Awake(){
        colorSwap(true);
    }
   public void ThemeSwitch(){
        _LightMode = !_LightMode;
        colorSwap(_LightMode);
   }
   public void colorSwap(bool State){
    //light mode
        if(State == true){
            foreach(GameObject Bg in Background){
                Bg.GetComponent<Image>().color = White;
            }
            foreach(GameObject Article in Articles){
                Article.GetComponent<Image>().color = ArticleWhite;
            }
            foreach(GameObject Icon in Icons){
                Icon.GetComponent<Image>().color = IconWhite;
            }
            foreach(TMP_Text text in Texts){
                text.color = TextDark;
            }
            DarkMode.SetActive(false);
            LightMode.SetActive(true);
        }
    //dark mode
        if(State == false){
            foreach(GameObject obj in Background){
                obj.GetComponent<Image>().color = Black;
            }
            foreach(GameObject Article in Articles){
                Article.GetComponent<Image>().color = ArticleDark;
            }
            foreach(GameObject Icon in Icons){
                Icon.GetComponent<Image>().color = IconDark;
            }
            foreach(TMP_Text text in Texts){
                text.color = TextWhite;
            }
            LightMode.SetActive(false);
            DarkMode.SetActive(true);
        }
   }
}
