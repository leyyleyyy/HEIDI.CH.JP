using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAppears : MonoBehaviour
{
    // when pinch is detected, make a sphere fall 

    public void OnPinch()
    {

        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = new Vector3(0, 10, 0);

    }

}
