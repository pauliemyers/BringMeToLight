using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionChanger : MonoBehaviour {

	public Material matGrass;
	public Material matGrassDark;
	public Material matMeadow;
	public Material matSand;
	public Material matEarth;
	public Material matHill;
	public Material matMountain;
	public Material matSnow;
	public Material matSky;
	public Material matStar;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "grass") {
			var rend = col.gameObject.GetComponent<Renderer> ();
			rend.material = matGrass;
		}
		else if (col.gameObject.tag == "grassDark") {
			var rend = col.gameObject.GetComponent<Renderer> ();
			rend.material = matGrassDark;
		}
		else if (col.gameObject.tag == "snow") {
			var rend = col.gameObject.GetComponent<Renderer> ();
			rend.material = matSnow;
		}
		else if (col.gameObject.tag == "mountain") {
			var rend = col.gameObject.GetComponent<Renderer> ();
			rend.material = matMountain;
		}
		else if (col.gameObject.tag == "hill") {
			var rend = col.gameObject.GetComponent<Renderer> ();
			rend.material = matHill;
		}
		else if (col.gameObject.tag == "earth") {
			var rend = col.gameObject.GetComponent<Renderer> ();
			rend.material = matEarth;
		}
		else if (col.gameObject.tag == "meadow") {
			var rend = col.gameObject.GetComponent<Renderer> ();
			rend.material = matMeadow;
		}
		else if (col.gameObject.tag == "sand") {
			var rend = col.gameObject.GetComponent<Renderer> ();
			rend.material = matSand;
		}
		else if (col.gameObject.tag == "sky") {
			var rend = col.gameObject.GetComponent<Renderer> ();
			rend.material = matSky;
		}
		else if (col.gameObject.tag == "star") {
			var rend = col.gameObject.GetComponent<Renderer> ();
			rend.material = matStar;
		}
	}
}
