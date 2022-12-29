using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float hp = 100f;
    public static int enemyNum = 0;
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Bullet")
        {

            Bullet bullet = other.GetComponent<Bullet>();
            enemyNum++;
            hp -= bullet.atk;


            if (hp <= 0)
            {
                gameObject.SetActive(false);
                Destroy(gameObject);
            }
        }
    }
    public void QuitButton()
    {
        Debug.Log("結束遊戲");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
