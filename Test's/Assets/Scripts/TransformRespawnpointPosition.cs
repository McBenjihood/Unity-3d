using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkCollisionCheckpoint : MonoBehaviour
{
    [SerializeField]
    string strTag;
    public bool checkpointhit;
    
    
	private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag)
        checkpointhit = true;
    }
}

