using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerMovement : MonoBehaviour {

	public GameObject her;
	private float moveTime;

	// Use this for initialization
	void Start () {
		StartCoroutine (MoveHer ());
	}
	
	// Update is called once per frame
	void Update () {

	}

	private IEnumerator MoveHer() {

		while (moveTime <= 3) {
			her.transform.Translate (Time.deltaTime, 0, 0, Space.World);
			moveTime += Time.deltaTime;
			yield return null;
		}

		while (moveTime > 3 && moveTime <= 6) {
			her.transform.Translate (0, 0, Time.deltaTime, Space.World);
			moveTime += Time.deltaTime;
			yield return null;
		}

		while (moveTime > 6 && moveTime <= 9) {
			moveTime += Time.deltaTime;
			her.transform.Translate ((-2 * Time.deltaTime), 0, (-0.7f * Time.deltaTime), Space.World);
			yield return null;
		}

	}
}
