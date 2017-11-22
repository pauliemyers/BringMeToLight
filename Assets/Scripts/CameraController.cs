﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	private const float Y_ANGLE_MIN = 10.0f;
	private const float Y_ANGLE_MAX = 50.0f;

	public Transform lookAt;
	public Transform camTransform;

	private Camera cam;

	public float distance = 10.0f;
	public float currentX = 0.0f;
	public float currentY = 35.0f;
	public float sensitivityX = 4.0f;
	public float sensitivityY = 1.0f;

	// Use this for initialization
	void Start () {
		camTransform = this.transform;
		cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		currentX += Input.GetAxis ("Mouse X");

		if (Input.GetMouseButton (1)) {
			currentY += Input.GetAxis ("Mouse Y");

			currentY = Mathf.Clamp (currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
		}
	}

	private void LateUpdate() {
		Vector3 dir = new Vector3 (0, 0, -distance);
		Quaternion rotation = Quaternion.Euler (currentY, currentX, 0);
		camTransform.position = lookAt.position + rotation * dir;
		camTransform.LookAt (lookAt.position);
	}
}
