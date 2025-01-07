using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackwardButton : MonoBehaviour
{
    public GameObject BackwardButton1;
    public GameObject UniversityUI;
    public GameObject DegreeUI;
    public GameObject HouseUI;

    public void OnButtonClick()
    {
        if (DegreeUI.activeSelf)
        {
            UniversityUI.SetActive(true);
            BackwardButton1.SetActive(false);
            DegreeUI.SetActive(false);            
        }else if (HouseUI.activeSelf)
        {
            DegreeUI.SetActive(true);
            HouseUI.SetActive(false);
        }
    } 
}
