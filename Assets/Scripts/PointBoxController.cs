using UnityEngine;
using System.Collections;

public class PointBoxController : MonoBehaviour {

	GameObject scoreUI;
	//public AudioClip pointAudio;
	//AudioSource audio;

	// Use this for initialization
	void Start () {
		scoreUI = GameObject.FindWithTag ("ScoreText");
		//audio = GetComponent<AudioSource> ();
	}


	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Player")
		{
			//Play point audio
			GetComponent<AudioSource>().Play();
			//Add 1 point to score
			scoreUI.GetComponent<Score>().ScoreSystem += 1;
			//Destroy box
			Destroy(this.gameObject,0.2f);

		}
	}
}
