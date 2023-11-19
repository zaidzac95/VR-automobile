using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatus : MonoBehaviour
{
    public Transform charac;
    

    public void SaveStatus(Transform charac)
    {
        /*PlayerPrefs.SetFloat("x", charac.position.x);
        PlayerPrefs.SetFloat("y", charac.position.y);
        PlayerPrefs.SetFloat("z", charac.position.z);*/
        ES3.Save<Vector3>("location", charac.position);
        
    }

    public void LoadStatus()
    {
        /*float x =PlayerPrefs.GetFloat("x");
        float y =PlayerPrefs.GetFloat("y");
        float z =PlayerPrefs.GetFloat("z");

        charac.position = new Vector3(x, y, z);*/
        charac.position = ES3.Load<Vector3>("location", Vector3.zero);
        
     }
}
