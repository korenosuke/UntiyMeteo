using UnityEngine;
using System.Collections;

public class ShotBullet : MonoBehaviour {

	[SerializeField]
	private GameObject BulletObject;

	[SerializeField]
	private Transform MuzzleObject;

	[SerializeField]
	private float interval;

	[SerializeField]
	private float bulletSpeed;

	private float time = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if(time >= interval) {
			if (Input.GetMouseButton(0)) {

				//力を加える
				Vector3 force;
				force = MuzzleObject.transform.forward * bulletSpeed;
				b.transform.GetComponent<Rigidbody> ().AddForce (force);
				time = 0;
			}
		}
	}
}
