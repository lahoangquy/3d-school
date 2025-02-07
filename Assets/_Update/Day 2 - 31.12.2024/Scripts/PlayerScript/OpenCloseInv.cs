using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class OpenCloseInv : MonoBehaviour
{
    public Text OpenClose;
    public RectTransform ButtonOpenClose;

    public GameObject InvPanel;

    public void OnButtonClick(){
        if (OpenClose.text == "Open"){
            OpenClose.text = "Close";
            InvPanel.SetActive(true);
            ButtonOpenClose.anchoredPosition =  new Vector2(537.61f, -517.57f);

        }else if (OpenClose.text == "Close"){
            OpenClose.text = "Open";
            InvPanel.SetActive(false);
            ButtonOpenClose.anchoredPosition = new Vector2(919.2136f, -517.5687f);
        }
    }
}
