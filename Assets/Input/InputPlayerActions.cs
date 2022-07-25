// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputPlayerActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputPlayerActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputPlayerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputPlayerActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""2f647ab6-c8c8-499a-9905-593b322087e5"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""131fa79f-33b8-43c3-a664-32b5a7e68236"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""fac5e0b9-317a-49cb-bd7a-bb587a2675e4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Explosion"",
                    ""type"": ""Button"",
                    ""id"": ""5be246a0-a98d-4016-8ec6-4eeb07acd8ee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""ab20030f-4fc9-4b81-8da2-8e1be9addd8a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""e7651ee0-0f60-4a69-9e39-ada008cc591c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""QuickPunch"",
                    ""type"": ""Button"",
                    ""id"": ""3dfca9ff-9766-4d59-b1de-fd9535fddac2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""MultiTap""
                },
                {
                    ""name"": ""SlowPunch"",
                    ""type"": ""Button"",
                    ""id"": ""f50a563f-2a96-4cc3-917c-a19406a1af5e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""fbd309c9-daf7-46b9-b11f-a85c460dcbe0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""30e33fc0-d79b-419c-8e65-b9a96879d9ee"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f332492e-22d2-46d7-a758-49f9ea9ea081"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""47abe66a-8b95-4b4c-b023-654d092baf08"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""482c6985-4678-4f8a-a6e9-b83e8c1d9703"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""91442447-4fb9-4e38-a783-f8f2200fb60c"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7b7de0f1-b0ab-4de6-9be1-0bfdca5ab8d8"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Explosion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0627c2c-611d-48a3-bc31-8c3c70304779"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""c6413dad-87bf-4392-81d0-ac8884c08384"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": ""InvertVector2"",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""591662db-c238-4ba6-871d-c2d6e0d43fe4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""14d957af-4b9d-419b-bf68-174567c24e89"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3ce102f0-39b5-4260-a7b2-385132c0edcc"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""MultiTap(tapCount=5)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""QuickPunch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11a73074-b404-4e93-b155-eb8ac546ad1b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SlowPunch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Drone"",
            ""id"": ""b14a43b6-50e2-4926-8136-d9d653b47354"",
            ""actions"": [
                {
                    ""name"": ""Thrust"",
                    ""type"": ""Button"",
                    ""id"": ""624929fb-1737-4ece-af4b-600b2f423831"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""bad17065-e5d7-443e-ab14-ca9ab3ce2758"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateLeft"",
                    ""type"": ""Button"",
                    ""id"": ""ac9f118b-644e-46fb-94c2-302aa5799107"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateRight"",
                    ""type"": ""Button"",
                    ""id"": ""e17d805a-85ac-4122-b46c-3d837d0d14e9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateA"",
                    ""type"": ""Button"",
                    ""id"": ""e8bded2c-7644-4a0a-9d8b-fe9748a555ce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateD"",
                    ""type"": ""Button"",
                    ""id"": ""66fb435b-ddf4-42f6-a5b5-cab3b9f8e406"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateW"",
                    ""type"": ""Button"",
                    ""id"": ""0a06c90d-c277-44d8-922e-7286cede28a1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateS"",
                    ""type"": ""Button"",
                    ""id"": ""d6bd24d2-c0ee-46ee-bb30-1dd7bf04a7c9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ReverseThrust"",
                    ""type"": ""Button"",
                    ""id"": ""276713f5-616e-4b63-bc0f-1e00b6ef4886"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""072ed341-f3b9-4867-a8eb-33bd93412a4a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thrust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""83b1bbd9-45e8-481b-9ed8-6c9e7bad0eef"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c40e474-829b-4aef-aab8-980b06ea4858"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a2d565f9-e90f-433c-badc-81de15bcb925"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ebdaed20-472a-486d-989b-d70c6e5c22ac"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateA"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93be8b36-b06a-4b7a-9588-b1dcc5c5140f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6c0f400-7fc5-4bcf-8350-b187dbfe7c18"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateW"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""44fe1f20-f58a-41d4-8505-c5fa03a333ae"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5bd8e831-3fa3-481e-b345-1ad50a550e20"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ReverseThrust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Forklift"",
            ""id"": ""c3c5e19d-20ad-4ac7-9ee6-b4189d6d8f10"",
            ""actions"": [
                {
                    ""name"": ""Drive"",
                    ""type"": ""Value"",
                    ""id"": ""52a62220-0cde-49cd-a4d9-f7738ec8031c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""ebe89a3e-2f96-4806-a294-c87cb1a834ab"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""d1597cb7-14b6-4f95-adf1-11ca96ea965e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LiftUp"",
                    ""type"": ""Button"",
                    ""id"": ""68fcacd8-7208-4a06-a11d-058d44f65847"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Lower"",
                    ""type"": ""Button"",
                    ""id"": ""b5fa6bdf-de22-4c27-accd-91f0ac792441"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""e46e3309-3828-46b4-ac8a-3b2e01d512e3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drive"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""fd18b829-6b89-4e82-897f-b6ea6a232412"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""25ec184b-773f-44b4-8107-358aed55f545"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4c56037d-4afd-4e47-bea9-a4b63ec2f861"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a9c5371c-a827-4c1b-b748-8c1719985562"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""fc455519-092c-470c-99c2-178a4881589a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""edce8f0c-b6b0-4202-a69f-0a3c0cc637b8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""da45978b-371e-42af-8770-7d1fd86d5296"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7ed7327e-6386-43b4-8162-5d481c6b4bf4"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a04395b-457a-4794-b552-a94e8eae7a85"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LiftUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28734b38-1b60-4bfc-ac67-52903ad6d7c5"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lower"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Interaction = m_Player.FindAction("Interaction", throwIfNotFound: true);
        m_Player_Explosion = m_Player.FindAction("Explosion", throwIfNotFound: true);
        m_Player_Escape = m_Player.FindAction("Escape", throwIfNotFound: true);
        m_Player_Rotation = m_Player.FindAction("Rotation", throwIfNotFound: true);
        m_Player_QuickPunch = m_Player.FindAction("QuickPunch", throwIfNotFound: true);
        m_Player_SlowPunch = m_Player.FindAction("SlowPunch", throwIfNotFound: true);
        // Drone
        m_Drone = asset.FindActionMap("Drone", throwIfNotFound: true);
        m_Drone_Thrust = m_Drone.FindAction("Thrust", throwIfNotFound: true);
        m_Drone_Escape = m_Drone.FindAction("Escape", throwIfNotFound: true);
        m_Drone_RotateLeft = m_Drone.FindAction("RotateLeft", throwIfNotFound: true);
        m_Drone_RotateRight = m_Drone.FindAction("RotateRight", throwIfNotFound: true);
        m_Drone_RotateA = m_Drone.FindAction("RotateA", throwIfNotFound: true);
        m_Drone_RotateD = m_Drone.FindAction("RotateD", throwIfNotFound: true);
        m_Drone_RotateW = m_Drone.FindAction("RotateW", throwIfNotFound: true);
        m_Drone_RotateS = m_Drone.FindAction("RotateS", throwIfNotFound: true);
        m_Drone_ReverseThrust = m_Drone.FindAction("ReverseThrust", throwIfNotFound: true);
        // Forklift
        m_Forklift = asset.FindActionMap("Forklift", throwIfNotFound: true);
        m_Forklift_Drive = m_Forklift.FindAction("Drive", throwIfNotFound: true);
        m_Forklift_Rotation = m_Forklift.FindAction("Rotation", throwIfNotFound: true);
        m_Forklift_Escape = m_Forklift.FindAction("Escape", throwIfNotFound: true);
        m_Forklift_LiftUp = m_Forklift.FindAction("LiftUp", throwIfNotFound: true);
        m_Forklift_Lower = m_Forklift.FindAction("Lower", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Interaction;
    private readonly InputAction m_Player_Explosion;
    private readonly InputAction m_Player_Escape;
    private readonly InputAction m_Player_Rotation;
    private readonly InputAction m_Player_QuickPunch;
    private readonly InputAction m_Player_SlowPunch;
    public struct PlayerActions
    {
        private @InputPlayerActions m_Wrapper;
        public PlayerActions(@InputPlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Interaction => m_Wrapper.m_Player_Interaction;
        public InputAction @Explosion => m_Wrapper.m_Player_Explosion;
        public InputAction @Escape => m_Wrapper.m_Player_Escape;
        public InputAction @Rotation => m_Wrapper.m_Player_Rotation;
        public InputAction @QuickPunch => m_Wrapper.m_Player_QuickPunch;
        public InputAction @SlowPunch => m_Wrapper.m_Player_SlowPunch;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Interaction.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteraction;
                @Interaction.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteraction;
                @Interaction.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteraction;
                @Explosion.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnExplosion;
                @Explosion.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnExplosion;
                @Explosion.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnExplosion;
                @Escape.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEscape;
                @Escape.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEscape;
                @Escape.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEscape;
                @Rotation.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotation;
                @QuickPunch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQuickPunch;
                @QuickPunch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQuickPunch;
                @QuickPunch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQuickPunch;
                @SlowPunch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSlowPunch;
                @SlowPunch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSlowPunch;
                @SlowPunch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSlowPunch;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Interaction.started += instance.OnInteraction;
                @Interaction.performed += instance.OnInteraction;
                @Interaction.canceled += instance.OnInteraction;
                @Explosion.started += instance.OnExplosion;
                @Explosion.performed += instance.OnExplosion;
                @Explosion.canceled += instance.OnExplosion;
                @Escape.started += instance.OnEscape;
                @Escape.performed += instance.OnEscape;
                @Escape.canceled += instance.OnEscape;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @QuickPunch.started += instance.OnQuickPunch;
                @QuickPunch.performed += instance.OnQuickPunch;
                @QuickPunch.canceled += instance.OnQuickPunch;
                @SlowPunch.started += instance.OnSlowPunch;
                @SlowPunch.performed += instance.OnSlowPunch;
                @SlowPunch.canceled += instance.OnSlowPunch;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Drone
    private readonly InputActionMap m_Drone;
    private IDroneActions m_DroneActionsCallbackInterface;
    private readonly InputAction m_Drone_Thrust;
    private readonly InputAction m_Drone_Escape;
    private readonly InputAction m_Drone_RotateLeft;
    private readonly InputAction m_Drone_RotateRight;
    private readonly InputAction m_Drone_RotateA;
    private readonly InputAction m_Drone_RotateD;
    private readonly InputAction m_Drone_RotateW;
    private readonly InputAction m_Drone_RotateS;
    private readonly InputAction m_Drone_ReverseThrust;
    public struct DroneActions
    {
        private @InputPlayerActions m_Wrapper;
        public DroneActions(@InputPlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Thrust => m_Wrapper.m_Drone_Thrust;
        public InputAction @Escape => m_Wrapper.m_Drone_Escape;
        public InputAction @RotateLeft => m_Wrapper.m_Drone_RotateLeft;
        public InputAction @RotateRight => m_Wrapper.m_Drone_RotateRight;
        public InputAction @RotateA => m_Wrapper.m_Drone_RotateA;
        public InputAction @RotateD => m_Wrapper.m_Drone_RotateD;
        public InputAction @RotateW => m_Wrapper.m_Drone_RotateW;
        public InputAction @RotateS => m_Wrapper.m_Drone_RotateS;
        public InputAction @ReverseThrust => m_Wrapper.m_Drone_ReverseThrust;
        public InputActionMap Get() { return m_Wrapper.m_Drone; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DroneActions set) { return set.Get(); }
        public void SetCallbacks(IDroneActions instance)
        {
            if (m_Wrapper.m_DroneActionsCallbackInterface != null)
            {
                @Thrust.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnThrust;
                @Thrust.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnThrust;
                @Thrust.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnThrust;
                @Escape.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnEscape;
                @Escape.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnEscape;
                @Escape.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnEscape;
                @RotateLeft.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnRotateLeft;
                @RotateLeft.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnRotateLeft;
                @RotateLeft.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnRotateLeft;
                @RotateRight.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnRotateRight;
                @RotateRight.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnRotateRight;
                @RotateRight.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnRotateRight;
                @RotateA.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnRotateA;
                @RotateA.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnRotateA;
                @RotateA.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnRotateA;
                @RotateD.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnRotateD;
                @RotateD.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnRotateD;
                @RotateD.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnRotateD;
                @RotateW.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnRotateW;
                @RotateW.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnRotateW;
                @RotateW.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnRotateW;
                @RotateS.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnRotateS;
                @RotateS.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnRotateS;
                @RotateS.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnRotateS;
                @ReverseThrust.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnReverseThrust;
                @ReverseThrust.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnReverseThrust;
                @ReverseThrust.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnReverseThrust;
            }
            m_Wrapper.m_DroneActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Thrust.started += instance.OnThrust;
                @Thrust.performed += instance.OnThrust;
                @Thrust.canceled += instance.OnThrust;
                @Escape.started += instance.OnEscape;
                @Escape.performed += instance.OnEscape;
                @Escape.canceled += instance.OnEscape;
                @RotateLeft.started += instance.OnRotateLeft;
                @RotateLeft.performed += instance.OnRotateLeft;
                @RotateLeft.canceled += instance.OnRotateLeft;
                @RotateRight.started += instance.OnRotateRight;
                @RotateRight.performed += instance.OnRotateRight;
                @RotateRight.canceled += instance.OnRotateRight;
                @RotateA.started += instance.OnRotateA;
                @RotateA.performed += instance.OnRotateA;
                @RotateA.canceled += instance.OnRotateA;
                @RotateD.started += instance.OnRotateD;
                @RotateD.performed += instance.OnRotateD;
                @RotateD.canceled += instance.OnRotateD;
                @RotateW.started += instance.OnRotateW;
                @RotateW.performed += instance.OnRotateW;
                @RotateW.canceled += instance.OnRotateW;
                @RotateS.started += instance.OnRotateS;
                @RotateS.performed += instance.OnRotateS;
                @RotateS.canceled += instance.OnRotateS;
                @ReverseThrust.started += instance.OnReverseThrust;
                @ReverseThrust.performed += instance.OnReverseThrust;
                @ReverseThrust.canceled += instance.OnReverseThrust;
            }
        }
    }
    public DroneActions @Drone => new DroneActions(this);

    // Forklift
    private readonly InputActionMap m_Forklift;
    private IForkliftActions m_ForkliftActionsCallbackInterface;
    private readonly InputAction m_Forklift_Drive;
    private readonly InputAction m_Forklift_Rotation;
    private readonly InputAction m_Forklift_Escape;
    private readonly InputAction m_Forklift_LiftUp;
    private readonly InputAction m_Forklift_Lower;
    public struct ForkliftActions
    {
        private @InputPlayerActions m_Wrapper;
        public ForkliftActions(@InputPlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Drive => m_Wrapper.m_Forklift_Drive;
        public InputAction @Rotation => m_Wrapper.m_Forklift_Rotation;
        public InputAction @Escape => m_Wrapper.m_Forklift_Escape;
        public InputAction @LiftUp => m_Wrapper.m_Forklift_LiftUp;
        public InputAction @Lower => m_Wrapper.m_Forklift_Lower;
        public InputActionMap Get() { return m_Wrapper.m_Forklift; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ForkliftActions set) { return set.Get(); }
        public void SetCallbacks(IForkliftActions instance)
        {
            if (m_Wrapper.m_ForkliftActionsCallbackInterface != null)
            {
                @Drive.started -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnDrive;
                @Drive.performed -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnDrive;
                @Drive.canceled -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnDrive;
                @Rotation.started -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnRotation;
                @Escape.started -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnEscape;
                @Escape.performed -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnEscape;
                @Escape.canceled -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnEscape;
                @LiftUp.started -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnLiftUp;
                @LiftUp.performed -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnLiftUp;
                @LiftUp.canceled -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnLiftUp;
                @Lower.started -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnLower;
                @Lower.performed -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnLower;
                @Lower.canceled -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnLower;
            }
            m_Wrapper.m_ForkliftActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Drive.started += instance.OnDrive;
                @Drive.performed += instance.OnDrive;
                @Drive.canceled += instance.OnDrive;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @Escape.started += instance.OnEscape;
                @Escape.performed += instance.OnEscape;
                @Escape.canceled += instance.OnEscape;
                @LiftUp.started += instance.OnLiftUp;
                @LiftUp.performed += instance.OnLiftUp;
                @LiftUp.canceled += instance.OnLiftUp;
                @Lower.started += instance.OnLower;
                @Lower.performed += instance.OnLower;
                @Lower.canceled += instance.OnLower;
            }
        }
    }
    public ForkliftActions @Forklift => new ForkliftActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnInteraction(InputAction.CallbackContext context);
        void OnExplosion(InputAction.CallbackContext context);
        void OnEscape(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
        void OnQuickPunch(InputAction.CallbackContext context);
        void OnSlowPunch(InputAction.CallbackContext context);
    }
    public interface IDroneActions
    {
        void OnThrust(InputAction.CallbackContext context);
        void OnEscape(InputAction.CallbackContext context);
        void OnRotateLeft(InputAction.CallbackContext context);
        void OnRotateRight(InputAction.CallbackContext context);
        void OnRotateA(InputAction.CallbackContext context);
        void OnRotateD(InputAction.CallbackContext context);
        void OnRotateW(InputAction.CallbackContext context);
        void OnRotateS(InputAction.CallbackContext context);
        void OnReverseThrust(InputAction.CallbackContext context);
    }
    public interface IForkliftActions
    {
        void OnDrive(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
        void OnEscape(InputAction.CallbackContext context);
        void OnLiftUp(InputAction.CallbackContext context);
        void OnLower(InputAction.CallbackContext context);
    }
}
