using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Collider))]

public class view : MonoBehaviour
{
	public Animation animate;
	private CardboardHead cam;

	void Start ()
	{
		cam = Camera.main.GetComponent<StereoController>().Head;
		animate = GetComponent<Animation>();

		foreach (Transform child in transform)
		{
			child.renderer.materials[0].color = Color.black;
		}
	}

	void Update ()
	{
		RaycastHit hit;
		bool inView = GetComponent<Collider>().Raycast(cam.Gaze, out hit, Mathf.Infinity);

		if (inView && !animate.IsPlaying("Explosion") && Time.timeScale != 0.0f)
		{
			foreach (Transform child in transform)
			{
				child.renderer.materials[1].color = Color.yellow;
			}
			//gameObject.renderer.materials[1].color = Color.yellow;
		}

		else if (Time.timeScale == 0.0f)
		{
			foreach (Transform child in transform)
			{
				child.renderer.materials[1].color = Color.red;
			}
			//gameObject.renderer.materials[1].color = Color.white;
		}

		else
		{
			foreach (Transform child in transform)
			{
				child.renderer.materials[1].color = Color.white;
			}
			//gameObject.renderer.materials[1].color = Color.white;
		}

		/*if (Cardboard.SDK.CardboardTriggered && inView)
		{
			Vector3 direction = Random.onUnitSphere;
			direction.y = Mathf.Clamp(direction.y, 0.5f, 1f);
			float distance = 2 * Random.value + 1.5f;
			transform.localPosition = direction * distance;
		}*/
	}
}