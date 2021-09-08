using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;
using UnityEngine.Events;

[RequireComponent(typeof(NavMeshAgent))]
public class enemyBeh : MonoBehaviour
{
    private NavMeshAgent agent;
    private bool isMoving;
    private int newX, newZ;
    private Vector3 location, currentLoc;
    public UnityEvent stoppedEv;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        isMoving = false;
        currentLoc = gameObject.transform.position;
        newDest();
    }
    private void Update()
    {
        currentLoc = gameObject.transform.position;
    }

    private IEnumerator moving()
    {
        while (isMoving==true)
        {
            //add the looking for player code here
            yield return null;
        }
        if (currentLoc==agent.destination)
        {
            isMoving = false;
            stoppedEv.Invoke();
            yield return null;
        }
        yield return null;
    }
    public void startMoving()//take this out if its not needed later???
    {
        isMoving =true;
        StartCoroutine(moving());
    }

    public void stopMov()//just a flat stop does not start again
    {
        isMoving = false;
    }

    public void newDest()//check where you are, move to a new loc near
    {
        newX = (int) Random.Range(currentLoc.x-10, currentLoc.x + 10);
        newZ = (int) Random.Range(currentLoc.z-10, currentLoc.z + 10);
        location = new Vector3(newX, 0, newZ);
        agent.destination = location;
        startMoving();
    }
}