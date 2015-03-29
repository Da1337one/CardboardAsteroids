using UnityEngine;
using System.Collections;

public class crosshair : MonoBehaviour
{
	public Texture2D chtext;
	public Texture2D gameover;
	public Texture2D click2restart;
	public long score = 0;
	private bool add2it = false;

	void OnGUI()
	{

		if (Time.timeScale == 0.0f)
		{
			GUI.DrawTexture(new Rect((Screen.width / 4) - 200, (Screen.height + (Screen.height * (18.0f / 1080)) - 150) / 2, 400, 200), gameover);
			GUI.DrawTexture(new Rect(((3 * Screen.width) / 4) + (Screen.width * (38.0f / 1920)) - 200, (Screen.height + (Screen.height * (18.0f / 1080)) - 150) / 2, 400, 200), gameover);

			//GUI.DrawTexture(new Rect((Screen.width / 4) - 100, (Screen.height + (Screen.height * (18.0f / 1080)) - 50) / 2, 200, 100), click2restart);
			//GUI.DrawTexture(new Rect(((3 * Screen.width) / 4) + (Screen.width * (38.0f / 1920)) - 100, (Screen.height + (Screen.height * (18.0f / 1080)) - 50) / 2, 200, 100), click2restart);
		}

		else
		{
			GUI.DrawTexture(new Rect((Screen.width / 4) - 12.5f, (Screen.height + (Screen.height * (18.0f / 1080)) - 12.5f) / 2, 25, 25), chtext);
			GUI.DrawTexture(new Rect(((3 * Screen.width) / 4) /*+ (Screen.width * (38.0f / 1920))*/ - 12.5f, (Screen.height + (Screen.height * (18.0f / 1080)) - 12.5f) / 2, 25, 25), chtext);
		} 	

		GUI.Label(new Rect((3 * Screen.width / 16) - 70, (Screen.height / 5) + (Screen.height * (18.0f / 1080)) - 15, 100, 30), "Score: " + score.ToString());
		GUI.Label(new Rect(((11 * Screen.width) / 16) - 70, (Screen.height / 5) + (Screen.height * (18.0f / 1080)) - 15, 100, 30), "Score: " + score.ToString());
	}

	void LateUpdate()
	{
		if (Time.timeScale == 1.0f)
		{
			if (add2it)
			{
				score++;
				add2it = false;
			}

			else
			{
				add2it = true;
			}
		}

		else if (Time.timeScale == 0.5f)
		{
			score = 0;
		}
	}
}
