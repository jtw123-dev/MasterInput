using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Scripts.UI;
using UnityEngine.InputSystem;


namespace Game.Scripts.LiveObjects
{
    public class InteractableZone : MonoBehaviour
    {
        private enum ZoneType
        {
            Collectable,
            Action,
            HoldAction
        }

        private enum KeyState
        {
            Press,
            PressHold
        }
        [SerializeField]
        private bool _explosionTrue;
        [SerializeField] bool _boxTrue;
        private InputPlayerActions _input;
        [SerializeField]
        private ZoneType _zoneType;
        [SerializeField]
        private int _zoneID;
        [SerializeField]
        private int _requiredID;
        [SerializeField]
        [Tooltip("Press the (---) Key to .....")]
        private string _displayMessage;
        [SerializeField]
        private GameObject[] _zoneItems;
        private bool _inZone = false;
        private bool _itemsCollected = false;
        private bool _actionPerformed = false;
        [SerializeField]
        private Sprite _inventoryIcon;
        [SerializeField]
        private string _zoneKeyInput;
        [SerializeField]
        private KeyState _keyState;
        [SerializeField]
        private GameObject _marker;      
        private bool _inHoldState = false;
        private Crate _crate;
        public bool _isPunchHeld;
        
        private static int _currentZoneID = 0;
        public static int CurrentZoneID
        { 
            get 
            { 
               return _currentZoneID; 
            }
            set
            {
                _currentZoneID = value; 
                         
            }
        }

        public static event Action<InteractableZone> onZoneInteractionComplete;
        public static event Action<int> onHoldStarted;
        public static event Action<int> onHoldEnded;

        private void Start()
        {
            _crate = GameObject.Find("Breakable_Wooden_Crate").GetComponent<Crate>();

            if (_crate==null)
            {
                Debug.LogError("crate is null");
            }
            _input = new InputPlayerActions();
            _input.Player.Enable();
            _input.Player.Interaction.performed += Interaction_performed;
            _input.Player.Interaction.canceled += Interaction_canceled;
            _input.Player.Explosion.performed += Explosion_performed;
            _input.Player.QuickPunch.performed += QuickPunch_performed;
            _input.Player.SlowPunch.performed += SlowPunch_performed;
            _input.Player.SlowPunch.canceled += SlowPunch_canceled;
        }

        private void SlowPunch_canceled(InputAction.CallbackContext obj)
        {
            _isPunchHeld = false;
        }

        private void SlowPunch_performed(InputAction.CallbackContext obj)
        {
            if (_inZone == true && _explosionTrue == false && _boxTrue == true)
            {
                _isPunchHeld = true;
                if (_keyState != KeyState.PressHold)
                {
                    //press
                    switch (_zoneType)
                    {
                        case ZoneType.Action:
                            if (_actionPerformed == false)
                            {
                                Debug.Log("Slow punch performed");
                                PerformAction();
                                _actionPerformed = true;
                                UIManager.Instance.DisplayInteractableZoneMessage(false);
                            }
                            break;
                    }
                }
            }
          
        }

        private void QuickPunch_performed(InputAction.CallbackContext obj)
        {
            if (_inZone == true && _explosionTrue == false &&_boxTrue==true)
            {

                if (_keyState != KeyState.PressHold)
                {
                    //press
                    switch (_zoneType)
                    {                    
                        case ZoneType.Action:
                            if (_actionPerformed == false)
                            {

                                PerformAction();
                                _actionPerformed = true;
                                UIManager.Instance.DisplayInteractableZoneMessage(false);
                            }
                            break;
                    }
                }              
            }
            }

        private void Explosion_performed(InputAction.CallbackContext obj)
        {       
            if (_inZone == true && _explosionTrue==true )
            {
                if (_keyState != KeyState.PressHold)
                {                   
                    //press
                    switch (_zoneType)
                    { 
                        case ZoneType.Action:
                            if (_actionPerformed == false)
                            {
                                PerformAction();
                                _actionPerformed = true;
                                UIManager.Instance.DisplayInteractableZoneMessage(false);
                                _explosionTrue = false;
                            }
                            break;
                    }
                }            
            }
        }

        private void Interaction_performed(InputAction.CallbackContext obj)
        {      
            if (_inZone == true && _explosionTrue==false &&_boxTrue==false)
            {

                if ( _keyState != KeyState.PressHold)
                {
                    //press
                    switch (_zoneType)
                    {
                        case ZoneType.Collectable:
                            if (_itemsCollected == false)
                            {
                                CollectItems();
                                _itemsCollected = true;
                                UIManager.Instance.DisplayInteractableZoneMessage(false);
                            }
                            break;

                        case ZoneType.Action:
                            if (_actionPerformed == false)
                            {                                
                                    PerformAction();
                                    Debug.Log("Action performed");
                                    _actionPerformed = true;
                                    UIManager.Instance.DisplayInteractableZoneMessage(false);                                                       
                            }
                            break;
                    }
                }
                else if ( _keyState == KeyState.PressHold && _inHoldState == false)
                {
                    _inHoldState = true;

                    switch (_zoneType)
                    {
                        case ZoneType.HoldAction:
                            PerformHoldAction();
                            break;
                    }
                }
            }
            }

        private void Interaction_canceled(InputAction.CallbackContext obj)
        {
            if (_keyState == KeyState.PressHold)
                {
                  _inHoldState = false;
                  onHoldEnded?.Invoke(_zoneID);
               }
        }

        private void OnEnable()
        {
            InteractableZone.onZoneInteractionComplete += SetMarker;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player") && _currentZoneID > _requiredID)
            {
                switch (_zoneType)
                {
                    case ZoneType.Collectable:
                        if (_itemsCollected == false)
                        {
                            _inZone = true;
                            if (_displayMessage != null)
                            {
                                string message = $"Press the {_zoneKeyInput.ToString()} key to {_displayMessage}.";
                                UIManager.Instance.DisplayInteractableZoneMessage(true, message);
                            }
                            else
                                UIManager.Instance.DisplayInteractableZoneMessage(true, $"Press the {_zoneKeyInput.ToString()} key to collect");
                        }
                        break;

                    case ZoneType.Action:
                        if (_actionPerformed == false)
                        {
                            _inZone = true;
                            if (_displayMessage != null)
                            {
                                string message = $"Press the {_zoneKeyInput.ToString()} key to {_displayMessage}.";
                                UIManager.Instance.DisplayInteractableZoneMessage(true, message);
                            }
                            else
                                UIManager.Instance.DisplayInteractableZoneMessage(true, $"Press the {_zoneKeyInput.ToString()} key to perform action");
                        }
                        break;

                    case ZoneType.HoldAction:
                        _inZone = true;
                        if (_displayMessage != null)
                        {
                            string message = $"Hold the {_zoneKeyInput.ToString()} key to {_displayMessage}.";
                            UIManager.Instance.DisplayInteractableZoneMessage(true, message);
                        }
                        else
                            UIManager.Instance.DisplayInteractableZoneMessage(true, $"Hold the {_zoneKeyInput.ToString()} key to perform action");
                        break;
                }
            }
        }

        private void CollectItems()
        {
            foreach (var item in _zoneItems)
            {
                item.SetActive(false);
            }

            UIManager.Instance.UpdateInventoryDisplay(_inventoryIcon);

            CompleteTask(_zoneID);

            onZoneInteractionComplete?.Invoke(this);
        }

        private void PerformAction()
        {
            foreach (var item in _zoneItems)
            {
                item.SetActive(true);
            }

            if (_inventoryIcon != null)
                UIManager.Instance.UpdateInventoryDisplay(_inventoryIcon);

            onZoneInteractionComplete?.Invoke(this);
        }

        private void PerformHoldAction()
        {
            UIManager.Instance.DisplayInteractableZoneMessage(false);
            onHoldStarted?.Invoke(_zoneID);
            Debug.Log("Holding worked");
        }

        public GameObject[] GetItems()
        {
            return _zoneItems;
        }

        public int GetZoneID()
        {
            return _zoneID;
        }

        public void CompleteTask(int zoneID)
        {
            if (zoneID == _zoneID)
            {
                _currentZoneID++;
                onZoneInteractionComplete?.Invoke(this);
            }
        }

        public void ResetAction(int zoneID)
        {
            if (zoneID == _zoneID)
                _actionPerformed = false;
        }

        public void SetMarker(InteractableZone zone)
        {
            if (_zoneID == _currentZoneID)
                _marker.SetActive(true);
            else
                _marker.SetActive(false);
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                _inZone = false;
                UIManager.Instance.DisplayInteractableZoneMessage(false);
            }
        }

        private void OnDisable()
        {
            InteractableZone.onZoneInteractionComplete -= SetMarker;
        }       
        
    }
}


