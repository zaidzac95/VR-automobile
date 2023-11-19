using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerStatus : MonoBehaviour
{
    public void SaveStatus()
    {
        ES3.Save<int>("wheelIndex", 123);
    }

    public void LoadStatus()
    {
        ES3.Load("wheelIndex", 0);
    }
}
