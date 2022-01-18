// GENERATED AUTOMATICALLY FROM 'Assets/Controls/PlayerMovement.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerMovement : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerMovement()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerMovement"",
    ""maps"": [
        {
            ""name"": ""KeyBoard1"",
            ""id"": ""0b3d4fa4-53c5-4fdc-b461-794358907812"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""3a5b40a9-60fb-4242-8c90-9e3dc902075a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""dbaba9fd-d85f-4321-865e-f480cee4ec04"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""MoveVector"",
                    ""id"": ""76a419fe-8a3d-474c-8b7e-5855ab709069"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c627b33a-b471-4a86-b1a2-ebcfe9155031"",
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
                    ""id"": ""a90ab58c-c775-41d2-94b3-e1aac4145497"",
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
                    ""id"": ""35770e5b-021e-4b4f-ae1b-f08d6b7676ca"",
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
                    ""id"": ""311be342-a6db-4b2b-b633-9f937000c70a"",
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
                    ""id"": ""3ab49eef-92b5-48a2-93cc-52c05c6cf26b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // KeyBoard1
        m_KeyBoard1 = asset.FindActionMap("KeyBoard1", throwIfNotFound: true);
        m_KeyBoard1_Movement = m_KeyBoard1.FindAction("Movement", throwIfNotFound: true);
        m_KeyBoard1_Attack = m_KeyBoard1.FindAction("Attack", throwIfNotFound: true);
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

    // KeyBoard1
    private readonly InputActionMap m_KeyBoard1;
    private IKeyBoard1Actions m_KeyBoard1ActionsCallbackInterface;
    private readonly InputAction m_KeyBoard1_Movement;
    private readonly InputAction m_KeyBoard1_Attack;
    public struct KeyBoard1Actions
    {
        private @PlayerMovement m_Wrapper;
        public KeyBoard1Actions(@PlayerMovement wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_KeyBoard1_Movement;
        public InputAction @Attack => m_Wrapper.m_KeyBoard1_Attack;
        public InputActionMap Get() { return m_Wrapper.m_KeyBoard1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyBoard1Actions set) { return set.Get(); }
        public void SetCallbacks(IKeyBoard1Actions instance)
        {
            if (m_Wrapper.m_KeyBoard1ActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_KeyBoard1ActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_KeyBoard1ActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_KeyBoard1ActionsCallbackInterface.OnMovement;
                @Attack.started -= m_Wrapper.m_KeyBoard1ActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_KeyBoard1ActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_KeyBoard1ActionsCallbackInterface.OnAttack;
            }
            m_Wrapper.m_KeyBoard1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
            }
        }
    }
    public KeyBoard1Actions @KeyBoard1 => new KeyBoard1Actions(this);
    public interface IKeyBoard1Actions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
    }
}
