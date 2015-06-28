using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {

	public static bool GameOverFrag = false; 
	public static bool OpenningFrag = true;
	public static bool LifeFrag     = true;
	[SerializeField] GameObject text_start;
	[SerializeField] GameObject text_end;
	[SerializeField] GameObject Player;

	//体力
	public int life = 1;

	//得点カウント
	public float count = 1f;

	//スタート
	void Start () {

		Time.timeScale = 1;

		GameOverFrag = false;
		OpenningFrag = true;
		text_start.gameObject.SetActive(OpenningFrag);
		text_end.gameObject.SetActive(GameOverFrag);
		Invoke("OpenningTime", 1.0f);
	}

	// アップデート
	void Update () 
	{
		if (GameOverFrag) {
			text_end.gameObject.SetActive (GameOverFrag);
			if (Input.GetMouseButtonDown(0)) {
				GameOverFrag = false;
				Application.LoadLevel ("main"); //再ロード
			}
		}else{
			Score.Score_count += count;
		}

		//難易度設定
		if(Score.Score_count < 1000){
			Time.timeScale = 1;
		}else if(Score.Score_count < 2000){
			Time.timeScale = 2;
		}else if(Score.Score_count < 3000){
			Time.timeScale = 3;
		}else if(Score.Score_count < 4000){
			Time.timeScale = 4;
		}else if(Score.Score_count < 5000){
			Time.timeScale = 5;
		}else if(Score.Score_count < 6000){
			Time.timeScale = 6;
		}else if(Score.Score_count < 7000){
			Time.timeScale = 7;
		}else if(Score.Score_count < 8000){
			Time.timeScale = 8;
		}else if(Score.Score_count < 9000){
			Time.timeScale = 9;
		}else{
			Time.timeScale = 10;
		}
	}

	//衝突で呼ばれます
	private void OnCollisionEnter(UnityEngine.Collision collision)
	{
		string tag = collision.gameObject.tag;
		if (tag == "Shot") 
		{
			life--;
			if (life <= 0) 
			{
				GameOverFrag = true;
			}
		}
	}

	public void OpenningTime(){
		OpenningFrag = false;
		text_start.gameObject.SetActive (OpenningFrag);
	}
}
