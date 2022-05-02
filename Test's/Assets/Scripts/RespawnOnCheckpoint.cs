using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnOnCheckpoint : MonoBehaviour
{
    [SerializeField]
    KeyCode keyRestart;

    [SerializeField]
    string strTag;
    public Transform respawnpoint;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag)
        respawnpoint.transform.position = transform.position;

    }

    void Update ()
    {
        if (Input.GetKey(keyRestart))
            transform.position = respawnpoint.transform.position;
	}
}
