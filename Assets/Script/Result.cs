using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    private GameObject ScoreMaster;
    private ScoreData Sd;
    public Text tx;  //紐づけるテキストを格納
    private int Score;

    void Start()
    {
        ScoreMaster = GameObject.Find("ScoreData");  //DontDestroyOnLoadで保持しているScoreDataを見つける
        Sd = ScoreMaster.GetComponent<ScoreData>();  //ScoreMasterの中のScoreDataをコンポーネントする

        Score = Sd.GetScore();  //ScoreDataの中野GetDcore関数を呼び出す
        tx.text = string.Format("Score  {0}", Score);  //Scoreでシーンにスコア表示
    }
}
