using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformUp : MonoBehaviour {

	public bool goUp;
	public float platformSpeed = 5.0f;

	// Use this for initialization
	void Start () {
		goUp = true;
		StartCoroutine (PlatformMoveVert ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private IEnumerator PlatformMoveVert() {
		while (enabled) {
			yield return new WaitForSeconds (1.5f);
			while (transform.position.y < 500.0f) {
				this.transform.Translate (0, platformSpeed * Time.deltaTime, 0, Space.World);
				yield return null;
			}
			yield return new WaitForSeconds (1.5f);
			while (transform.position.y > 0.0f) {
				this.transform.Translate (0, -platformSpeed * Time.deltaTime, 0, Space.World);
				yield return null;
			}
		}
	}
}
