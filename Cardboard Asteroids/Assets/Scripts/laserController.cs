using UnityEngine;
using System.Collections;

public class laserController : MonoBehaviour 
{
 	public GameObject template;
	private string privilege = "checked";

	void Update ()
	{
		if (Cardboard.SDK.CardboardTriggered && Time.timeScale != 0.0f)
		{
			if (privilege == "checked")
			{
				GameObject laser = (GameObject)Instantiate(template, transform.position - (5 * transform.forward), transform.rotation/*Quaternion.Euler(new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 90, transform.eulerAngles.z))*/);
				//GameObject laser2 = (GameObject)Instantiate(template, new Vector3(transform.position.x + 3, transform.position.y, transform.position.z), transform.rotation/*Quaternion.Euler(new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 90, transform.eulerAngles.z))*/);
				//laser.transform.Rotate(0, 90, 0);
			}
		}

		else if (Cardboard.SDK.CardboardTriggered)
		{
			Time.timeScale = 0.5f;
		}
	}
}