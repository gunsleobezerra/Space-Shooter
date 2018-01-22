using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyContact : MonoBehaviour {

	public GameObject DestroyFireworks;
	public GameObject PlayerExplode;

	void OnTriggerEnter(Collider other){
		if (other.tag != "Finish") {

			Destroy (other.gameObject);
			Destroy (this.gameObject);
			GameObject body	=Instantiate (DestroyFireworks, this.gameObject.transform.position, this.gameObject.transform.rotation) as GameObject;
			if(other.tag=="Player") Instantiate (PlayerExplode, this.gameObject.transform.position, this.gameObject.transform.rotation);
			Destroy (body,3f);


		}



	}

}
