using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_Switch : MonoBehaviour
{
    // public Material goaledMat;
    // MeshRenderer mr = GetComponent<MeshRenderer>();
    // mr.material = goaledMat;
    // 等同於
    // GetComponent<MeshRenderer>().material = goaledMat;

    public static int color = 0;
    public Material blue;
    public Material yellow;
    public Material cyan;
    void Start()
    {

    }

    void Update()
    {

    }
    // 1藍降下 2黃降下 子彈碰到時切換
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {

            color++;
            if (color == 1 || color == 4)
            {
                MeshRenderer mr = GetComponent<MeshRenderer>();
                mr.material = blue;
                Debug.Log("變藍");
                color = 1;
            }
            else if (color == 2)
            {
                MeshRenderer mr = GetComponent<MeshRenderer>();
                mr.material = yellow;
                Debug.Log("變黃");
            }
            else if (color == 3)
            {
                MeshRenderer mr = GetComponent<MeshRenderer>();
                mr.material = cyan;
                Debug.Log("變清綠色");
            }

        }
    }
}
