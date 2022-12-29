using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCyanControl : MonoBehaviour
{
    // 這是障礙物(清藍)的控制
    // 1藍降下 2黃降下 3清蘭降下 子彈碰到時切換
    // 目標位置
    public GameObject Wall;
    private Vector3 CyanUp;
    private Vector3 CyanDown;
    public float speed = 20;

    // Start is called before the first frame update
    void Start()
    {
        CyanUp = Wall.transform.position;
        CyanDown = new Vector3(CyanUp.x, -5, CyanUp.z);
    }

    void Update()
    {

        // 漸漸移動到目標位置
        if (Color_Switch.color == 3)
        {
            transform.position = Vector3.Lerp(transform.position, CyanDown, speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, CyanUp, speed * Time.deltaTime);
        }
    }
}
