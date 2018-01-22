using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotate : MonoBehaviour {

	Rigidbody Body;
	public float Rot; //Rotation number
	void Start () {

		Body = this.gameObject.GetComponent<Rigidbody> ();
	
		Body.angularVelocity = Random.insideUnitSphere * Rot;

		
	}
	


}
