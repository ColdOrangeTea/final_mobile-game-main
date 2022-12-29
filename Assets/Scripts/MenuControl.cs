using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuControl : MonoBehaviour
{

    public void StartButton()
    {
        Debug.Log("開始遊戲");
        SceneManager.LoadScene("Level1");
        Enemy.enemyNum = 0;
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
    public void ReplayButton()
    {
        Debug.Log("回到標題");
        SceneManager.LoadScene("Start");
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

}
