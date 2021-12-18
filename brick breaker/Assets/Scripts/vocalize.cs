using UnityEngine;
using System.Collections;

public class vocalize : MonoBehaviour {
    public bool hat = false;
    public AudioClip clip;
    public bool polka = false;
    public AudioClip clipp;

    // Use this for initialization
    void Start () {
        hat = false;
	}
	
	// Update is called once per frame
	public void Up() {
        if (hat == true)
        {
            AudioSource.PlayClipAtPoint(clip, this.transform.position);
            new WaitForSecondsRealtime(3);
            hat = false;
            polka = false;
        }
        if (polka == true)
        {
            AudioSource.PlayClipAtPoint(clipp, this.transform.position);
            new WaitForSecondsRealtime(3);
            polka = false;
        }
    }

}
