﻿using UnityEngine;
using System.Collections;

public class UFOrotator : MonoBehaviour
{
	void Update()
	{
		transform.Rotate(new Vector3(0, 50, 0) * Time.deltaTime);
	}
}