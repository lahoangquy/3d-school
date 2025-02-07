using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChooseSpawnLocation : MonoBehaviour
{
    public GameObject Map;
    public GameObject Player;
    public CharacterController EnablePlayerControl;
    public float x,y,z;
    void Awake(){
        Player = GameObject.FindWithTag("Player"); //GameObject.Find("FemalePlayer") ?? GameObject.Find("MalePlayer");
        //EnablePlayerControl = Player.GetComponent<CharacterController>();
    }
    public void OnButtonClick(){
        // if (EnablePlayerControl.enabled == false){
             Player.transform.position = new Vector3(x, y, z);
        //     EnablePlayerControl.enabled = true;
        //     Debug.Log("teleport to "+ Player.transform.position);   
             Map.SetActive(false); 
        // }
    }
}
