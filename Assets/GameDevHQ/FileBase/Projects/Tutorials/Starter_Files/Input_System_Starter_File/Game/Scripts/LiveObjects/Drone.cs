using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using Game.Scripts.UI;

namespace Game.Scripts.LiveObjects
{
    public class Drone : MonoBehaviour
    {
        private enum Tilt
        {
            NoTilt, Forward, Back, Left, Right
        }

        [SerializeField]
        private Rigidbody _rigidbody;
        [SerializeField]
        private float _speed = 5f;
        public bool _inFlightMode = false;
        [SerializeField]
        private Animator _propAnim;
        [SerializeField]
        private CinemachineVirtualCamera _droneCam;
        [SerializeField]
        private InteractableZone _interactableZone;
        private InputPlayerActions _input;
        private bool _rotateLeft;
        private bool _rotateRight;

        private bool _rotateW, _rotateS, _rotateD, _rotateA;
        private bool _thrust, _reverseThrust;

        public static event Action OnEnterFlightMode;
        public static event Action onExitFlightmode; 

        private void Start()
        {
            _input = new InputPlayerActions();
            _input.Drone.Enable();
            
            _input.Drone.Escape.performed += Escape_performed;
            _input.Drone.RotateLeft.performed += RotateLeft_performed;
            _input.Drone.RotateRight.performed += RotateRight_performed;
            _input.Drone.RotateLeft.canceled += RotateLeft_canceled;
            _input.Drone.RotateRight.canceled += RotateRight_canceled;

            _input.Drone.RotateA.performed += RotateA_performed;
            _input.Drone.RotateA.canceled += RotateA_canceled;
            _input.Drone.RotateD.performed += RotateD_performed;
            _input.Drone.RotateD.canceled += RotateD_canceled;
            _input.Drone.RotateS.performed += RotateS_performed;
            _input.Drone.RotateS.canceled += RotateS_canceled;
            _input.Drone.RotateW.performed += RotateW_performed;
            _input.Drone.RotateW.canceled += RotateW_canceled;

            _input.Drone.Thrust.performed += Thrust_performed;
            _input.Drone.Thrust.canceled += Thrust_canceled;
            _input.Drone.ReverseThrust.performed += ReverseThrust_performed;
            _input.Drone.ReverseThrust.canceled += ReverseThrust_canceled;
        }

        private void ReverseThrust_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _reverseThrust = false;
        }

        private void ReverseThrust_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _reverseThrust = true;
        }

        private void Thrust_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _thrust = false;
        }

        private void Thrust_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _thrust = true;
        }

        private void RotateW_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _rotateW = false;
        }

        private void RotateW_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _rotateW = true;
        }

        private void RotateS_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _rotateS = false;
        }

        private void RotateS_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _rotateS = true;
        }

        private void RotateD_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _rotateD = false;
        }

        private void RotateD_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _rotateD = true;
        }

        private void RotateA_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _rotateA = false;
        }

        private void RotateA_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _rotateA = true;
        }

        private void RotateRight_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _rotateRight = false;
        }

        private void RotateLeft_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _rotateLeft = false;
        }

        private void RotateRight_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _rotateRight = true;               
        }
        private void RotateLeft_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _rotateLeft = true;         
        }
       private void RotateDrone()
        {
            if (_rotateLeft==true)
            {
                var tempRot = transform.localRotation.eulerAngles;
                tempRot.y += _speed / 3;
                 transform.localRotation = Quaternion.Euler(tempRot);
            }

            else if (_rotateRight==true)
            {
                 var tempRot = transform.localRotation.eulerAngles;
                tempRot.y -= _speed / 3;
                transform.localRotation = Quaternion.Euler(tempRot);     
            }
        }              
        private void Escape_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _inFlightMode = false;
            onExitFlightmode?.Invoke();
            ExitFlightMode();
        }

        private void Movement_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            var rotateDirection = _input.Player.Rotation.ReadValue<float>();
            transform.Rotate(transform.up, rotateDirection);
        }

        private void OnEnable()
        {
            InteractableZone.onZoneInteractionComplete += EnterFlightMode;
        }

        private void EnterFlightMode(InteractableZone zone)
        {
            if (_inFlightMode != true && zone.GetZoneID() == 4) // drone Scene
            {
                _propAnim.SetTrigger("StartProps");
                _droneCam.Priority = 11;
                _inFlightMode = true;
                OnEnterFlightMode?.Invoke();
                UIManager.Instance.DroneView(true);
                _interactableZone.CompleteTask(4);
            }
        }

        private void ExitFlightMode()
        {            
            _droneCam.Priority = 9;
            _inFlightMode = false;
            UIManager.Instance.DroneView(false);            
        }

        private void Update()
        {
            if (_inFlightMode)
            {        
                RotateDrone();             
                CalculateTilt();       
            }
        }

        private void FixedUpdate()
        {
            _rigidbody.AddForce(transform.up * (9.81f), ForceMode.Acceleration);
            if (_inFlightMode)
                CalculateMovementFixedUpdate();
        }
        private void CalculateMovementFixedUpdate()
        {           
            if (_thrust==true)
            {
                _rigidbody.AddForce(transform.up * _speed, ForceMode.Acceleration);
            }

            if (_reverseThrust==true)

            {
                _rigidbody.AddForce(-transform.up * _speed, ForceMode.Acceleration);
            }
        }

        private void CalculateTilt()
        {
            if (_rotateA==true)
            {
                transform.rotation = Quaternion.Euler(00, transform.localRotation.eulerAngles.y, 30);
            }
            else if (_rotateD==true)
            {
                transform.rotation = Quaternion.Euler(0, transform.localRotation.eulerAngles.y, -30);
            }
            
            else if (_rotateW==true)
            {
                transform.rotation = Quaternion.Euler(30, transform.localRotation.eulerAngles.y, 0);
            }
            else if (_rotateS==true)
            {
                transform.rotation = Quaternion.Euler(-30, transform.localRotation.eulerAngles.y, 0);
            }
            else
                transform.rotation = Quaternion.Euler(0, transform.localRotation.eulerAngles.y, 0); 
        }

        private void OnDisable()
        {
            InteractableZone.onZoneInteractionComplete -= EnterFlightMode;
        }
    }
}
