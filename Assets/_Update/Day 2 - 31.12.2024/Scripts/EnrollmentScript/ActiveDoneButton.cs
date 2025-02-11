using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveDoneButton : MonoBehaviour
{
    public GameObject Tuition;
    public GameObject DoneButton;
    void Update()
    {
        if (Tuition.activeSelf){
            DoneButton.SetActive(true);
        }else{
            DoneButton.SetActive(false);
        }
    }
}
