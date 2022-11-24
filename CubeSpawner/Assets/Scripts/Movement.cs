using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _range;

    public GameObject cube;
    private Vector3 _target;

    void Start()
    {
        _target = new Vector3(transform.position.x + _range, 0, 0);
        cube = GameObject.FindGameObjectWithTag("Player");
    }

    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);
        if (transform.position == _target)
        {
            Destroy(cube);
        }
    }
}
