using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackwardButton : MonoBehaviour
{
    public GameObject BackwardButton1;
    public GameObject Forwardbutton;
    public GameObject UniversityUI;
    public GameObject DegreeUI;
    public GameObject HouseUI;
    public GameObject Tuition;
    //Icon Section

    public Button UniIcon;
    public Button DegreeIcon;
    public Button HouseIcon;
    public Button TuitionIcon;

    public void OnButtonClick()
    {
        if (UniversityUI.activeSelf){
            Forwardbutton.SetActive(true);
        }else if (DegreeUI.activeSelf)
        {
            UniversityUI.SetActive(true);
            BackwardButton1.SetActive(false);
            DegreeUI.SetActive(false);
            Forwardbutton.SetActive(true);    
            DegreeIcon.GetComponent<Button>().interactable = false;  
            UniIcon.GetComponent<Button>().interactable = true;      
        }else if (HouseUI.activeSelf)
        {
            DegreeUI.SetActive(true);
            HouseUI.SetActive(false);
            HouseIcon.GetComponent<Button>().interactable = false;
            DegreeIcon.GetComponent<Button>().interactable = true;
        }else if (Tuition.activeSelf){
            Tuition.SetActive(false);
            HouseUI.SetActive(true);
            Forwardbutton.SetActive(true);
            HouseIcon.GetComponent<Button>().interactable = true;
            TuitionIcon.GetComponent<Button>().interactable = false; 
        }
    } 
}
