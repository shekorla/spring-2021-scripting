using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;
using UnityEngine.Events;

[RequireComponent(typeof(NavMeshAgent))]
public class enemyBeh : MonoBehaviour
{
    private NavMeshAgent agent;
    private int newX, newZ;
    private bool patrol = false, hunt= false;
    private Vector3 location, currentLoc;
    public UnityEvent stoppedEv;
    public int moveRange=50,maxspeed=10;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = maxspeed;
        currentLoc= gameObject.transform.position;
        newDest();
    }
    private void Update()
    {
        currentLoc = gameObject.transform.position;
        if (agent.hasPath&& patrol==true&&hunt==false)// if you are at where you were trying to go
        {
            StopAllCoroutines();
            patrol = false;//true can find new dest, false cannot
            StartCoroutine(lookForPlayer());
        }
    }

    public void newDest()//check where you are, move to a random new loc near
    {
        //Debug.Log("wander");//enemy randomly wanders, change to follow set patrol route later
        newX = (int) Random.Range(currentLoc.x - moveRange, currentLoc.x + moveRange);
        newZ = (int) Random.Range(currentLoc.z - moveRange, currentLoc.z + moveRange);
        location = new Vector3(newX, 0, newZ);
        agent.destination = location;
        patrol = true;
    }
    IEnumerator lookForPlayer()
    {
        if (hunt==true)
        {
           yield break; 
        }
        else
        {
            //Debug.Log("wait and look for player");
            yield return new WaitForSecondsRealtime(5);
            //Debug.Log("now move on");
            stoppedEv.Invoke();  
        }
        
    }

    IEnumerator followPlayer(GameObject target)
    {
        //Debug.Log("Follow");
        while (hunt==true)
        {
            agent.speed = maxspeed * 1.5f;//move faster during hunt
            agent.destination =target.transform.position; //follows the player
            yield return new WaitForSecondsRealtime(1);//only update every 2 seconds to save cpu
        }
    }

    public void foundYou(GameObject target)//see the player start following
    {
        StopCoroutine(lookForPlayer());
        hunt = true;
        StartCoroutine(followPlayer(target));
    }
    public void lostYou()//return to patrol once loose player
    {
        StopCoroutine(followPlayer(GameObject.FindGameObjectWithTag("Player")));
        hunt = false;
        patrol = false;
        agent.speed = maxspeed;
        currentLoc= gameObject.transform.position;
        newDest();
    }
}