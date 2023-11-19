using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerStatue : MonoBehaviour
{
    public AudioSource annouce;
    public AudioSource cwheel;
    public GameObject wheelCanvas;
    public AudioSource cCarBody;
    public GameObject CarMataCanvas;
    public AudioSource inner;
    public AudioSource exit;
    public GameObject CrCanvas;
    public GameObject wholeCarCanvas;
    //public GameObject user;

    bool isPlay = false;
    bool isInner = false;
    bool isexit = false;

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Intro":
                Intro();
                break;
            case "Interior":
                InternalVeh();
                break;
            case "CarCanvas":
                LoadCarCanvas();
                break;
            case "Reset":
                OnReset();
                break;
            default:
                break;
        }
    }

    public void Intro()
    {
        if (!isPlay)
        {
            annouce.Play();
            isPlay = true;
            isexit = false;
            Invoke("ChangeWheel", 15f);
        }
    }

    public void ChangeWheel()
    {
        cwheel.Play();
        wheelCanvas.SetActive(true);
        Invoke("ChangeCarBody", 20f);
    }

    public void ChangeCarBody()
    {
        cCarBody.Play();
        CarMataCanvas.SetActive(true);
    }

    public void InternalVeh()
    {
        if (!isInner)
        {
            inner.Play();
            isInner = true;
            CarMataCanvas.SetActive(false);
            wheelCanvas.SetActive(false);
            wholeCarCanvas.SetActive(false);
        }
    }

    public void LoadCarCanvas()
    {
        CrCanvas.SetActive(true);
    }

    public void OnReset()
    {
        if (!isexit)
        {
            exit.Play();
            isexit = true;
            isPlay = false;
            isInner = false;
        }
    }
}
