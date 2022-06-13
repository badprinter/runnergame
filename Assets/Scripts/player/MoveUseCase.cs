using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUseCase : MonoBehaviour
{
    public Vector3 Move(Vector3 target, float speed)
    {
        return target * (Time.deltaTime * speed);
    }
}
