using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardButton : MonoBehaviour
{
    public GameObject BackwardButton;
    public GameObject UniversityUI;
    public GameObject DegreeUI;
    public GameObject HouseUI;

    public void OnButtonClick()
    {
        if (UniversityUI.activeSelf)
        {
            UniversityUI.SetActive(false);
            DegreeUI.SetActive(true);
            BackwardButton.SetActive(true);
        }else if (DegreeUI.activeSelf)
        {
            
            DegreeUI.SetActive(false);
            HouseUI.SetActive(true);
            BackwardButton.SetActive(true);
        }else if (HouseUI.activeSelf)
        {
            HouseUI.SetActive(true);
            BackwardButton.SetActive(true);
        }
    } 
    
}
