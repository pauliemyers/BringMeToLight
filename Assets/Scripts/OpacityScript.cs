using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpacityScript : MonoBehaviour {

	public Transform player1loc;
	public Transform player2loc;
	public float opacity;
	private Vector3 player1position;
	private Vector3 player2position;
	private float p1x;
	private float p1y;
	private float p1z;
	private float p2x;
	private float p2y;
	private float p2z;
	private Vector3 distance;
	public float average;
	private bool touched;
	private Renderer rend;
	private Color newColor;

	// Use this for initialization
	void Start () {
		touched = false;
		rend = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {

		newColor = new Color (0, 0, 0, opacity);

		player1position = player1loc.position;
		p1x = player1loc.position.x;
		if (p1x < 0) {
			p1x *= (-1);
		}
		p1y = player1loc.position.y;
		if (p1y < 0) {
			p1y *= (-1);
		}
		p1z = player1loc.position.z;
		if (p1z < 0) {
			p1z *= (-1);
		}
		player2position = player2loc.position;
		p2x = player2loc.position.x;
		if (p2x < 0) {
			p2x *= (-1);
		}
		p2y = player2loc.position.y;
		if (p2y < 0) {
			p2y *= (-1);
		}
		p2z = player2loc.position.z;
		if (p2z < 0) {
			p2z *= (-1);
		}
		distance = new Vector3 (p1x - p2x, p1y - p2y, p1z - p2z);
		average = ((distance.x + distance.y + distance.z) / 3);
		if (average <= 0) {
			average *= (-1);
		}

		if (!touched) {
			opacity = (1 / ((1 / average) * 10));
			if (opacity >= 1) {
				opacity = 1;
			}
			GetComponent<Renderer> ().material.SetColor ("_Color", newColor);
		} 
		else {
			opacity = 0;
			GetComponent<Renderer> ().material.SetColor ("_Color", newColor);
		}
	}
}
