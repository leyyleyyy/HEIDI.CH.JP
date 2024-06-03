using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Hands.Samples.VisualizerSample;

public class TakePic : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;

    // i want to change the color of the cube when two other cubes collides
    void OnTriggerEnter(Collider other)
    {
        //if (collision.gameObject.name == "Cube1" && collision.gameObject.name == "Cube2")
        {
            cube.GetComponent<Renderer>().material.color = Color.blue;
            Invoke("SpawnSphere", 1.5f);

        }
    }

    void SpawnSphere()
    {
        // Set the initial position of the sphere high above the ground
        Vector3 spawnPosition = new Vector3(0, 50, 0);

        // Instantiate a new sphere at the spawn position
        GameObject newSphere = Instantiate(sphere, spawnPosition, Quaternion.identity);

        // Ensure the sphere is active
        newSphere.SetActive(true);

        // Ensure the sphere has a Rigidbody component so it's affected by gravity
        if (newSphere.GetComponent<Rigidbody>() == null)
        {
            newSphere.AddComponent<Rigidbody>();
        }
    }
}