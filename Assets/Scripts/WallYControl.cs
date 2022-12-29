using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallYControl : MonoBehaviour
{
    // 這是障礙物(藍)的控制
    // 1藍降下 2黃降下 3清蘭降下 子彈碰到時切換
    // 目標位置
    public GameObject Wall;
    private Vector3 yellowUp;
    private Vector3 yellowDown;
    public float speed = 20;

    // Start is called before the first frame update
    void Start()
    {
        yellowUp = Wall.transform.position;
        yellowDown = new Vector3(yellowUp.x, -5, yellowUp.z);
    }

    void Update()
    {

        // 漸漸移動到目標位置
        if (Color_Switch.color == 2)
        {
            transform.position = Vector3.Lerp(transform.position, yellowDown, speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, yellowUp, speed * Time.deltaTime);
        }
    }
}
