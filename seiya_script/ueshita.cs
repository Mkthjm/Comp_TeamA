using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ueshita : MonoBehaviour
{
    public float nowPosi;
    private moveobject mv;
    
    void Start()
    {
       nowPosi = this.transform.position.y;
       mv = this.gameObject.GetComponent<moveobject>();
    }



    void Update()
    {

        if (mv.InArea== true)
        {
            transform.position = new Vector3(transform.position.x, nowPosi + Mathf.PingPong(Time.time / 3, 10.0f), transform.position.z);        }
    }
}