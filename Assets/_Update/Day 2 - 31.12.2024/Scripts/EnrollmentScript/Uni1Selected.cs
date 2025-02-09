using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Uni1Selected : MonoBehaviour
{
    public GameObject EnrollmentSelection;
    public GameObject Uni1;
    
    private void OnEnable() {
        EnrollmentSelection.gameObject.SetActive(false);
        Uni1.gameObject.SetActive(true);
    }
}
