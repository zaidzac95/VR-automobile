using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnOff : MonoBehaviour
{
    public GameObject descript;

   
    public void TurnOnCanvas()
    {
        descript.SetActive(true);
        Invoke("TurnOff", 5f);
    }

    public void TurnOff()
    {
        descript.SetActive(false);
    }
}
