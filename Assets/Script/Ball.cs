using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody rb;
    
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();  //Rigidbodyを取得
        rb.AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);  //AddForce関数で力を加えてボールを動かす
    }
}
