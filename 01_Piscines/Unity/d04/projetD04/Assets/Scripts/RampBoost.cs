using UnityEngine;
using System.Collections;

public class RampBoost : MonoBehaviour {

	public bool isRight = true;
	public int boost;
	private float direction = 1;
	
	void Start() {
		if (isRight == false)
			direction = -1;
	}

	void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.tag == "Player")
			collision.gameObject.GetComponent<Sonic>().rampBoost(direction, boost);
	}
}
