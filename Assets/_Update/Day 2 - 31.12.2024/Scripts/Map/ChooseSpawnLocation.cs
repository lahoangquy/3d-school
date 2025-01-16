using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChooseSpawnLocation : MonoBehaviour
{
    public GameObject Map;
    public Transform Player;
    public CharacterController EnablePlayerControl;
    public float x,y,z;
    void Awake(){
        EnablePlayerControl = Player.GetComponent<CharacterController>();
    }
    public void OnButtonClick(){
        if (EnablePlayerControl.enabled == false){
            Player.position = new Vector3(x, y, z);
            EnablePlayerControl.enabled = true;
            Debug.Log("teleport to "+ Player.position);   
            Map.SetActive(false); 
        }
    }
}
