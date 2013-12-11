using UnityEngine;
using System.Collections;

public class Follower : MonoBehaviour {
	
	float minDist = 50;
	float maxDist = 100;
	float distZ, distX;
	Vector3 fPos;
	
	
	// Use this for initialization
	void Start () {
		GameObject player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		followDist ();
	}
	
	void followDist () {
		
	}
}
