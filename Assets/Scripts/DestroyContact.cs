using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyContact : MonoBehaviour {

	public GameObject DestroyFireworks;
	public GameObject PlayerExplode;
	GameObject body;

	void OnTriggerEnter(Collider other){
		if (other.tag != "Finish" && other.tag!="Finish2" && other.tag!="Extra") {

			Destroy (other.gameObject);
			Destroy (this.gameObject);
			 body	= Instantiate (DestroyFireworks, this.gameObject.transform.position, this.gameObject.transform.rotation) as GameObject;
			if(other.tag=="Player") Instantiate (PlayerExplode, this.gameObject.transform.position, this.gameObject.transform.rotation);
			Destroy (body,3f);


		}



	}

}
