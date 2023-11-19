using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//require to access SceneManager
using UnityEngine.SceneManagement;

public class LearnChangeScene : MonoBehaviour
{
    public AudioSource startUp;

    void Start()
    {
        Invoke("StartMusic", 2f);
    }

    public void StartMusic()
    {
        startUp.Play();
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }
    
}