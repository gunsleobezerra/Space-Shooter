using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitWorld : MonoBehaviour {
	
	void OnTriggerExit(Collider COL){

		Destroy (COL.gameObject,0.5f);

	}
}
