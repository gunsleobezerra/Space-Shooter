using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Limitbody{

	public float minX,maxX,minZ,maxZ;

}

public class PlayerController : MonoBehaviour {

	public Rigidbody Player;
	public float Speed;
	public Limitbody Limit;
	public float Tilt;
	public GameObject Bullets;
	public Transform Spawnshot;
	public float Shot_Delay;
	float times;


	void Update(){



		if (Input.GetButton ("Fire3") && times>=Shot_Delay) {
			Instantiate (Bullets, Spawnshot.position, Spawnshot.rotation);
			times = 0;
		}
		times += Time.deltaTime;
	}





	void FixedUpdate(){


		///Get input of player
		float mHorizontal = Input.GetAxis ("Horizontal");
		float mVertical = Input.GetAxis ("Vertical");

		///don't move around y axis
		var Moviment = new Vector3 (mHorizontal, 0.0f, mVertical);
		Moviment *= Speed;
		Player.velocity = Moviment;

		Player.position = new Vector3 (
			Mathf.Clamp(Player.position.x,Limit.minX,Limit.maxX),
			0.0f,
			Mathf.Clamp(Player.position.z,Limit.minZ,Limit.maxZ)
		);

		Player.rotation = Quaternion.Euler (0.0f, 0.0f, Player.velocity.x * -Tilt);



	}
}
