using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMatScript : MonoBehaviour
{
    public List<Material> materials;
    public List<GameObject> gameObjects;
    private int currentMaterialIndex = 0;

    public void CycleMaterialsOnClick()
    {
        foreach (GameObject go in gameObjects)
        {
            Renderer renderer = go.GetComponent<Renderer>();

            renderer.material = materials[currentMaterialIndex];
        }

        currentMaterialIndex = (currentMaterialIndex + 1) % materials.Count;
    }
}
