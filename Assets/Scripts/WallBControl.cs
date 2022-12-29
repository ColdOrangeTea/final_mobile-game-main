using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBControl : MonoBehaviour
{
    // 這是障礙物(藍)的控制
    // 1藍降下 2黃降下 3清蘭降下 子彈碰到時切換
    // 目標位置
    public GameObject Wall;
    private Vector3 blueUp;
    private Vector3 blueDown;

    public float speed = 20;

    // Start is called before the first frame update
    void Start()
    {
        blueUp = Wall.transform.position;
        blueDown = new Vector3(blueUp.x, -5, blueUp.z);
    }

    void Update()
    {

        // 漸漸移動到目標位置
        if (Color_Switch.color == 1)
        {
            transform.position = Vector3.Lerp(transform.position, blueDown, speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, blueUp, speed * Time.deltaTime);
        }
    }
}
