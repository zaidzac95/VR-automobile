using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayExitStatus1 : MonoBehaviour
{
    public GameObject carbody;
    
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Lock"))
        {
           carbody.SetActive(true);
                
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Lock"))
        {
            carbody.SetActive(false);
                        
        }

    }
}
