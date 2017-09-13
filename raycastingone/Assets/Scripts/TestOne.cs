using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestOne : MonoBehaviour {
	public LayerMask mask;
	
	// Update is called once per frame
	void Update () {
		// Ray ray = new Ray (Vector3 origin, Vector direction)
		Ray ray = new Ray (transform.position, transform.forward);
		RaycastHit hitInfo;

		if (Physics.Raycast (ray, out hitInfo, 100, mask, QueryTriggerInteraction.Ignore)) {
			print (hitInfo.collider.gameObject.name);
			Destroy (hitInfo.collider.gameObject);
			//same as Destroy (hitInfo.transform.gameObject);
			Debug.DrawLine(ray.origin, hitInfo.point, Color.magenta);
		} else {
			Debug.DrawLine (ray.origin, ray.origin + ray.direction * 100, Color.blue);
		}

	}
}
