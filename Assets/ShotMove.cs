using UnityEngine;
using System.Collections;

// 射撃の動き
public class ShotMove : MonoBehaviour {

	float lifeTimer = 10.0f ;
	bool collisionFlag = false;
	float normalTimer = 0;

	// アップデート
	void Update () {

		//攻撃角度
		Vector3 point = transform.localPosition; //初期の座標
		point.z += Time.deltaTime*3;
		transform.localPosition = point; //更新後の座標
		normalTimer += Time.deltaTime;
		if( normalTimer >= lifeTimer ){
			Destroy(gameObject);
		}
	}
}
