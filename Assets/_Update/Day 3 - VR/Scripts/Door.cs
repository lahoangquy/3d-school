using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Door : XRGrabInteractable
{
    public float openAngle = 90f; // Maximum rotation angle
    public float rotationSpeed = 5f; // Speed of rotation
    private float initialAngle;
    private bool isGrabbed = false;

    protected override void Awake()
    {
        base.Awake();
        initialAngle = transform.localEulerAngles.y;
    }

    protected override void OnSelectEntering(SelectEnterEventArgs interactor)
    {
        base.OnSelectEntering(interactor);
        isGrabbed = true;
    }

    protected override void OnSelectExiting(SelectExitEventArgs interactor)
    {
        base.OnSelectExiting(interactor);
        isGrabbed = false;
    }

    void Update()
    {
        if (isGrabbed)
        {
            float newAngle = Mathf.Clamp(transform.localEulerAngles.y, initialAngle, initialAngle + openAngle);
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, newAngle, transform.localEulerAngles.z);
        }
    }
}
