using UnityEngine;
using System.Collections;

public class asteroid : MonoBehaviour
{
	public GameObject player;

	void LateUpdate()
	{
		float step = Time.deltaTime * 0.5f;
		transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);
	}
}
