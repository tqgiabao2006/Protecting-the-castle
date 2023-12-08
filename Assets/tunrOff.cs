using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tunrOff : MonoBehaviour
{
    [SerializeField] float time = 0;
    private void Update()
    {
        time += Time.deltaTime;
        if(time > 10 )
        {
            this.gameObject.SetActive( false );
        }

    }
}
