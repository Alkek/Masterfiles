using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAiControl : MonoBehaviour


{

    GameObject player;

    NavMeshAgent agent;

    [SerializeField] LayerMask groundLayer, playerLayer;
    [SerializeField] float range;

    Vector3 destPoint;
    bool walkpointSet;

   


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Patrol();
    }

    void Patrol()
    {
        if(!walkpointSet) SearchForDest();
        if(walkpointSet) agent.SetDestination(destPoint);
        if(Vector3.Distance(transform.position,destPoint)<10) walkpointSet = false;
    }

    void SearchForDest()
    {
        float Z = random.range(-range, range);
        float x = random.range(-range, range);

        destPoint = new Vector3(transform.position.x + x, transform.position.y, transform.position.z + z  );

        if(Physics.Raycast(destPoint, Vector3.down, groundLayer))
        {
            walkpointSet = true;
        }
    }
}
