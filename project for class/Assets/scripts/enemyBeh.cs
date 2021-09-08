using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class enemyBeh : MonoBehaviour
/
{

    private NavMeshAgent agent;
    public Vector3Data location;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        agent.destination = location.value;
    }
}