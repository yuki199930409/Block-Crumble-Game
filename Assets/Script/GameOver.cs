using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Audio audio;

    void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("GameOver");  //下の壁にぶつかったらゲームオーバーに遷移
    }
}
