using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float speed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Transform mytransform = this.transform;
        Debug.Log(Time.deltaTime);
        transform.Rotate(Vector3.one * speed * Time.deltaTime, Space.World);
    }
}
