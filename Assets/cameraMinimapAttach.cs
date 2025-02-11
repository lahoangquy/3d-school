using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMinimapAttach : MonoBehaviour
{
    public Transform PlayerPos;
    public GameObject Camera;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPos = GameObject.FindWithTag("Player").GetComponent<Transform>();
        //Camera.transform.position = new Vector3(PlayerPos.position.x,PlayerPos.position.y,Camera.transform.position.z);
        Camera.transform.SetParent(PlayerPos,true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
