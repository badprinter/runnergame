using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToObject : MonoBehaviour
{
    
    [SerializeField] private GameObject _obj;
    [SerializeField] private Vector3 offset = new Vector3(0, -4, 10);
    [SerializeField] private float Speed;
    private Transform _target;
    
    // Start is called before the first frame update
    void Start()
    {
        _target = _obj.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (_target.position - offset); // * (Time.deltaTime * Speed);
        transform.LookAt(_target.position);
    }
}
