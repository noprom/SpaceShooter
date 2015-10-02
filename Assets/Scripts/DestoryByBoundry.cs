using UnityEngine;
using System.Collections;

public class DestoryByBoundry : MonoBehaviour {

	void OnTriggerExit(Collider other) {
		Destroy (other.gameObject);
	}
}
