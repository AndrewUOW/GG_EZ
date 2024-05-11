using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    GameObject[] Lights;

    private void Start()
    {
        CheckTag();
        Lights[0].GetComponent<Light>().enabled = false;
    }

    void CheckTag()
    {
        Lights = GameObject.FindGameObjectsWithTag("Light");
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Enter " + collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Collision Exit " + collision.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter " + other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit " + other.gameObject.name);
    }
}
