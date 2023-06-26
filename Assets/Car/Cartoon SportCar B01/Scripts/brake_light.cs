using UnityEngine;
using System.Collections;

public class brake_light : MonoBehaviour {

    public Light[] lights;




    void Update() {

        if (SimpleInput.GetButton("Handbrake")||SimpleInput.GetAxis("Vertical") < 0f)
        {
            foreach (Light light in lights)
            {
                light.enabled = true;
            }
        }
        else
        {
            foreach (Light light in lights)
            {
                light.enabled = false;
            }
        }
    }
}