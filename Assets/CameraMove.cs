using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
	
	//追跡対象
	[SerializeField] GameObject player;

	void Update () {
		Vector3 point = transform.localPosition;
		point.x = player.transform.localPosition.x;
		point.y = player.transform.localPosition.y;
		transform.localPosition = point;
	}
}