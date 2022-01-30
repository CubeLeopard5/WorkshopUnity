using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	public GameObject character;
	public float adjustAxeY = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (character.transform.position.x, character.transform.position.y + adjustAxeY, -10);
	}
}
