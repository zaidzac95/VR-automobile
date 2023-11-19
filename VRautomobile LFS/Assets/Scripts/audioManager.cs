using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    //public AudioSource mataColor;
    public AudioSource radio;
    public GameObject radioTxt;
    public AudioSource horn;
    public GameObject hornTxt;
    public AudioSource elight;
    public GameObject elightTxt;
    public AudioSource Tune;
    public GameObject differentMata;
    
    public void ChangeMata()
    {
        //mataColor.Play();
        differentMata.SetActive(true);
    }

    public void RadioInst()
    {
        radio.Play();
        radioTxt.SetActive(false);
        Invoke("OnRadioTxt", 6f);
    }

    public void HornInst()
    {
        horn.Play();
        hornTxt.SetActive(false);
        Invoke("OnHornTxt", 8f);
    }

    public void LightInst()
    {
        elight.Play();
        elightTxt.SetActive(false);
        Invoke("OnLightTxt", 6f);
    }

    public void OnRadioTxt()
    {
        radioTxt.SetActive(true);
        Tune.Play();
    }

    public void OnHornTxt()
    {
        hornTxt.SetActive(true);
    }

    public void OnLightTxt()
    {
        elightTxt.SetActive(true);
    }
}
