using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attract : MonoBehaviour
{
    //スタートと終わりの目印
    public Transform startMarker;
    public Transform endMarker;

    // スピード
    public float speed = 1.0F;

    //二点間の距離を入れる
    private float distance_two;

    void Start()
    {
        //二点間の距離を代入(スピード調整に使う)
        distance_two = Vector3.Distance(startMarker.position, endMarker.position);
    }

    void Update()
    {

        // 現在の位置
        float present_Location = (Time.time * speed) / distance_two;

        // オブジェクトの移動
        transform.position = Vector3.Lerp(startMarker.position, endMarker.position, present_Location);
    }
}
