using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 2.0f;
    public float brake = 0.5f;  //減速の大きさ
    private Rigidbody rB;
    private Vector3 rbVelo;     //今の速度を入れる変数


    public Text goalText;
    public bool goalOn;
    public ParticleSystem explosion;
    public Text failText;

    // Start is called before the first frame update
    void Start()
    {
        rB = GetComponent<Rigidbody>();
       // goalText.enabled = false;
       // goalOn = false;
       // failText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (goalOn == false)
        {
            rbVelo = Vector3.zero;  //初期化するために毎回(0,0,0)を入れる
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");
            rbVelo = rB.velocity;   //今の速度をrbVeloに入れる
            rB.AddForce(x * speed - rbVelo.x * brake, 0, z * speed - rbVelo.z * brake, ForceMode.Impulse);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Goal")
        {
            other.gameObject.GetComponent<Renderer>().material.color = new Color(1, 0, 0, 1);
            rB.AddForce(-rbVelo.x * 0.8f, 0, -rbVelo.z * 0.8f, ForceMode.Impulse);
            goalText.enabled = true;
            goalOn = true;
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "enemy")
        {
            explosion.transform.position = other.transform.position;
            failText.enabled = true;
            explosion.Play();
        }
    }
}
