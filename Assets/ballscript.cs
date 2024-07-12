using UnityEngine;
using System.Collections;

public class ballscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	transform.position += transform.forward * 15f * Time.deltaTime;
	
	}
}
