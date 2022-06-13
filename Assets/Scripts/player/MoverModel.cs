using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoverModel: MonoBehaviour
{
    private MoveUseCase _move;
    private JumpUseCase _jump;
    private ChangeLineUseCase _changeLine;
    private Transform _transform;
    
    // Статусы
    public float Speed { get; set; }
    private bool _isRun;

    private void Start()
    {
        _move = gameObject.AddComponent<MoveUseCase>();
        _jump = gameObject.AddComponent<JumpUseCase>();
        _changeLine = gameObject.AddComponent<ChangeLineUseCase>();
        _transform = GetComponent<Transform>();

        _isRun = false;
    }

    public void StartRun()
    {
        _isRun = true;
    }

    private void Update()
    {
        if (_isRun)
        {
            _transform.position += _move.Move(Vector3.forward, Speed);
        } 
    }
}

