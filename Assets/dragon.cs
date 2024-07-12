using UnityEngine;
using System.Collections;

public class dragon : MonoBehaviour {

	Rigidbody _rigidbody;

	public int n;

	public GameObject mentoscandy;

	public GameObject weather;


	// Use this for initialization
	void Start () {

		_rigidbody = GetComponent<Rigidbody> ();
		gameObject.GetComponent<AudioSource> ().Play (); 

	
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.y < -10f) {
			Application.LoadLevel("gameover");
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.position += Vector3.forward * Time.deltaTime * 10f;
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.position += Vector3.back * Time.deltaTime * 10f;
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position += Vector3.left * Time.deltaTime * 10f;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position += Vector3.right * Time.deltaTime * 10f;
		}
		if (Input.GetKeyDown ("1")) {
				Instantiate(mentoscandy,transform.position,transform.rotation);
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (n == 0) {
				n += 1;
				_rigidbody.velocity += Vector3.up * 9f;
			}
		}
		if (Input.GetKeyDown ("2")) {
			weather.SetActive(true);
		}
		if (Input.GetKeyDown ("3")) {
			weather.SetActive(false);
		}
	}

	void OnCollisionEnter(){
		n = 0;
	}
}
