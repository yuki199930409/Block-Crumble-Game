using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public AudioClip sound;
    public AudioSource audioSource;
    private float time;
    private bool flg;
    public ScoreData Sd;

    public void Retry()
    {
        flg = true;
        audioSource.PlayOneShot(sound);
    }

    void Start()
    {
        time = 0;  //初期値を設定
        flg = false;  //初期値はfalse
    }

    void Update()
    {
        if (flg == true)  //flgがtrueになったら実行される
        {
            time += Time.deltaTime;  //0にTime.deltaTimeを足す
        }

        if (time >= 0.8f)  //timeが0.5秒経ったらGameMainに遷移される
        {
            SceneManager.LoadScene("GameStart");  //スペースキーを押すとゲーム画面に移動
            GameObject Sd = GameObject.Find("ScoreData");
            Destroy(Sd);
        }
    }
}
