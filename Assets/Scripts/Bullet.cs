using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 30f;
    public float atk = 50f;
    private Rigidbody rb;

    // 計時用 time用來計算經過時間 period是時限
    private float time = 0;
    private float period = 3;
    void Start()
    {
        // 往前飛
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }

    void Update()
    {
        time += Time.deltaTime;
        if (time > period)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
            time = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // 如果碰撞到的是子彈
        if (other.tag == "Enemy")
        {
            // 刪除自己
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        if (other.tag == "Wall")
        {
            // 刪除自己
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
