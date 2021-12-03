using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Audio audio;

    void Update()
    {
        Transform position = GameObject.Find("Player").transform;  //Playerオブジェクトを見つける
        Vector3 pos = position.position;  //座標を取得

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (pos.x < 3.5)
            {
                transform.Translate(0.1f, 0, 0);  //position.xは3.5より下の範囲だったら右キーで右へ移動
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (pos.x > -3.5)
            {
                transform.Translate(-0.1f, 0, 0);  //position.xは-3.5よし上の範囲だったら左キーで左へ移動
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        audio.Sound(0);
    }
}
