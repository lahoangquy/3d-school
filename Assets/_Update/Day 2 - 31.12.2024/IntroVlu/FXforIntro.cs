using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class FXforIntro : MonoBehaviour
{
    public RectTransform FX;

    void Update(){
        if (FX.name == "RawImageFXUpper"){
            if (FX.anchoredPosition.y >= 765){
                return;
            }else{
            FX.anchoredPosition += new Vector2(0,100) * Time.deltaTime;
            }
        }else if (FX.name == "RawImageFXLower"){
            if (FX.anchoredPosition.y <= -765){
                return;
            }else{
            FX.anchoredPosition -= new Vector2(0,100) * Time.deltaTime;
            }
        }
    }
}
