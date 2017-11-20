using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour {
	private Transform thisCube;

	// Use this for initialization
	void Start () {
		thisCube = gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
		thisCube.Rotate (Random.Range (0, 5), Random.Range (0, 5), Random.Range (0, 5));
	}
}
