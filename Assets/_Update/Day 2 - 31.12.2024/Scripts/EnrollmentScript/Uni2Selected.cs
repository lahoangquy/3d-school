using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uni2Selected : MonoBehaviour
{
    public GameObject EnrollmentSelection;
    public GameObject Uni2;
    
    private void OnEnable() {
        EnrollmentSelection.gameObject.SetActive(false);
        Uni2.gameObject.SetActive(true);
    }
}
