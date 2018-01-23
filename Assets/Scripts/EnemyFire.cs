using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour {

	public Rigidbody Bullet;
	public Transform Spawnl;
	public float delay;
	float time;
	bool OnWorld=false;

	void Start(){




	}

	void Update () {

		if (OnWorld == true) {

			if (time > delay) {
				Instantiate (Bullet,Spawnl.position,Spawnl.rotation);
				time = 0;
			} else {
				time += Time.deltaTime;
			}



		}



	}

	void OnTriggerEnter(Collider COL){
		
		if (COL.tag == "Finish"){
			OnWorld = true;
		 Instantiate (Bullet,Spawnl.position,Spawnl.rotation);
		
	}

}
}