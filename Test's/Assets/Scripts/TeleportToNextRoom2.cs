using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TeleportToNextRoom2 : MonoBehaviour
{
    
    [SerializeField]
    string strTag;
    public Transform Teleporter;
    public Transform Player;
  

	private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag)
            Player.transform.position = Teleporter.transform.position;
            Debug.Log ("TELEPORTED");    
    }

    
}