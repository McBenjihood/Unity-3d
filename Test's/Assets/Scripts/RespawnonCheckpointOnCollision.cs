using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnonCheckpointOnCollision : MonoBehaviour
{


    [SerializeField]
    string strTag;
    public Transform respawnpoint;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag)
        transform.position = respawnpoint.transform.position;

    }
}
