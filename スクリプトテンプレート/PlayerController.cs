using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private float sightX {set; get;}
	private float sightY {set; get;}
	private Vector3 direction = new Vector3 (0, 0, 0);

	[SerializeField]
		private float speedX;
	[SerializeField]
		private float speedY;
	[SerializeField]
		private float speed;
	[SerializeField]
		private GameObject head;

	// Use this for initialization
	void Start () {	}
	
	// Update is called once per frame
	void Update () {
		sightY += Input.GetAxis("Mouse X") * speedX;
		sightX -= Input.GetAxis("Mouse Y") * speedY;

		direction = GetDirection();

	}

	void FixedUpdate() {
		var tmp = head.transform.rotation;
		tmp.x = 0; 
		tmp.z = 0;
		transform.position += speed * Time.deltaTime * (tmp * direction);
		head.transform.rotation = Quaternion.Euler (sightX, sightY, 0);

		if (transform.position.y < -10) {
			Time.timeScale = 0.0f;
		}
	}

	private Vector3 GetDirection() {
		Vector3 tmpVec = new Vector3 (0, 0, 0);


		return tmpVec;
	}
}
