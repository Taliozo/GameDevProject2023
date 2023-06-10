//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Code/Scripts/PlayerHandler.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerHandler : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerHandler()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerHandler"",
    ""maps"": [
        {
            ""name"": ""Player1Keyboard"",
            ""id"": ""6251d37c-0a01-4b71-b3f0-d94e3c95b402"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""23f200d5-bb23-4b06-9798-4d1144ac38e5"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""8bbe1f2c-fc9d-42d7-a32e-d66b297b6761"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap(duration=0.01,pressPoint=1.401298E-45)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Fastfall"",
                    ""type"": ""Button"",
                    ""id"": ""68e94497-d8ed-4ae4-b848-bc653109f748"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jab"",
                    ""type"": ""Button"",
                    ""id"": ""2461d014-0acb-428d-bbcc-cf9369f589cb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Recover"",
                    ""type"": ""Value"",
                    ""id"": ""a6f964a8-4f51-41de-a19f-0615e120196d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap(duration=0.01)"",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""3D Vector"",
                    ""id"": ""380792c4-160d-45a9-bb4c-ffd74ba69b22"",
                    ""path"": ""3DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e11222ca-2e2b-47e4-8c28-1984f1b94f1b"",
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
                    ""id"": ""0a775978-aa5c-4f66-b257-6d9d641604ad"",
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
                    ""id"": ""59c076bc-b264-463b-a353-0fab28629234"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""664a8d83-da3f-44cc-b58d-7db38a014f31"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fastfall"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11d40a3e-b9d4-49a4-9672-8f4282e10e6a"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""417decf0-0ba5-49ec-b223-6e6bf2176b71"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Recover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player2Keyboard"",
            ""id"": ""f5e392cb-e42b-45bd-a363-95e3a9b6dd3d"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""65a67b58-c720-435c-b86b-5d7e6266e2d3"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""7ae482c0-5be9-4d72-8153-45b265ba2418"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap(duration=0.01,pressPoint=1.401298E-45)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Fastfall"",
                    ""type"": ""Button"",
                    ""id"": ""955a2a4c-25bd-4a7d-bb43-f5a179292e9e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jab"",
                    ""type"": ""Button"",
                    ""id"": ""900748a1-6a8d-468d-9643-20175507fe4a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Recover"",
                    ""type"": ""Value"",
                    ""id"": ""5de79e52-7e25-4622-85b4-9c8a9fb5642e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Tap(duration=0.01)"",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""3D Vector"",
                    ""id"": ""ba6ed57d-4066-4337-b383-b0a049b78d11"",
                    ""path"": ""3DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2044532b-eb55-4dc9-8038-a28b905db38d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6b03367e-788b-493c-829d-5cbc83ec9adf"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c688b87c-c0ce-4fda-b6f7-1929f3aca71e"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da715dff-3a8a-492f-99cd-76eb21f2bb58"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fastfall"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab7e899e-78fe-421c-8300-f13d605c872d"",
                    ""path"": ""<Keyboard>/rightCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a497b81-b667-4070-8fe6-3c281be4d797"",
                    ""path"": ""<Keyboard>/numpad0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Recover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player1Keyboard
        m_Player1Keyboard = asset.FindActionMap("Player1Keyboard", throwIfNotFound: true);
        m_Player1Keyboard_Movement = m_Player1Keyboard.FindAction("Movement", throwIfNotFound: true);
        m_Player1Keyboard_Jump = m_Player1Keyboard.FindAction("Jump", throwIfNotFound: true);
        m_Player1Keyboard_Fastfall = m_Player1Keyboard.FindAction("Fastfall", throwIfNotFound: true);
        m_Player1Keyboard_Jab = m_Player1Keyboard.FindAction("Jab", throwIfNotFound: true);
        m_Player1Keyboard_Recover = m_Player1Keyboard.FindAction("Recover", throwIfNotFound: true);
        // Player2Keyboard
        m_Player2Keyboard = asset.FindActionMap("Player2Keyboard", throwIfNotFound: true);
        m_Player2Keyboard_Movement = m_Player2Keyboard.FindAction("Movement", throwIfNotFound: true);
        m_Player2Keyboard_Jump = m_Player2Keyboard.FindAction("Jump", throwIfNotFound: true);
        m_Player2Keyboard_Fastfall = m_Player2Keyboard.FindAction("Fastfall", throwIfNotFound: true);
        m_Player2Keyboard_Jab = m_Player2Keyboard.FindAction("Jab", throwIfNotFound: true);
        m_Player2Keyboard_Recover = m_Player2Keyboard.FindAction("Recover", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player1Keyboard
    private readonly InputActionMap m_Player1Keyboard;
    private IPlayer1KeyboardActions m_Player1KeyboardActionsCallbackInterface;
    private readonly InputAction m_Player1Keyboard_Movement;
    private readonly InputAction m_Player1Keyboard_Jump;
    private readonly InputAction m_Player1Keyboard_Fastfall;
    private readonly InputAction m_Player1Keyboard_Jab;
    private readonly InputAction m_Player1Keyboard_Recover;
    public struct Player1KeyboardActions
    {
        private @PlayerHandler m_Wrapper;
        public Player1KeyboardActions(@PlayerHandler wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player1Keyboard_Movement;
        public InputAction @Jump => m_Wrapper.m_Player1Keyboard_Jump;
        public InputAction @Fastfall => m_Wrapper.m_Player1Keyboard_Fastfall;
        public InputAction @Jab => m_Wrapper.m_Player1Keyboard_Jab;
        public InputAction @Recover => m_Wrapper.m_Player1Keyboard_Recover;
        public InputActionMap Get() { return m_Wrapper.m_Player1Keyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1KeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1KeyboardActions instance)
        {
            if (m_Wrapper.m_Player1KeyboardActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_Player1KeyboardActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_Player1KeyboardActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_Player1KeyboardActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_Player1KeyboardActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_Player1KeyboardActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_Player1KeyboardActionsCallbackInterface.OnJump;
                @Fastfall.started -= m_Wrapper.m_Player1KeyboardActionsCallbackInterface.OnFastfall;
                @Fastfall.performed -= m_Wrapper.m_Player1KeyboardActionsCallbackInterface.OnFastfall;
                @Fastfall.canceled -= m_Wrapper.m_Player1KeyboardActionsCallbackInterface.OnFastfall;
                @Jab.started -= m_Wrapper.m_Player1KeyboardActionsCallbackInterface.OnJab;
                @Jab.performed -= m_Wrapper.m_Player1KeyboardActionsCallbackInterface.OnJab;
                @Jab.canceled -= m_Wrapper.m_Player1KeyboardActionsCallbackInterface.OnJab;
                @Recover.started -= m_Wrapper.m_Player1KeyboardActionsCallbackInterface.OnRecover;
                @Recover.performed -= m_Wrapper.m_Player1KeyboardActionsCallbackInterface.OnRecover;
                @Recover.canceled -= m_Wrapper.m_Player1KeyboardActionsCallbackInterface.OnRecover;
            }
            m_Wrapper.m_Player1KeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Fastfall.started += instance.OnFastfall;
                @Fastfall.performed += instance.OnFastfall;
                @Fastfall.canceled += instance.OnFastfall;
                @Jab.started += instance.OnJab;
                @Jab.performed += instance.OnJab;
                @Jab.canceled += instance.OnJab;
                @Recover.started += instance.OnRecover;
                @Recover.performed += instance.OnRecover;
                @Recover.canceled += instance.OnRecover;
            }
        }
    }
    public Player1KeyboardActions @Player1Keyboard => new Player1KeyboardActions(this);

    // Player2Keyboard
    private readonly InputActionMap m_Player2Keyboard;
    private IPlayer2KeyboardActions m_Player2KeyboardActionsCallbackInterface;
    private readonly InputAction m_Player2Keyboard_Movement;
    private readonly InputAction m_Player2Keyboard_Jump;
    private readonly InputAction m_Player2Keyboard_Fastfall;
    private readonly InputAction m_Player2Keyboard_Jab;
    private readonly InputAction m_Player2Keyboard_Recover;
    public struct Player2KeyboardActions
    {
        private @PlayerHandler m_Wrapper;
        public Player2KeyboardActions(@PlayerHandler wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player2Keyboard_Movement;
        public InputAction @Jump => m_Wrapper.m_Player2Keyboard_Jump;
        public InputAction @Fastfall => m_Wrapper.m_Player2Keyboard_Fastfall;
        public InputAction @Jab => m_Wrapper.m_Player2Keyboard_Jab;
        public InputAction @Recover => m_Wrapper.m_Player2Keyboard_Recover;
        public InputActionMap Get() { return m_Wrapper.m_Player2Keyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2KeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IPlayer2KeyboardActions instance)
        {
            if (m_Wrapper.m_Player2KeyboardActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_Player2KeyboardActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_Player2KeyboardActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_Player2KeyboardActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_Player2KeyboardActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_Player2KeyboardActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_Player2KeyboardActionsCallbackInterface.OnJump;
                @Fastfall.started -= m_Wrapper.m_Player2KeyboardActionsCallbackInterface.OnFastfall;
                @Fastfall.performed -= m_Wrapper.m_Player2KeyboardActionsCallbackInterface.OnFastfall;
                @Fastfall.canceled -= m_Wrapper.m_Player2KeyboardActionsCallbackInterface.OnFastfall;
                @Jab.started -= m_Wrapper.m_Player2KeyboardActionsCallbackInterface.OnJab;
                @Jab.performed -= m_Wrapper.m_Player2KeyboardActionsCallbackInterface.OnJab;
                @Jab.canceled -= m_Wrapper.m_Player2KeyboardActionsCallbackInterface.OnJab;
                @Recover.started -= m_Wrapper.m_Player2KeyboardActionsCallbackInterface.OnRecover;
                @Recover.performed -= m_Wrapper.m_Player2KeyboardActionsCallbackInterface.OnRecover;
                @Recover.canceled -= m_Wrapper.m_Player2KeyboardActionsCallbackInterface.OnRecover;
            }
            m_Wrapper.m_Player2KeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Fastfall.started += instance.OnFastfall;
                @Fastfall.performed += instance.OnFastfall;
                @Fastfall.canceled += instance.OnFastfall;
                @Jab.started += instance.OnJab;
                @Jab.performed += instance.OnJab;
                @Jab.canceled += instance.OnJab;
                @Recover.started += instance.OnRecover;
                @Recover.performed += instance.OnRecover;
                @Recover.canceled += instance.OnRecover;
            }
        }
    }
    public Player2KeyboardActions @Player2Keyboard => new Player2KeyboardActions(this);
    public interface IPlayer1KeyboardActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnFastfall(InputAction.CallbackContext context);
        void OnJab(InputAction.CallbackContext context);
        void OnRecover(InputAction.CallbackContext context);
    }
    public interface IPlayer2KeyboardActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnFastfall(InputAction.CallbackContext context);
        void OnJab(InputAction.CallbackContext context);
        void OnRecover(InputAction.CallbackContext context);
    }
}