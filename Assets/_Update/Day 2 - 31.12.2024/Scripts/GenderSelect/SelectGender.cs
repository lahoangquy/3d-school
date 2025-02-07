using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectGender : MonoBehaviour
{
    public GameObject GenderSelect;
    public GameObject MaleOutline,FemaleOutline;


    public void OnButtonClick(){
        if (GenderSelect.name == "MaleSelect"){
            print("male");
            UserSelect.Instance.Male = true;
            UserSelect.Instance.Female = false;
            MaleOutline.SetActive(true);
            FemaleOutline.SetActive(false);
        } else if (GenderSelect.name == "FemaleSelect"){
            print("female");
            UserSelect.Instance.Male = false;
            UserSelect.Instance.Female = true;
            MaleOutline.SetActive(false);
            FemaleOutline.SetActive(true);
        }
    }
}
