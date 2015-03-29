using UnityEngine;
using System.Collections;

public class spawnAsteroids : MonoBehaviour
{
	public GameObject template1;
	public GameObject template2;
	public GameObject template3;

	public int count;

	void Start()
	{
		Time.timeScale = 1.0f;
		count = 0;
	}

	void LateUpdate ()
	{
		int rand1 = Random.Range(1, 50);

		if (rand1 == 8 && count < 7 && Time.timeScale == 1.0f)
		{
			Vector3 direction = Random.onUnitSphere;
			float distance = 20 * Random.value + 10f;

			int rand2 = Random.Range(1, 19);

			if (rand2 <= 7)
			{
				GameObject asteroid = (GameObject)Instantiate(template1, direction * distance, transform.rotation);
			}

			else if (rand2 <= 14)
			{
				GameObject asteroid = (GameObject)Instantiate(template2, direction * distance, transform.rotation);
			}

			else
			{
				GameObject asteroid = (GameObject)Instantiate(template3, direction * distance, transform.rotation);
			}

			count++;
		}

		else if (Time.timeScale == 0.5f)
		{
			Time.timeScale = 1.0f;
		}
	}
}
