using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static float Score_count = 0;
	[SerializeField] Text scoreText;

	void Start () {
		Score_count = 0;
	}
	
	void Update () {
		scoreText.text = "Score" + Score_count;
	}
}
