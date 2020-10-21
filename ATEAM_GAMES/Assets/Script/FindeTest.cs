using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindeTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //GameObject target = GameObject.Find("Cube");
        //Debug.Log("成功 = "+target);
        //GameObject target2 = GameObject.Find("Cube2");
        //Debug.Log("成功 = "+target2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 5, 0));
    }
}
