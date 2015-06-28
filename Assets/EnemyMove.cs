using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

	[SerializeField] GameObject shot;
	[SerializeField] GameObject Enemy;

	const int maxPosition_X = 4;
	float shotWait = 0;
	float enemyTheta = 0;


	// アップデート
	void Update () {
		//敵の動き
		float enemySpeed = Time.deltaTime;
		Vector3 enemyPoint = transform.localPosition; //自分自身位置を拾う.
		enemyTheta += Time.deltaTime;
		enemyPoint.x = maxPosition_X * Mathf.Sin(enemyTheta);
		transform.localPosition = enemyPoint; //更新位置を拾う.

		//攻撃間隔
		if(shotWait > 0){
			shotWait-=Time.deltaTime;
			return;
		}

		//攻撃間隔
		shotWait = Random.value * 1.5f;
		GameObject objData = (GameObject)Instantiate(shot);

		//攻撃位置
		Vector3 point = Enemy.transform.localPosition;
		point.y += 0;
		point.z += 1.0f;
		point.z += Time.deltaTime;
		shot.transform.localPosition = point;
	}
}
