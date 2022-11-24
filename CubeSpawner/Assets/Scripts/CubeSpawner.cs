using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{

    public GameObject cube;
    public void Start()
    {
        ;
    }
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody cubeClone = Instantiate(cube, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
        }
    }
}

