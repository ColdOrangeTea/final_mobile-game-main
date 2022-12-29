using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{

    void Start()
    {


    }

    void Update()
    {
        if (Enemy.enemyNum == 6)
        {
            SceneManager.LoadScene("Level2");
            Enemy.enemyNum = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Player"))
        {
            SceneManager.LoadScene("End");
        }
    }
}


