using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegSpawner : MonoBehaviour {

	public GameObject[] pegVariety; 

	public float startX;
	public float startZ;

	public float endX;
	public float endZ;

	public int densityX;
	public int densityZ;

	public bool pegsSpawned;


	// Use this for initialization
	void Start () {

		for(int x = 0; x < densityX; x++){
			for(int z = 0; x < densityZ; z++){

				Vector3 position = new Vector3 (
	            	Mathf.Lerp (startX, endX, x / densityX), 
					0,
					Mathf.Lerp (startZ, endZ, z / densityZ)
				);

				Instantiate (
					pegVariety [Random.Range (0, pegVariety.Length)],
					position,
					new Quaternion(0, 0, 0, 0),
					transform
				);

			}

		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
