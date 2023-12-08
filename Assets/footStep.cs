using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class footStep : MonoBehaviour
{
    [SerializeField] GameObject footstep;
    [SerializeField] GameObject slash;

    void Start()
    {
        footstep.SetActive(false);
        slash.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("w"))
        {
            Stop();
        }
        if (Input.GetKeyUp("a"))
        {
            Stop();
        }
        if (Input.GetKeyUp("d"))
        {
            Stop();

        }
        if (Input.GetKeyUp("s"))
        {
            Stop();
        }

        if (Input.GetKeyDown("w"))
        {
            footSteep();
        }
        if (Input.GetKeyDown("a"))
        {
            footSteep();

        }
        if (Input.GetKeyDown("d"))
        {
            footSteep();
        }
        if (Input.GetKeyDown("s"))
        {
            footSteep();
        }

        if (Input.GetMouseButton(0))
        {
            Slasch();
        }
        if(Input.GetMouseButtonUp(0))
        {
            Unslash();
        }
    }
    
    void Slasch()
    {
        slash.SetActive(true);
    }
    void Unslash() { 
        slash.SetActive(false);
    }
    void footSteep()
    {
        footstep.SetActive(true);
    }
    void Stop()
    {
        footstep.SetActive(false);  
    }
}
