using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ColorSwitch : MonoBehaviour
{
    //state true => light mode | state false => dark mode
    private bool _Light = true;

    [Header("Mode Panels")]
    public GameObject LightMode;
    public GameObject DarkMode;

    private Color White = new(255,255,255,255);
    private Color Black = new(0,0,51,255);
    private Color ArticleWhite = new(221,221,221,255);
    private Color ArticleDark = new(51,51,51,255);
    private Color IconWhite = new(204,204,204,255);
    private Color IconDark = new(51,51,51,255);
    private Color TextWhite = new(255,255,255,255);
    private Color TextDark = new(0,0,0,255);

    [Header("Color lists")]
    public List<GameObject> Background = new List<GameObject>();
    public List<GameObject> Articles = new List<GameObject>();
    public List<GameObject> Icons = new List<GameObject>();
    public List<TMP_Text> Texts = new List<TMP_Text>();

    void Awake(){
        colorSwap(true);
    }
   public void ThemeSwitch(){
        _Light = !_Light;
        colorSwap(_Light);
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
