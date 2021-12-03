using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClear : MonoBehaviour
{
    private GameObject[] Blocks;
    private float time;
    private bool flg;

    void Start()
    {
        time = 0;
        flg = false; 
    }
    void Update()
    {
        Blocks = GameObject.FindGameObjectsWithTag("Block");  //オブジェクトの中でBlockタグを見つける

        if (Blocks.Length == 0)  //Blockタグが全てなくなったら
        {
            flg = true;

            if (flg == true)  //flgがtrueになったら実行される
            {
                time = time + Time.deltaTime;  //0にTime.deltaTimeを足す

            }

            if (time >= 0.5f)  //timeが0.5秒経ったらGameMainに遷移される
            {
                SceneManager.LoadScene("GameClear");  //スペースキーを押すとゲーム画面に移動
            }
        }
    }
}
