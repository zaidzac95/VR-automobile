using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookToShow : MonoBehaviour
{
    public Transform rayOriginTransform;
    public GameObject lookBtn;
    public LayerMask layerMk;

    private void Update()
    {
        Ray ray = new Ray(rayOriginTransform.position, rayOriginTransform.forward);
        RaycastHit hitInfo;
        if (Physics.SphereCast(rayOriginTransform.position, 0.01f, rayOriginTransform.forward, out hitInfo, 5,layerMk))
        {
            if (hitInfo.collider.gameObject == this.gameObject) lookBtn.SetActive(true);
            else lookBtn.SetActive(false);
        }
        else lookBtn.SetActive(false);
    }
}
