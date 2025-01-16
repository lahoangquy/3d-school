using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseSpawnLocation : MonoBehaviour
{
    public GameObject Player;
    public float x,y,z;
    public void OnButtonClick(){
        Player.transform.position = new Vector3(x,y,z);
    }
}
