using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

	public GameObject ballPrefab;

	// Use this for initialization
	void Start () {

		Instantiate (ballPrefab, transform.position, new Quaternion (), transform);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
