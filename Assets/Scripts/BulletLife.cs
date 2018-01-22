using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLife : MonoBehaviour {

	Rigidbody Bullet;
	public float Speed;

	void Start () {

		Bullet = this.gameObject.GetComponent<Rigidbody>();

		Bullet.velocity = Vector3.forward * Speed;


	}




	

}
