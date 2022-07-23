using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Scripts.LiveObjects;
using Cinemachine;
using UnityEngine.InputSystem;

namespace Game.Scripts.Player
{
    [RequireComponent(typeof(CharacterController))]
    public class Player : MonoBehaviour
    {
        private CharacterController _controller;
        private Animator _anim;
        [SerializeField]
        private float _speed = 5.0f;
        private bool _playerGrounded;
        [SerializeField]
        private Detonator _detonator;
        private bool _canMove = true;
        [SerializeField]
        private CinemachineVirtualCamera _followCam;
        [SerializeField]
        private GameObject _model;
        [SerializeField] private GameObject _playerModel;

        public bool explosionTrue;
        private InputPlayerActions _input;

        private Drone _drone;
        private Forklift _forklift;

        private void OnEnable()
        {
            InteractableZone.onZoneInteractionComplete += InteractableZone_onZoneInteractionComplete;
            Laptop.onHackComplete += ReleasePlayerControl;
            Laptop.onHackEnded += ReturnPlayerControl;
            Forklift.onDriveModeEntered += ReleasePlayerControl;
            Forklift.onDriveModeExited += ReturnPlayerControl;
            Forklift.onDriveModeEntered += HidePlayer;
            Drone.OnEnterFlightMode += ReleasePlayerControl;
            Drone.onExitFlightmode += ReturnPlayerControl;
        } 

        private void Start()
        {

            _model.SetActive(false);
            _forklift = GameObject.Find("Fork_Lift").GetComponent<Forklift>();

            {
                if (_forklift==null)
                {
                    Debug.LogError("No forklift present.");
                }
            }

            _drone = GameObject.Find("DroneMaster").GetComponent<Drone>();

            if (_drone==null)
            {
                Debug.LogError("No drone present");
            }

            _controller = GetComponent<CharacterController>();

            if (_controller == null)
                Debug.LogError("No Character Controller Present");

            _anim = GetComponentInChildren<Animator>();

            if (_anim == null)
                Debug.Log("Failed to connect the Animator");

            _input = new InputPlayerActions();
            _input.Player.Enable();              
        }
        
        private void Update()
        {            
            if (_canMove == true)
                CalcutateMovement();

            if (_drone._inFlightMode == true)
            {
                _input.Player.Disable();
            }
            else
            {
                _input.Player.Enable();
            }

            if (_forklift._inDriveMode==true)
            {
                _input.Player.Movement.Disable();
                _model.SetActive(true);
                _playerModel.SetActive(false);
            }
            else
            {        
                _model.SetActive(false);
                _input.Player.Movement.Enable();
                _playerModel.SetActive(true);     
            }
            
        }

        private void CalcutateMovement()
        {
            var rotateDirection = _input.Player.Rotation.ReadValue<float>();
            transform.Rotate(transform.up, rotateDirection );

            var move = _input.Player.Movement.ReadValue<Vector2>();
            transform.Translate(new Vector3(move.x, 0, move.y) * Time.deltaTime * 5);

            _playerGrounded = _controller.isGrounded;
            _anim.SetFloat("Speed", Mathf.Abs(move.magnitude));
        }

        private void InteractableZone_onZoneInteractionComplete(InteractableZone zone)
        {
            switch(zone.GetZoneID())
            {
                case 1: //place c4
                    _detonator.Show();
                    break;
                case 2: //Trigger Explosion
                    TriggerExplosive();
                    break;
            }
        }

        private void ReleasePlayerControl()
        {
            _canMove = false;
            _followCam.Priority = 9;
        }

        private void ReturnPlayerControl()
        {
            _model.SetActive(true);
            _canMove = true;
            _followCam.Priority = 10;
        }

        private void HidePlayer()
        {
            _model.SetActive(false);
        }
               
        private void TriggerExplosive()
        {         
            _detonator.TriggerExplosion();
        }

        private void OnDisable()
        {
            InteractableZone.onZoneInteractionComplete -= InteractableZone_onZoneInteractionComplete;
            Laptop.onHackComplete -= ReleasePlayerControl;
            Laptop.onHackEnded -= ReturnPlayerControl;
            Forklift.onDriveModeEntered -= ReleasePlayerControl;
            Forklift.onDriveModeExited -= ReturnPlayerControl;
            Forklift.onDriveModeEntered -= HidePlayer;
            Drone.OnEnterFlightMode -= ReleasePlayerControl;
            Drone.onExitFlightmode -= ReturnPlayerControl;
        }
    }
}

