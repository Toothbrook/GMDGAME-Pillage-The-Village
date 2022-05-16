//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/Player_controls.inputactions
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

public partial class @Player_controls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player_controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player_controls"",
    ""maps"": [
        {
            ""name"": ""3rdPerson controller"",
            ""id"": ""f1309df5-e464-4332-8a6f-4973de931d0b"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""1ed872ed-e363-45db-a9f8-a3a4e09e9c2e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""c9ade963-dd58-472b-9bac-72c17f042de5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""47a033e5-099c-43e6-8b1d-62a691af07be"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LookAround"",
                    ""type"": ""Value"",
                    ""id"": ""3bd2b944-e069-4af8-9bd3-5058b1dbd301"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""c42a73b2-bca6-483e-ab70-04d608af91d6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""cab1d990-ae59-4744-b2e1-63dd79d33b7a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ea028e01-bab2-4d53-8e4b-5458d6771999"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""af94648a-b4ec-403e-a75e-cbff02c68917"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cc3e2c9b-1179-4591-bfac-e6a05da7286c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""109eb021-2aac-412e-804d-3bed1e40efd1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""764a74ca-58d3-4317-a928-5a85905a025a"",
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
                    ""id"": ""b29080f7-cddc-4165-84ec-e7208f6be25f"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a3928bc2-316c-4c37-8e13-5126c9f5ead6"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LookAround"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""690fc12a-1c91-4ff5-8937-b9c130ca16da"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""BoatController"",
            ""id"": ""03172461-9c59-47eb-8b8b-8e73c3995836"",
            ""actions"": [
                {
                    ""name"": ""EnterAndExit"",
                    ""type"": ""Button"",
                    ""id"": ""9ea7d61c-f602-47dc-8382-317bf38a2d74"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c27bb3eb-7ed2-42ec-ae75-ae08cab073b8"",
                    ""path"": ""<Keyboard>/#(E)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnterAndExit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // 3rdPerson controller
        m__3rdPersoncontroller = asset.FindActionMap("3rdPerson controller", throwIfNotFound: true);
        m__3rdPersoncontroller_Move = m__3rdPersoncontroller.FindAction("Move", throwIfNotFound: true);
        m__3rdPersoncontroller_Jump = m__3rdPersoncontroller.FindAction("Jump", throwIfNotFound: true);
        m__3rdPersoncontroller_Sprint = m__3rdPersoncontroller.FindAction("Sprint", throwIfNotFound: true);
        m__3rdPersoncontroller_LookAround = m__3rdPersoncontroller.FindAction("LookAround", throwIfNotFound: true);
        m__3rdPersoncontroller_Attack = m__3rdPersoncontroller.FindAction("Attack", throwIfNotFound: true);
        // BoatController
        m_BoatController = asset.FindActionMap("BoatController", throwIfNotFound: true);
        m_BoatController_EnterAndExit = m_BoatController.FindAction("EnterAndExit", throwIfNotFound: true);
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

    // 3rdPerson controller
    private readonly InputActionMap m__3rdPersoncontroller;
    private I_3rdPersoncontrollerActions m__3rdPersoncontrollerActionsCallbackInterface;
    private readonly InputAction m__3rdPersoncontroller_Move;
    private readonly InputAction m__3rdPersoncontroller_Jump;
    private readonly InputAction m__3rdPersoncontroller_Sprint;
    private readonly InputAction m__3rdPersoncontroller_LookAround;
    private readonly InputAction m__3rdPersoncontroller_Attack;
    public struct _3rdPersoncontrollerActions
    {
        private @Player_controls m_Wrapper;
        public _3rdPersoncontrollerActions(@Player_controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m__3rdPersoncontroller_Move;
        public InputAction @Jump => m_Wrapper.m__3rdPersoncontroller_Jump;
        public InputAction @Sprint => m_Wrapper.m__3rdPersoncontroller_Sprint;
        public InputAction @LookAround => m_Wrapper.m__3rdPersoncontroller_LookAround;
        public InputAction @Attack => m_Wrapper.m__3rdPersoncontroller_Attack;
        public InputActionMap Get() { return m_Wrapper.m__3rdPersoncontroller; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(_3rdPersoncontrollerActions set) { return set.Get(); }
        public void SetCallbacks(I_3rdPersoncontrollerActions instance)
        {
            if (m_Wrapper.m__3rdPersoncontrollerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m__3rdPersoncontrollerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m__3rdPersoncontrollerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m__3rdPersoncontrollerActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m__3rdPersoncontrollerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m__3rdPersoncontrollerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m__3rdPersoncontrollerActionsCallbackInterface.OnJump;
                @Sprint.started -= m_Wrapper.m__3rdPersoncontrollerActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m__3rdPersoncontrollerActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m__3rdPersoncontrollerActionsCallbackInterface.OnSprint;
                @LookAround.started -= m_Wrapper.m__3rdPersoncontrollerActionsCallbackInterface.OnLookAround;
                @LookAround.performed -= m_Wrapper.m__3rdPersoncontrollerActionsCallbackInterface.OnLookAround;
                @LookAround.canceled -= m_Wrapper.m__3rdPersoncontrollerActionsCallbackInterface.OnLookAround;
                @Attack.started -= m_Wrapper.m__3rdPersoncontrollerActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m__3rdPersoncontrollerActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m__3rdPersoncontrollerActionsCallbackInterface.OnAttack;
            }
            m_Wrapper.m__3rdPersoncontrollerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @LookAround.started += instance.OnLookAround;
                @LookAround.performed += instance.OnLookAround;
                @LookAround.canceled += instance.OnLookAround;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
            }
        }
    }
    public _3rdPersoncontrollerActions @_3rdPersoncontroller => new _3rdPersoncontrollerActions(this);

    // BoatController
    private readonly InputActionMap m_BoatController;
    private IBoatControllerActions m_BoatControllerActionsCallbackInterface;
    private readonly InputAction m_BoatController_EnterAndExit;
    public struct BoatControllerActions
    {
        private @Player_controls m_Wrapper;
        public BoatControllerActions(@Player_controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @EnterAndExit => m_Wrapper.m_BoatController_EnterAndExit;
        public InputActionMap Get() { return m_Wrapper.m_BoatController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BoatControllerActions set) { return set.Get(); }
        public void SetCallbacks(IBoatControllerActions instance)
        {
            if (m_Wrapper.m_BoatControllerActionsCallbackInterface != null)
            {
                @EnterAndExit.started -= m_Wrapper.m_BoatControllerActionsCallbackInterface.OnEnterAndExit;
                @EnterAndExit.performed -= m_Wrapper.m_BoatControllerActionsCallbackInterface.OnEnterAndExit;
                @EnterAndExit.canceled -= m_Wrapper.m_BoatControllerActionsCallbackInterface.OnEnterAndExit;
            }
            m_Wrapper.m_BoatControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @EnterAndExit.started += instance.OnEnterAndExit;
                @EnterAndExit.performed += instance.OnEnterAndExit;
                @EnterAndExit.canceled += instance.OnEnterAndExit;
            }
        }
    }
    public BoatControllerActions @BoatController => new BoatControllerActions(this);
    public interface I_3rdPersoncontrollerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnLookAround(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
    }
    public interface IBoatControllerActions
    {
        void OnEnterAndExit(InputAction.CallbackContext context);
    }
}
