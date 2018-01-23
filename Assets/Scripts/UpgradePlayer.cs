using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradePlayer : MonoBehaviour {
	GameObject Player;
	PlayerController playerC;
	public float delay_extra;
	public GameObject new_weapon;
	Rigidbody body;
	void Start () {

		Player = GameObject.FindGameObjectWithTag("Player");

		playerC = Player.GetComponent<PlayerController> ();
		body = this.gameObject.GetComponent<Rigidbody> ();
		body.angularVelocity = new Vector3 (0, 10, 0);



	}

	void OnTriggerEnter(Collider COL){

		if (COL.tag == "Player") {

			playerC.Shot_Delay = delay_extra;
			if (new_weapon != null)
				playerC.Bullets = new_weapon;

			Destroy (this.gameObject);
		}

	}
	

}
