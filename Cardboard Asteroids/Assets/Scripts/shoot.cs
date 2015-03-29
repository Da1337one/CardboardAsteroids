using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour
{
	void Update ()
	{
		transform.position =  transform.position + transform.forward;
	}
}
