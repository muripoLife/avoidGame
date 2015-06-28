using UnityEngine;
using System.Collections;

public class playerMove : MonoBehaviour {
	[SerializeField] GameObject Player;
	const int max_X = 4;
	const int min_X = -4;
	const int mouse_position_center = 85;

	//移動範囲の制限をする.
	void Update () {
		Vector3 moveDistance = Player.transform.localPosition; //自分自身位置を拾う.
		float speed = Time.deltaTime * 10;
		if(GameControl.GameOverFrag == false){
			if(Input.GetMouseButton(0))
			{
				if((Input.mousePosition.x >= mouse_position_center)&&(moveDistance.x >= min_X))
				{
					moveDistance.x -= speed;
				}else if((Input.mousePosition.x <= mouse_position_center)&&(moveDistance.x <= max_X))
				{
					moveDistance.x += speed;
				}else{
					moveDistance.x += 0;
				}
			}
		}
		transform.localPosition = moveDistance; //変化した値を表示する.
	}
}
