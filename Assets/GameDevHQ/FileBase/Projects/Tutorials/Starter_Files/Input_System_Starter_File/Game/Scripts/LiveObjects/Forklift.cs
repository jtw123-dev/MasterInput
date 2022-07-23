using System;
using UnityEngine;
using Cinemachine;
using UnityEngine.InputSystem;

namespace Game.Scripts.LiveObjects
{
    public class Forklift : MonoBehaviour
    {
        [SerializeField]
        private GameObject _lift, _steeringWheel, _leftWheel, _rightWheel, _rearWheels;
        [SerializeField]
        private Vector3 _liftLowerLimit, _liftUpperLimit;
        [SerializeField]
        private float _speed = 5f, _liftSpeed = 1f;
        [SerializeField]
        private CinemachineVirtualCamera _forkliftCam;
        [SerializeField]
        private GameObject _driverModel;
        public bool _inDriveMode = false;
        [SerializeField]
        private InteractableZone _interactableZone;

        public static event Action onDriveModeEntered;
        public static event Action onDriveModeExited;
        private bool _lifting, _lowering;

        private InputPlayerActions _input;
        
        private void Start()
        {
            _input = new InputPlayerActions();
            _input.Forklift.Enable();
            _input.Forklift.Escape.performed += Escape_performed;
            _input.Forklift.LiftUp.performed += LiftUp_performed;
            _input.Forklift.LiftUp.canceled += LiftUp_canceled;
            _input.Forklift.Lower.performed += Lower_performed;
            _input.Forklift.Lower.canceled += Lower_canceled;
        }

        private void Lower_canceled(InputAction.CallbackContext obj)
        {
            _lowering = false;
        }

        private void Lower_performed(InputAction.CallbackContext obj)
        {
            _lowering = true;
        }

        private void LiftUp_canceled(InputAction.CallbackContext obj)
        {
            _lifting = false;
        }

        private void LiftUp_performed(InputAction.CallbackContext obj)
        {
            _lifting = true;
        }

        private void Escape_performed(InputAction.CallbackContext obj)
        {
                ExitDriveMode();
        }

        private void OnEnable()
        {
            InteractableZone.onZoneInteractionComplete += EnterDriveMode;
        }

        private void EnterDriveMode(InteractableZone zone)
        {
            if (_inDriveMode !=true && zone.GetZoneID() == 5) //Enter ForkLift
            {
                _inDriveMode = true;
                _forkliftCam.Priority = 11;
                onDriveModeEntered?.Invoke();
                _driverModel.SetActive(true);
                _interactableZone.CompleteTask(5);
            }
        }

        private void ExitDriveMode()
        {
            _inDriveMode = false;
            _forkliftCam.Priority = 9;            
            _driverModel.SetActive(false);
            onDriveModeExited?.Invoke();           
        }

        private void Update()
        {
            if (_inDriveMode == true)
            {
                LiftControls();
                CalcutateMovement();         
            }
        }

        private void CalcutateMovement()
        {
            var rotateDirection = _input.Forklift.Rotation.ReadValue<float>();
            transform.Rotate(transform.up, rotateDirection);

            var move = _input.Forklift.Drive.ReadValue<Vector2>();
            transform.Translate(new Vector3(move.x, 0, move.y) * Time.deltaTime * 5);
        }

        private void LiftControls()
        {
            if (_lifting==true)
            {
                LiftUpRoutine();
            }              
            else if (_lowering==true)
            {
                LiftDownRoutine();
            }             
        }

        private void LiftUpRoutine()
        {
            if (_lift.transform.localPosition.y < _liftUpperLimit.y)
            {
                Vector3 tempPos = _lift.transform.localPosition;
                tempPos.y += Time.deltaTime * _liftSpeed;
                _lift.transform.localPosition = new Vector3(tempPos.x, tempPos.y, tempPos.z);
            }
            else if (_lift.transform.localPosition.y >= _liftUpperLimit.y)
                _lift.transform.localPosition = _liftUpperLimit;
        }

        private void LiftDownRoutine()
        {
            if (_lift.transform.localPosition.y > _liftLowerLimit.y)
            {
                Vector3 tempPos = _lift.transform.localPosition;
                tempPos.y -= Time.deltaTime * _liftSpeed;
                _lift.transform.localPosition = new Vector3(tempPos.x, tempPos.y, tempPos.z);
            }
            else if (_lift.transform.localPosition.y <= _liftUpperLimit.y)
                _lift.transform.localPosition = _liftLowerLimit;
        }

        private void OnDisable()
        {
            InteractableZone.onZoneInteractionComplete -= EnterDriveMode;
        }

    }
}