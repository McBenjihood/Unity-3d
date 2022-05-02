using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableUIAtStartGame : MonoBehaviour
{
    public GameObject gameObj;

    void Start()
    {
        gameObj.SetActive(true);
    }
}
