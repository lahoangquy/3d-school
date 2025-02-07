using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForwardButton : MonoBehaviour
{
    public GameObject BackwardButton;
    public GameObject ForwardButton1;
    public GameObject UniversityUI;
    public GameObject DegreeUI;
    public GameObject HouseUI;
    public GameObject TuitionUI;

    //Icon Section

    public Button UniIcon;
    public Button DegreeIcon;
    public Button HouseIcon;
    public Button TuitionIcon;
    public void OnButtonClick()
    {
        if (UniversityUI.activeSelf)
        {
            UniversityUI.SetActive(false);
            DegreeUI.SetActive(true);
            BackwardButton.SetActive(true);
            ForwardButton1.SetActive(true);
            UniIcon.GetComponent<Button>().interactable = false;
            DegreeIcon.GetComponent<Button>().interactable = true;
        }else if (DegreeUI.activeSelf)
        {
            
            DegreeUI.SetActive(false);
            HouseUI.SetActive(true);
            BackwardButton.SetActive(true);
            DegreeIcon.GetComponent<Button>().interactable = false;
            HouseIcon.GetComponent<Button>().interactable = true;
        }else if (HouseUI.activeSelf)
        {
            HouseUI.SetActive(false);
            TuitionUI.SetActive(true);
            BackwardButton.SetActive(true);
            ForwardButton1.SetActive(false);
            HouseIcon.GetComponent<Button>().interactable = false;
            TuitionIcon.GetComponent<Button>().interactable = true;
            
        }else if (TuitionUI.activeSelf){

        }
    } 
    
}
