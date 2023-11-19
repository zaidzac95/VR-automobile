using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelScript : MonoBehaviour
{
    
    public GameObject[] wheelPrefabs;

    
    private int currentWheelIndex;
    private GameObject currentWheel;

   
    void Start()
    {
        currentWheelIndex = 0;
        currentWheel = Instantiate(wheelPrefabs[currentWheelIndex], transform.position, transform.rotation);
    }
        
    public void ChangeWheel()
    {
        Destroy(currentWheel);
        currentWheelIndex++;
        if (currentWheelIndex >= wheelPrefabs.Length)
        {
            currentWheelIndex = 0;
        }

        SetWheel(currentWheelIndex);
    }

    private void SetWheel(int index)
    {
        //Destroy(currentWheel);
        currentWheelIndex = index;
        currentWheel = Instantiate(wheelPrefabs[currentWheelIndex], transform.position, transform.rotation);
        //SaveWheel(currentWheelIndex);
        
    }

    public void SaveWheel()
    {
        ES3.Save<int>("carWheel", currentWheelIndex);
        //Debug.Log("save" + currentWheelIndex);
    }

    public void LoadWheel()
    {
        currentWheelIndex = ES3.Load<int>("carWheel", 0);
        SetWheel(currentWheelIndex);
        //Debug.Log("load" + currentWheelIndex);
    }
}
