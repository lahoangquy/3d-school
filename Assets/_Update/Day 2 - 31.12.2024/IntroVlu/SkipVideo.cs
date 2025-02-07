using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SkipVideo : MonoBehaviour
{
    public VideoPlayer VluIntro;

    public void OnButtonClick(){
        if (VluIntro.isPrepared)
        {
            VluIntro.time = VluIntro.length - 0.1f;
        }
    }
}
