using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiral : MonoBehaviour
{
    //public float Rotate = 100.0f;
    //public bool InArea = false;

    void Start()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obj")
        {

            //オブジェクトを子要素に
            GameObject emptyObject = new GameObject();
            emptyObject.transform.parent = this.transform;
            other.transform.parent = emptyObject.transform;
            emptyObject.name = "object";
        }
    }

    //void OnTriggerExit(Collider other)
    //{
    //    other.transform.parent = null;
    //    GameObject emptyObject = GameObject.Find("empty");
    //    Destroy(emptyObject);

    //}

    // Update is called once per frame
    void Update()
    {

    }
}
