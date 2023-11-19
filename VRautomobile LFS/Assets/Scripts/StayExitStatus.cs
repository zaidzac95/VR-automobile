using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayExitStatus : MonoBehaviour
{
    public GameObject carbody;
    public GameObject horn;
    public GameObject lights;
    public GameObject radioBtn;
    public GameObject OffRadio;
    public GameObject engine;
    public GameObject hood;
    public GameObject topCover;
    public GameObject warning;
    public GameObject user;



    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Lock"))
        {
            carbody.SetActive(true);
            horn.SetActive(false);
            lights.SetActive(false);
            radioBtn.SetActive(false);
            OffRadio.SetActive(false);
            engine.SetActive(false);
            hood.SetActive(false);
            topCover.SetActive(false);
            warning.SetActive(false);
            user.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Lock"))
        {
            carbody.SetActive(false);
            horn.SetActive(true);
            lights.SetActive(true);
            radioBtn.SetActive(true);
            engine.SetActive(true);
            hood.SetActive(true);
            topCover.SetActive(true);
            warning.SetActive(true);
            Invoke("changeSize", 3f);
        }
    }

    public void changeSize()
    {
        user.transform.localScale = new Vector3(1.0f, 0.65f, 1.0f);
    }
}
