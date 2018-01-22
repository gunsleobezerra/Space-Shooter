using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public GameObject Hazards;
	public float min,max,Top;
	public float enemy_delay;
	float time;
	public float WaveStarts, Wavewaits;
	public int Hazardscount;
	int i = 0;
	void Start () {


		Spawn ();

	}

	void Update(){
		if (i < Hazardscount) {
			if (time >= enemy_delay) {
				Spawn ();
				time = 0;
				i++;
			} else {
				time += Time.deltaTime;
			}
		} else {

			if (time > WaveStarts) {


				time = 0;
				i = 0;
			} else {
				time += Time.deltaTime;
			}

		}

	}

	void Spawn(){





		Vector3 SpawnPosition = new Vector3 (Random.Range(min,max),0.0f,Top);
		Quaternion RotationSpawn = new Quaternion ();

		Instantiate (Hazards, SpawnPosition, RotationSpawn);





	

	}
	

}
