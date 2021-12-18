using UnityEngine;
using System.Collections;

public class powerup : MonoBehaviour {

    public Collider2D col;
    public Vector3 now;
	
    void Start()
    {
        now = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
    }

    void Update()
    {
        if (this.transform.position.y<now.y)
        {
            gotime();
        }
    }
    void gotime()
    {
        //Debug.Log("i dont know");
        col.isTrigger = true;
    }
}
