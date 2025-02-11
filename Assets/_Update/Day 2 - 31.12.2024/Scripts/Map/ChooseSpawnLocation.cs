using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChooseSpawnLocation : MonoBehaviour
{
    public GameObject Map;
    public GameObject Player;
    public CharacterController EnablePlayerControl;
    public Transform SpawnPos;
    void Awake(){
        Player = GameObject.Find("FemalePlayer") ?? GameObject.Find("MalePlayer");
        EnablePlayerControl = Player.GetComponent<CharacterController>();
    }
    public void OnButtonClick(){
        if (EnablePlayerControl.enabled == false){
            Player.transform.position = new Vector3(SpawnPos.position.x,SpawnPos.position.y,SpawnPos.position.z);
            EnablePlayerControl.enabled = true;
            Debug.Log("teleport to "+ Player.transform.position);   
            Map.SetActive(false); 
        }
    }
}
