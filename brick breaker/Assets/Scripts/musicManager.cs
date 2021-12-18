using UnityEngine;
using System.Collections;

public class musicManager : MonoBehaviour {
    static musicManager instance = null;

	// Use this for initialization
	void Start () {
        if (instance != null){
            Destroy(gameObject);
            print("dead");
        }
        else {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
