using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseDetails : MonoBehaviour
{
    public string targetObjectName = "ContentArc";
    public Transform parentObject;

    public void OnButtonClick()
    {
        if (parentObject == null)
        {
            return;
        }

        foreach (Transform child in parentObject)
        {
            if (child.name == targetObjectName)
            {
                child.gameObject.SetActive(true);
                //For DegreeGUI
                if (child.name == "ContentArc"){
                    UserSelect.Instance.DArch = true;
                }

                if (child.name == "ContentLaw"){
                    UserSelect.Instance.DLaw = true;
                }

                //For housingGUI
                if (child.name == "UniversityHousing"){
                    UserSelect.Instance.UniversityHousing = true;
                }else{
                    UserSelect.Instance.UniversityHousing = false;
                }
                if (child.name == "OffCampus"){
                    UserSelect.Instance.OffCampus = true;
                }else{
                    UserSelect.Instance.OffCampus = false;
                }
            }
            else
            {
                child.gameObject.SetActive(false);
            }
        }
    }
}
