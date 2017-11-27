using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour {
	public float speed;

	public Vector3 jump;
	public float jumpForce = 2.0f;
	public float jumpHeight = 2.0f;

	public Transform theCameraTransform;

	private bool isGrounded;

	Rigidbody rb;

	public float currentX = 0.0f;
	public float currentY = 0.0f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		jump = new Vector3 (0.0f, jumpHeight, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {

		currentX += Input.GetAxis ("Mouse X");

		if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)) {
			transform.Translate (speed, 0, 0);
		} else if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)) {
			transform.Translate (-speed, 0, 0);
		} else if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W)) {
			transform.Translate (0, 0, speed);
		} else if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.S)) {
			transform.Translate (0, 0, -speed);
		}

		if (Input.GetKeyDown (KeyCode.Space) && isGrounded) {

			rb.AddForce (jump * jumpForce, ForceMode.Impulse);
			isGrounded = false;
		}

		if (Input.GetKeyDown (KeyCode.R)) {
			this.transform.rotation = Quaternion.Euler (0, 0, 0);
		}

		if (Input.GetKeyDown (KeyCode.Q)) {
			this.transform.position = new Vector3 (-1.2f, 4.46f, 0.36f);
			this.transform.rotation = Quaternion.Euler (0, 0, 0);
		}
			
	}

	void OnCollisionStay() {
		isGrounded = true;
	}

	private void LateUpdate() {
		Quaternion rotation = Quaternion.Euler (currentY, currentX, 0);
		this.transform.rotation = rotation;
	}
}

