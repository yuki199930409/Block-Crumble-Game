using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreData : MonoBehaviour
{
    public int Score;  //インスペクタから獲得スコアを見れるようにする

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);  //DontDestroyOnLoadでシーン遷移後も引き継げるようにする
        Score = 0; 
    }

    public int GetScore()
    {
        return Score;  //スタート時から保持していたスコアをスコア表示シーンで結果を返す
    }
}
