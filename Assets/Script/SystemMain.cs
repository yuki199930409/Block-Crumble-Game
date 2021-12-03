using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SystemMain : MonoBehaviour
{
    public int Score;  //現在のスコアをインスペクタに表示
    public Text ScoreText;  //スコアを表示するテキストに紐づける
    public ScoreData Sd;

    void Start()
    {
        Score = 0; 
        Sd = GameObject.Find("ScoreData").GetComponent<ScoreData>();  //ScoreDataを見つけてコンポーネントする
    }

    void Update()
    {
        ScoreText.text = string.Format("{0}", Score);  //Score変数でスコアを画面上に表示する
        Sd.Score = Score;
    }
}
