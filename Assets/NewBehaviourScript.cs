using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	public float speed=100;
	public float majumundurenak=10;
	//public float Left=100;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space) || Input.touchCount == 1) {
			GetComponent<Rigidbody> ().velocity = Vector3.zero;
			GetComponent<Rigidbody> ().AddForce (Vector3.up * speed);
		}
		if (Input.GetKey (KeyCode.LeftArrow) || Input.touchCount == 1){
			//GetComponent<Rigidbody> ().velocity = Vector3.zero;
			GetComponent<Rigidbody> ().AddForce (Vector3.left * majumundurenak);
	}
		if (Input.GetKey (KeyCode.RightArrow) || Input.touchCount == 1){
			//GetComponent<Rigidbody> ().velocity = Vector3.zero;
			GetComponent<Rigidbody> ().AddForce (Vector3.right * majumundurenak);
		}
			 }
}
