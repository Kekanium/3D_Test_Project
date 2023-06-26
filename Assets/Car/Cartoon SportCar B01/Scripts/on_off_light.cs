using UnityEngine;
using System.Collections;

public class on_off_light : MonoBehaviour
{

	public Light[] lights;
	public KeyCode keyboard;


	void Update ()
	{
		foreach (Light light in lights)
		{
			if (SimpleInput.GetButtonDown("Lights"))
			{
				print("Lights");
				light .enabled = !light .enabled;
			}
		}
	}
}

