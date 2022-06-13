using System;
using System.Collections;
using System.Runtime.Serialization;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [field: SerializeField] private float Speed { get; set; }
    [SerializeField] private AnimationCurve _animation;
    [SerializeField] private float height = 5;
    [SerializeField] private float Jump_Duration = 3;
    private Transform _transform;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _transform = gameObject.GetComponent<Transform>();
        _rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
       RunForward(Vector3.forward, Speed);
       if (Input.GetKeyDown("space"))
       {
           StartCoroutine(Jump(_transform, Jump_Duration));
       }
       
    }

    private IEnumerator Jump(Transform jumper, float duration)
    {
        float expiredSeconds = 0f;
        float progress = 0f;
        Vector3 startPosition = jumper.position;
        
        while (progress <= 1f)
        {
            expiredSeconds += Time.fixedDeltaTime;
            progress = expiredSeconds / duration;

            float yPos = _animation.Evaluate(progress) * height;
            
            jumper.position += new Vector3(0,startPosition.y - transform.position.y + yPos,0);
            Debug.Log($"Express seconds {expiredSeconds}, Progress {progress}, Ypos {yPos}, Evaluate {_animation.Evaluate(progress)}");
            yield return null; 
        }
    }

    private void RunForward(Vector3 target, float speed)
    {
        transform.position += target * (Time.deltaTime * speed);
    }

}
