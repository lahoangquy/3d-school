using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoneButton : MonoBehaviour
{
    public void OnButtonClick(){
        if (UserSelect.Instance.Uni1 == true && UserSelect.Instance.Uni2 == false){
            SceneManager.LoadScene("uni1");
        }else if (UserSelect.Instance.Uni2 == true && UserSelect.Instance.Uni1 == false){
            SceneManager.LoadScene("uni2");
        }
    }
}
