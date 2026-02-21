using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class LabyrinthAI : MonoBehaviour
{
    [Header("NavMesh Agent")]
    public NavMeshAgent agent;

    public Transform endPoint;

    [Header("Endpoint Postitions")]
    public Transform[] endPointPositions;

    void Start()
    {
        agent.SetDestination(endPoint.position);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeEndPoint();
        }
    }
    
    void ChangeEndPoint()
    {
        int randomIndex = Random.Range(0, endPointPositions.Length);

        endPoint.position = new Vector3(endPointPositions[randomIndex].position.x, endPoint.position.y, endPointPositions[randomIndex].position.z);
        agent.SetDestination(endPoint.position);
    }
}
