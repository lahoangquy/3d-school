using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class DisableVideo : MonoBehaviour
{
    public VideoPlayer VluIntro;
    public GameObject CanvasVluIntro;
    public GameObject CanvasInfoSelection;
    public GameObject PlayerInv;
    //public GameObject PlayerHungerBar;

    void Start(){
        if (VluIntro != null){
            VluIntro.loopPointReached += OnIntroEnded;
        }
    }

    void OnIntroEnded(VideoPlayer Vlu){
        VluIntro.gameObject.SetActive(false);
        CanvasVluIntro.gameObject.SetActive(false);
        CanvasInfoSelection.gameObject.SetActive(true);
        PlayerInv.gameObject.SetActive(true);
        //PlayerHungerBar.gameObject.SetActive(true);
    }
}
