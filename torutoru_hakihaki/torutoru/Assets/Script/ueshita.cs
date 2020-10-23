using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ueshita : MonoBehaviour
{
    private int count;
    private int a = 1;

    void Start()
    {
        //startPos = this.transform.position;
    }

    //void OnTriggerStay(Collider other)
    //{
    //    if (other.gameObject.tag == "test")
    //    {
    //        Debug.Log(count);
    //            count += 1;
    //            transform.Translate(a * Vector3.up * Time.deltaTime);

    //            if (count % 200 == 0)
    //            {
    //                a *= -1;
    //            }
    //        }
    //    }
    //}

    void Update()
    {

        if (move.InArea)
        {
            count += 1;
            transform.Translate(a * Vector3.up * Time.deltaTime);

            if (count % 200 == 0)
            {
                a *= -1;
            }
        }
    }
}