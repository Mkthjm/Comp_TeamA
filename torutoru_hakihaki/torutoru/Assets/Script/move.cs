using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    //スタートと終わりの目印
    public Transform startMarker;
    public Transform endMarker;

    // スピード
    public float speed = 1.0F;

    //二点間の距離を入れる
    private float distance_two;


    //フラグ用
    public static bool InArea;

    void Start()
    {

    }


    void Update()
    {

        if (endMarker != null)      //終点が入って無ければ動かない
        {

            // 現在の位置
            float present_Location = (Time.time * speed) / distance_two;
             if (present_Location < 0.6f)
            {
                // オブジェクトの移動
                transform.position = Vector3.Lerp(startMarker.position, endMarker.position, present_Location);
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "test")
        {
            //竜巻の範囲内に入ったら終点を自動的に入れる
            endMarker = other.gameObject.GetComponent<Transform>();

            //二点間の距離を代入(スピード調整に使う)
            distance_two = Vector3.Distance(startMarker.position, endMarker.position);

            InArea = true;
        }

        if(other.gameObject.tag == "Player")
        {
            GetComponent<SphereCollider>().enabled = false;
            this.enabled = false;
        }
    }


    void OnTriggerExit(Collider other)
    {
         if(other.gameObject.tag == "test")
        {
            endMarker = null;
            this.enabled = true;
            InArea = false;
        }
    }
}
