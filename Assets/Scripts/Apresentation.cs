using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apresentation : MonoBehaviour {

	Rigidbody Mybody;
	Animator Enemator;

	void Start(){


		Mybody = this.gameObject.GetComponent<Rigidbody> ();
		Enemator = this.gameObject.GetComponent<Animator> ();
	}

	void OnTriggerEnter(Collider COL){

		if (COL.tag == "Finish") {

			Enemator.SetBool ("Onworld", true);



		}



	}
}
