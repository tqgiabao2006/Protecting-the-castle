using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class killCount : MonoBehaviour
{
    public static killCount instance;
    [SerializeField] TextMeshProUGUI kill;
    [HideInInspector] public int killcount;

    private void Awake()
    {  
        
            instance = this;

       
      
    }
    public void killCounter(){

      
        kill.text = killcount.ToString();

    }
}
