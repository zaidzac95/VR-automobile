using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;
using BNG;

public class HandButton : MonoBehaviour
{
	public UnityEvent OnPress = null;
	
	private float yMin = 0.0f;
	private float yMax = 0.0f;
	private bool previousPress = false;
	
	private float previousHandHeight = 0.0f;
    private Grabber hoverInteractor = null;

    List<Grabber> grabbers = new List<Grabber>(); // Grabbers in our trigger
	
	private void Start() {
		SetMinMax();
	}
	
	private void SetMinMax() {
		Collider collider = GetComponent<Collider>();
		yMin = transform.localPosition.y - (collider.bounds.size.y * 0.5f);
		yMax = transform.localPosition.y;
	}
	
	void Update() {
		if (hoverInteractor) {
			float newHandHeight = GetLocalYPosition(hoverInteractor.transform.position);
			float handDifference = previousHandHeight - newHandHeight;
			previousHandHeight = newHandHeight;
			
			float newPosition = transform.localPosition.y - handDifference;
			SetYPosition(newPosition);
			
			CheckPress();
		}
	}

    void OnTriggerEnter(Collider other) {
        Grabber grab = other.GetComponent<Grabber>();
        if (grab != null) {
            hoverInteractor = grab;
            previousHandHeight = GetLocalYPosition(hoverInteractor.transform.position);
        }
    }

    void OnTriggerExit(Collider other) {
        Grabber grab = other.GetComponent<Grabber>();
        if (grab != null) {
            hoverInteractor = null;
            previousHandHeight = 0.0f;

            previousPress = false;
            SetYPosition(yMax);
        }
    }

    private float GetLocalYPosition(Vector3 position) {
		Vector3 localPosition = transform.root.InverseTransformPoint(position);
		return localPosition.y;
	}
	
	private void SetYPosition(float position) {
		Vector3 newPosition = transform.localPosition;
		newPosition.y = Mathf.Clamp(position,yMin,yMax);
		transform.localPosition = newPosition;
	}
	
	private void CheckPress() {
		bool inPosition = InPosition();
		
		if (inPosition && inPosition!=previousPress) {
			OnPress.Invoke();
		}
		
		previousPress = inPosition;
	}
	
	private bool InPosition() {
		float inRange = Mathf.Clamp(transform.localPosition.y, yMin, yMin + 0.1f);
		return transform.localPosition.y == inRange;
	}
}