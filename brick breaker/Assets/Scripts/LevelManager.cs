using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public int score;
    public Text scoretxt; 
    public moneySO money;

    public void Start()
    {
        score = 0;
    }

	public void LoadLevel(string name){
        if (name=="level one")
        { score = 0; }

        if (name == "lose screen")
        { money.levelEnd(score); }
        SceneManager.LoadScene(name);
    }
    
    public void QuitRequest(){
		//Debug.Log ("Quit requested");
		Application.Quit ();
	}
    void Update()
    {
        scoretxt.text="score:" + score.ToString();
    }

}
