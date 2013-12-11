using UnityEngine;
using System.Collections;

public class Movements : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		bool up = Input.GetKey (KeyCode.UpArrow);

		if (up) {
			transform.Translate (new Vector3 (0, 0, 3) * Time.deltaTime);
		}
	}
}
