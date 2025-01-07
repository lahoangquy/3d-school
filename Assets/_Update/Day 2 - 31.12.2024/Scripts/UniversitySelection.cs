using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversitySelection : MonoBehaviour
{
    public string targetObjectName = "ImageVlu1Selection";
    public Transform parentObject;
    public Transform DisableObject;

    public void OnButtonClick()
    {
        if (parentObject == null)
        {
            return;
        }

        if (parentObject.name == targetObjectName){
            parentObject.gameObject.SetActive(true);
            DisableObject.gameObject.SetActive(false);

        }else{
            parentObject.gameObject.SetActive(false);
        }
    }
}
