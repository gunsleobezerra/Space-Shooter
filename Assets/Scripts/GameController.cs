using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public GameObject Hazards1,Hazards2,Extra1,Extra2;
	public float min,max,Top;
	public float enemy_delay;
	float time;
	public float WaveStarts;
	public int Hazardscount;
	int i ;
	void Start () {


		i = Hazardscount;

	}

	void Update(){
		if (i < Hazardscount) {
			if (time >= enemy_delay) {
				Spawn ();
				time = 0;
				i++;
			} else {
				time += Time.deltaTime;
				Debug.Log (i);
			}

			if (i == (Hazardscount / 2) && time==0)
				SpawnExtra ();
		} else {

			if (time > WaveStarts) {


				time = 0;
				i = 0;
			} else {
				time += Time.deltaTime;
			}

		}

	}

	void SpawnExtra(){

		int change;



		Vector3 SpawnPosition = new Vector3 (Random.Range(min,max),0.0f,Top);
		Quaternion RotationSpawn = new Quaternion ();

		change = Random.Range (1, 3);
		Debug.Log (change);
		if (change==2) {
			Instantiate (Extra1, SpawnPosition, RotationSpawn);
		} else {
			Instantiate (Extra2, SpawnPosition, RotationSpawn);
		}






	}

	void Spawn(){

		int change;



		Vector3 SpawnPosition = new Vector3 (Random.Range(min,max),0.0f,Top);
		Quaternion RotationSpawn = new Quaternion ();

		change = Random.Range (1, 3);
		Debug.Log (change);
		if (change==2) {
			Instantiate (Hazards1, SpawnPosition, RotationSpawn);
		} else {
			Instantiate (Hazards2, SpawnPosition, RotationSpawn);
		}




	

	}
	

}
