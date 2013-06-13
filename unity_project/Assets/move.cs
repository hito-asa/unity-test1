using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	
	private int direction = 0;
	
	Component sphere;

	// Use this for initialization
	void Start () {
		sphere = gameObject.GetComponent("Sphere");

	}
	
	// Update is called once per frame
	void Update () {
  		//rigidbody.MovePosition (new Vector3(Mathf.Sin(Time.time),0,0));
	}
}
