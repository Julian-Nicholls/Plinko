using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegSpawner : MonoBehaviour {

	public GameObject[] pegVariety; 

	public Vector3 topLeft;
	public Vector3 topRight;
	public Vector3 bottomLeft;
	public Vector3 bottomRight;

	public int densityX;
	public int densityZ;

	public bool pegsSpawned;


	// Use this for initialization
	void Start () {

		for(int z = 0; z <= densityZ; z++){

			Vector3 left = Vector3.Lerp (topLeft, bottomLeft, (z*1f / densityZ*1f)*1f);
			Vector3 right = Vector3.Lerp (topRight, bottomRight, (z*1f / densityZ*1f)*1f);

			Debug.Log (right);

			for(int x = 0; x <= densityX; x++){			

				Vector3 position = Vector3.Lerp (left, right, (x*1f / densityX*1f)*1f);

				Debug.Log (position);

				GameObject clone = Instantiate (
					pegVariety [Random.Range (0, pegVariety.Length)],
					position,
					new Quaternion(0, 0, 0, 0),
					transform
				);

				clone.transform.parent = transform;
				clone.transform.localPosition = position;

			}
		

		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
