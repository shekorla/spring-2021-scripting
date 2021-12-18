using UnityEngine;
using UnityEngine.Events;

public class reboundBoxSC : MonoBehaviour
{
    public UnityEvent stuckEve;
    
    private int count;
    private Vector3 plrLocA, plrLocB;
    
    public void plrBounce(GameObject plr)
    {
        if (count==2)
        {
            doubles(plr);
        }
        if (count==1)
        {
            plrLocB = plr.transform.position;
            count += 1;
        }
        if (count==0)
        {
            plrLocA = plr.transform.position;
            count += 1;
        }
    }

    public void doubles(GameObject plr)
    {
        if (plrLocA==plrLocB&&plrLocA==plr.transform.position)
        {
            stuckEve.Invoke();
        }
    }
}
