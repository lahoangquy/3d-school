using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseDetails : MonoBehaviour
{
    public string targetObjectName = "ContentArc";
    public Transform parentObject;

    public void OnButtonClick()
    {
        if (parentObject == null)
        {
            return;
        }

        foreach (Transform child in parentObject)
        {
            if (child.name == targetObjectName)
            {
                child.gameObject.SetActive(true);
            }
            else
            {
                child.gameObject.SetActive(false);
            }
        }
    }
}
