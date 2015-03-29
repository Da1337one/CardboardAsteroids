using UnityEngine;
using System.Collections;

public class UFOexplode : MonoBehaviour
{
	public Animation animate;
	private bool destroyCycle = false;
	private bool deathCycle = false;
	private spawnAsteroids spawn;
	private crosshair guiAccess;
	
	void Start()
	{
		spawn = (spawnAsteroids)GameObject.Find("Spawner").GetComponent("spawnAsteroids");
		guiAccess = (crosshair)GameObject.Find("CardboardMain").GetComponent("crosshair");
		animate = GetComponent<Animation>();
		deathCycle = false;
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "laser")
		{
			destroyCycle = true;
			guiAccess.score += 1000;
			foreach (Transform child in transform)
			{
				child.renderer.materials[1].color = Color.white;
			}
			animate.Play("Explosion");
		}
	}
	
	void Update()
	{
		if ((Vector3.Distance(transform.position, GameObject.Find("CardboardMain").transform.position) <= 1.5) && deathCycle == false)
		{
			deathCycle = true;
			foreach (Transform child in transform)
			{
				child.renderer.materials[1].color = Color.red;
			}
			animate.Play("Explosion");
		}
		
		if (Time.timeScale == 0.5f)
		{
			spawn.count--;
			destroyCycle = false;
			deathCycle = false;
			Destroy(gameObject);
		}
		
		else if (deathCycle)
		{
			if(!animate.IsPlaying("Explosion"))
			{
				Time.timeScale = 0.0f;
			}
		}
		
		else if (destroyCycle)
		{
			if (!animate.IsPlaying("Explosion"))
			{
				spawn.count--;
				Destroy(gameObject);
				destroyCycle = false;
			}
		}
	}
}
