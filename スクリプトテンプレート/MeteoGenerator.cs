using UnityEngine;
using System.Collections;

public class MeteoGenerator : MonoBehaviour {

	[SerializeField]
		private GameObject meteo;
	[SerializeField]
		private float interval;

	[SerializeField]
		private float height;
	[SerializeField]
		private float xMin;
	[SerializeField]
		private float xMax;
	[SerializeField]
		private float zMin;
	[SerializeField]
		private float zMax;

	private float time;

	// Use this for initialization
	void Start () {	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if(time >= interval) {

			time = 0;
		}
	}
}
