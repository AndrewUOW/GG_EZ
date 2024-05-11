using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisableLights : MonoBehaviour
{
    [SerializeField] private Light targetLight;
    private bool lightState = false;
    public void EnableDisableLight()
    {
        lightState = !lightState;
        targetLight.enabled = lightState;
    }
}
