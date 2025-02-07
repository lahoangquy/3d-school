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
            if (parentObject.name == "ImageVlu1Selection"){
                UserSelect.Instance.Uni1 = true; 
                print(UserSelect.Instance.Uni1);
                UserSelect.Instance.Uni2 = false; 
                print(UserSelect.Instance.Uni2);
            }else if (parentObject.name == "ImageVlu2Selection"){
                UserSelect.Instance.Uni1 = false; 
                print(UserSelect.Instance.Uni1);
                UserSelect.Instance.Uni2 = true; 
                print(UserSelect.Instance.Uni2);
            }
        }else{
            parentObject.gameObject.SetActive(false);
        }
    }
}
