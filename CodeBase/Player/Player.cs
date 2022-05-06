using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    
    [SerializeField] private float _moveSpeed = 0f;
    [SerializeField] private float _deshImpuls = 0f;

    private PlayerInput _input;

    private Vector2 _moveDirection; 
    private Vector2 _deshDirection; 
    private Rigidbody2D _rigidBody;

    private void Awake() {
        _input = new PlayerInput();
        _rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }
    private void OnEnable() {
        _input.Enable();
    }

    private void OnDisable() {
        _input.Disable();
    }

    private void FixedUpdate()
    {
        Move(direction);
    }

    private void Move(Vector2 direction){
        direction = _input.Player.Move.ReadValue<Vector2>();
        _rigidBody.velocity = direction * _moveSpeed * Time.deltaTime;
    }
}
