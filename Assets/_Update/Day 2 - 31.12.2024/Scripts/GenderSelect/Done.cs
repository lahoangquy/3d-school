using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Done : MonoBehaviour
{
    public GameObject GenderSelectGUI;
    public GameObject EnrollmentGUI;

    public void OnButtonClick(){
        GenderSelectGUI.SetActive(false);
        EnrollmentGUI.SetActive(true);
    }
}
