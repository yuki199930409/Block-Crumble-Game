using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public AudioClip sound;
    public AudioSource audioSource;
    private float time;
    private bool flg;

    void Start()
    {
        time = 0; 
        flg = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            flg = true;
            audioSource.PlayOneShot(sound);
        }

        if (flg == true)  //flgがtrueになったら実行される
        {
            time = time + Time.deltaTime;  //0にTime.deltaTimeを足す
            
        }

        if (time >= 0.8f)  //timeが0.5秒経ったらGameMainに遷移される
        {
            SceneManager.LoadScene("GameMain");  //スペースキーを押すとゲーム画面に移動
        }
    }
}
