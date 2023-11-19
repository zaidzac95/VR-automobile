using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMat : MonoBehaviour
{
    public List<GameObject> gameObjects;
    public Material black; 
    public Material yellow;
    public Material green;
    public Material blue;
    public Material red;
    public Material white;
    int colorIndex;


    public void Black()
    {
        colorIndex = 0;
        SetCarMaterial(colorIndex);
    }

    public void Yellow()
    {
        colorIndex = 1;
        SetCarMaterial(colorIndex);
    }

    public void Green()
    {
        colorIndex = 2;
        SetCarMaterial(colorIndex);
    }

    public void Blue()
    {
        colorIndex = 3;
        SetCarMaterial(colorIndex);
    }

    public void Red()
    {
        colorIndex = 4;
        SetCarMaterial(colorIndex);
    }
    
    public void White()
    {
        colorIndex = 5;
        SetCarMaterial(colorIndex);
    }

    private void SetCarMaterial(int index)
    {
        colorIndex = index;
        foreach (GameObject obj in gameObjects)
        {
            Renderer renderer = obj.GetComponent<Renderer>();
            if (colorIndex == 0)
            {
                renderer.material = black;
            }
            if (colorIndex == 1)
            {
                renderer.material = yellow;
            }
            if (colorIndex == 2)
            {
                renderer.material = green;
            }
            if (colorIndex == 3)
            {
                renderer.material = blue;
            }
            if (colorIndex == 4)
            {
                renderer.material = red;
            }
            if (colorIndex == 5)
            {
                renderer.material = white;
            }
        }
        
        //SaveCarColor(colorIndex);
    }

    public void SaveCarColor()
    {
        ES3.Save<int>("Carbody", colorIndex);
        Debug.Log("save" + colorIndex);
    }

    public void LoadCarColor()
    {
        colorIndex = ES3.Load("Carbody", 0);
        SetCarMaterial(colorIndex);
        Debug.Log("load" + colorIndex);
    }
}

