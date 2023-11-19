using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadyCharaStatus : MonoBehaviour
{
    public Transform lady;


    public void SaveLocation(Transform lady)
    {
        ES3.Save<Vector3>("location", lady.position);
    }

    public void LoadLocation(Transform lady)
    {
        lady.position = ES3.Load<Vector3>("location", Vector3.zero);
    }
}
