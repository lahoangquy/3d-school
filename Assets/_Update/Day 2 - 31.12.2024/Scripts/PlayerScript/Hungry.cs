using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Hungry : MonoBehaviour
{
    public Image Fill;
    public float HungryTime = 5f;
    float timer = 0f;
    
    void Hunger()
    {
        if (Fill != null)
        {
            Fill.fillAmount = Mathf.Max(0, Fill.fillAmount - 0.05f); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Fill ==null){
            Fill = GameObject.Find("CanvasPlayerInfo").GetComponentInChildren<Image>();
        }
      timer += Time.deltaTime;
      if (timer >= HungryTime)
        {
            timer = 0f;
            Hunger();
        }  
    }
}
