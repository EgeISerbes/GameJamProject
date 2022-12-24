using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    //[SerializeField] private InputManager _inputManager;
    private Rigidbody2D _rb2D;
    [SerializeField] private float _speedH,_speedV,_approachSpeed;
    [SerializeField] private Joystick _joystick;
    private float _horizontalMove;
    private float _verticalMove;
  
    void Start()
    {
        _rb2D = gameObject.GetComponent<Rigidbody2D>();
        
    }

    
    // Update is called once per frame
    void Update()
    {
        ProcessMovement();
    }
    private void ProcessMovement()
    {
        _horizontalMove = _joystick.Horizontal * _speedH*Time.deltaTime;
        _verticalMove = _joystick.Vertical * _speedV*Time.deltaTime;
        _rb2D.MovePosition(Vector2.MoveTowards(_rb2D.position, _rb2D.position + new Vector2(_horizontalMove, _verticalMove), _approachSpeed * Time.deltaTime));

    }
}
