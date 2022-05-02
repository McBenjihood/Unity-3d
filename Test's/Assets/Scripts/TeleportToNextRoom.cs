using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TeleportToNextRoom : MonoBehaviour
{
    
    [SerializeField]
    string strTag;
    public Transform TowerInsideBottom;
  

	private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag)
            transform.position = TowerInsideBottom.transform.position;
            Debug.Log ("TELEPORTED");    
    }

    
}