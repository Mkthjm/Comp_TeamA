using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Tuiju : MonoBehaviour
{
    public bool inArea = false;
    public GameObject target;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            target = other.gameObject;
            inArea = true;
            GetComponent<Renderer>().material.color = new Color(255f / 255f, 65f / 255f, 26f / 255f, 255f / 255f);
            EneChasing();
        }
    }


    public void EneChasing()
    {
        //transform.position += transform.forward * speed;
    }

    void Update()
    {
        if (inArea == true && target.activeInHierarchy == true)
        {
            agent.destination = target.transform.position;
            EneChasing();
        }
    }
}