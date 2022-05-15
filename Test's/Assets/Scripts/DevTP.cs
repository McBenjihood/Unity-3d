using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevTP : MonoBehaviour
{
    [SerializeField]
    KeyCode keyRestart;

    public Transform Teleporter;
    public Transform Player;

    
    void Update()
    {
        if (Input.GetKey(keyRestart))
            Player.transform.position = Teleporter.transform.position;
             
    }
}
