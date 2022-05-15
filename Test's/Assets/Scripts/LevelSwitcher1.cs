using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitcher1 : MonoBehaviour
{

    [SerializeField]
    string strTag;

	private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag)
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("MainMenu");
    }
}