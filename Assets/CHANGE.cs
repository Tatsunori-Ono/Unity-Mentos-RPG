using UnityEngine;
using System.Collections;

public class CHANGE : MonoBehaviour {

	public GameObject exp;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Player") {
			Instantiate (exp, transform.position, transform.rotation);
			Destroy (gameObject);
		}
	}
}
