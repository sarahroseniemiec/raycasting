using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string[] messages = { "hello", "jensen", "coke", "yada", "strawberry" };
		StartCoroutine (PrintMessages (messages, 2f));
	}

	IEnumerator

	IEnumerator PrintMessages(string[] messages, float delay) {
		foreach (string message in messages) {
			print (message);
			yield return new WaitForSeconds (delay);
		}
	}
}
