using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailCreator : MonoBehaviour {

	public GameObject trail;
	public float instantiateTime;
	private Vector3 curPos;
	private Vector3 lastPos;


	// Use this for initialization
	void Start () {
		lastPos = this.transform.position;
		curPos = new Vector3 (0, 0, 0);
		StartCoroutine (CreateTrail ());
	}
	
	// Update is called once per frame
	void Update () {
		curPos = this.transform.position;
	}

	private IEnumerator CreateTrail() {
		while (curPos != lastPos) {
			Instantiate (trail, new Vector3 (gameObject.transform.position.x, 0.1f, gameObject.transform.position.z), Quaternion.identity);
			lastPos = this.transform.position;
			yield return new WaitForSeconds (instantiateTime);
		}
	}


}
