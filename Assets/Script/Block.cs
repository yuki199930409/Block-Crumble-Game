using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public SystemMain Sm;  //SystemMainと紐づける変数
    private int Status;
    public Audio audio;


    void OnCollisionEnter(Collision collision)
    {
        if (Status == 0)
        {
            Sm.Score += 100;  //SystemMainの中のスコアが100ずつ上がっていく
            audio.Sound(1);
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        Sm = GameObject.Find("SystemMain").GetComponent<SystemMain>();　　//SystemMainオブジェクトを探す
        Status = 0; 
    }
}
