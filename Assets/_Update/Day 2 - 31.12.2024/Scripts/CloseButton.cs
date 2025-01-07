using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    public GameObject InfoUi;

    public void OnButtonClick()
    {
        if (InfoUi.activeSelf)
        {
            InfoUi.SetActive(false);
        }
    } 
}
