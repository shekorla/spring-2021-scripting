using UnityEngine;
using System.Collections;

public class brick : MonoBehaviour {

    public int maxHits;
    public int currentHits;
    public LevelManager LM;
    public brickBuilder Boss;
    public vocalize voca;
    public bool des;

    // Use this for initialization
    void Start () {
	    currentHits = maxHits;
        LM = GameObject.FindObjectOfType<LevelManager>();
        Boss=Object.FindObjectOfType<brickBuilder>(); ;
        des = false;
    }
	
    void noClones()
    {
        des = false;
            if (this.tag == "green" && des == false)
            {
                new WaitForSecondsRealtime(10);
                Destroy(GameObject.Find("green(Clone)"));
               des = true;
             }
             if (this.tag == "orange" && des == false)
             {
                new WaitForSecondsRealtime(10);
                Destroy(GameObject.Find("orange(Clone)"));
              des = true;
             }
            if(this.tag == "blue" && des == false)
             {
                new WaitForSecondsRealtime(10);
                Destroy(GameObject.Find("blue(Clone)"));
                des = true;
            }
             if (this.tag == "red"&&des==false)
             {
                new WaitForSecondsRealtime(10);
                Destroy(GameObject.Find("red(Clone)"));
                 des = true;
             }
        des = true;
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.CompareTag("Player")) //you got hit
        {
            LM.score += maxHits;
            currentHits = currentHits - 1;
            if (currentHits <= 0)
            {
                Boss.brickCount -= 1;
                voca.hat = true;
                voca.Up();
                Destroy(gameObject);
                noClones();
            }
        }
    }
}
