using UnityEngine;
using System.Collections;

public class UFOvelocity : MonoBehaviour {

	public GameObject player;

	void LateUpdate ()
	{
		float step = Time.deltaTime * 1.0f;
		transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);
	}
}
