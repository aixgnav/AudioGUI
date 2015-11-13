using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	public Text scoreText;
	public int score;

	public int ScoreSystem
	{
		get { return this.score; }
		set 
		{ 
			this.score = value; 
			UpdateScore ();
		}
		
	}
	// Use this for initialization
	void Start () {
		score = 0;
		UpdateScore ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void UpdateScore()
	{
		scoreText.text = "Score: " + score;
	}
}
