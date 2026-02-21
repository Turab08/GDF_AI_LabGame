using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChasingAI : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;

    void Update()
    {
        //Every frame, set the destination of the agent to the player's position
        agent.SetDestination(player.position);
    }
}
