using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsMovement : MonoBehaviour
{
    [SerializeField] private Surface _surface;
    [SerializeField] private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        _surface = gameObject.AddComponent<Surface>();
    }

    public void Move(Vector3 directional, float speed)
    {
        Vector3 directionalAlongSurface = _surface.Project(directional.normalized);
        Vector3 offset = directionalAlongSurface * (speed * Time.deltaTime);
        
        _rigidbody.MovePosition(_rigidbody.position + offset);
    }
}
