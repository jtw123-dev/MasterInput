using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private InputPlayerActions _input;
    // Start is called before the first frame update
    void Start()
    {
        _input = new InputPlayerActions();
        _input.Player.Enable();
        _input.Player.Movement.performed += Movement_performed;
        _input.Player.Rotation.performed += Rotation_performed;
    }

    private void Rotation_performed(InputAction.CallbackContext obj)
    {
        throw new System.NotImplementedException();
    }

    private void Movement_performed(InputAction.CallbackContext obj)
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var rotateDirection = _input.Player.Rotation.ReadValue<float>();
        transform.Rotate(Vector3.up * Time.deltaTime * 90f * rotateDirection);



        var move = _input.Player.Movement.ReadValue<Vector2>();
        transform.Translate( new Vector3 (move.x,0,move.y) * Time.deltaTime * 5);
    }
}
