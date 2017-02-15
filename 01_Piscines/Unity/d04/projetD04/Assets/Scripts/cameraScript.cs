using UnityEngine;
using System.Collections;

public class cameraScript : MonoBehaviour {

	public GameObject activePlayer;

	void Start () {
		putCamera(activePlayer);

	}

	//Camera follow player
	void putCamera(GameObject player) {
		gameObject.transform.SetParent (player.transform);
		gameObject.transform.localPosition  = new Vector3(0, 1.5f, -10);
	}
}
