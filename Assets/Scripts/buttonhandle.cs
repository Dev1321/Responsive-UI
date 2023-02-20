using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class buttonhandle : MonoBehaviour
{
    
    public Button play;
    public Button map;
    public Button shop;
    public Button setting;
    public Button skin;
   private void Start()
    {
        play.onClick.AddListener(delegate { Click("Play"); });
        map.onClick.AddListener(delegate { Click("Map"); });
        shop.onClick.AddListener(delegate { Click("Shop"); });
        setting.onClick.AddListener(delegate { Click("Setting"); });
        skin.onClick.AddListener(delegate { Click("Skin"); });
    }

    public void Click(string name)
    {
        Debug.Log(name);
    }

}
