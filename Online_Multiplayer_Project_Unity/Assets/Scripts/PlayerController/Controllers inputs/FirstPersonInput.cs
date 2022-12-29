// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerController/Controllers inputs/FirstPersonInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @FirstPersonInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @FirstPersonInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""FirstPersonInput"",
    ""maps"": [
        {
            ""name"": ""ThirdPerson"",
            ""id"": ""01179156-927a-4a69-83d6-92470f55c71c"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""3b33f8a3-bd03-494c-9b9e-97c0f02f31f5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""04448411-3167-413e-ace1-066739383fc6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""141e4605-8401-48f6-a673-c5e7e6da7bc8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""556633e0-4f7f-4142-b5e6-59b24cb1cdad"",
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
                    ""id"": ""bae283e0-fd2b-45d4-9d76-ae5ca44babab"",
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
                    ""id"": ""880ea6f2-a3e3-4649-bac8-bb08b1b31972"",
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
                    ""id"": ""6f352285-744d-4065-aa9e-ad20cc0d1a2c"",
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
                    ""id"": ""d9df4ccf-3339-4230-9619-cbeeb8eb57a2"",
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
                    ""id"": ""2976f95a-4525-4704-91d3-83d2ee1a1644"",
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
                    ""id"": ""4706e61d-5bb4-4726-b8da-c71d27505004"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""FirstPerson"",
            ""id"": ""6af5cbbf-42eb-4fdd-b716-174229a9873b"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""1dab9d40-4fed-478a-9366-5f3796329120"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""New action1"",
                    ""type"": ""Button"",
                    ""id"": ""27924a5d-df89-4e99-ab0c-245ef6572f6c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3b7e03a1-d616-4657-b4de-752400b98148"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51829f63-3799-45f1-807e-b952f074239d"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""TopDown"",
            ""id"": ""b73d5198-dd60-44bc-9862-eeb04899bbf6"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""89b85643-4b19-4295-89e3-b0be091cb902"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d993f28d-e548-47a3-b1fc-37ff1e3be38e"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ThirdPerson
        m_ThirdPerson = asset.FindActionMap("ThirdPerson", throwIfNotFound: true);
        m_ThirdPerson_Move = m_ThirdPerson.FindAction("Move", throwIfNotFound: true);
        m_ThirdPerson_Jump = m_ThirdPerson.FindAction("Jump", throwIfNotFound: true);
        m_ThirdPerson_Look = m_ThirdPerson.FindAction("Look", throwIfNotFound: true);
        // FirstPerson
        m_FirstPerson = asset.FindActionMap("FirstPerson", throwIfNotFound: true);
        m_FirstPerson_Newaction = m_FirstPerson.FindAction("New action", throwIfNotFound: true);
        m_FirstPerson_Newaction1 = m_FirstPerson.FindAction("New action1", throwIfNotFound: true);
        // TopDown
        m_TopDown = asset.FindActionMap("TopDown", throwIfNotFound: true);
        m_TopDown_Newaction = m_TopDown.FindAction("New action", throwIfNotFound: true);
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

    // ThirdPerson
    private readonly InputActionMap m_ThirdPerson;
    private IThirdPersonActions m_ThirdPersonActionsCallbackInterface;
    private readonly InputAction m_ThirdPerson_Move;
    private readonly InputAction m_ThirdPerson_Jump;
    private readonly InputAction m_ThirdPerson_Look;
    public struct ThirdPersonActions
    {
        private @FirstPersonInput m_Wrapper;
        public ThirdPersonActions(@FirstPersonInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_ThirdPerson_Move;
        public InputAction @Jump => m_Wrapper.m_ThirdPerson_Jump;
        public InputAction @Look => m_Wrapper.m_ThirdPerson_Look;
        public InputActionMap Get() { return m_Wrapper.m_ThirdPerson; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ThirdPersonActions set) { return set.Get(); }
        public void SetCallbacks(IThirdPersonActions instance)
        {
            if (m_Wrapper.m_ThirdPersonActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnJump;
                @Look.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnLook;
            }
            m_Wrapper.m_ThirdPersonActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
            }
        }
    }
    public ThirdPersonActions @ThirdPerson => new ThirdPersonActions(this);

    // FirstPerson
    private readonly InputActionMap m_FirstPerson;
    private IFirstPersonActions m_FirstPersonActionsCallbackInterface;
    private readonly InputAction m_FirstPerson_Newaction;
    private readonly InputAction m_FirstPerson_Newaction1;
    public struct FirstPersonActions
    {
        private @FirstPersonInput m_Wrapper;
        public FirstPersonActions(@FirstPersonInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_FirstPerson_Newaction;
        public InputAction @Newaction1 => m_Wrapper.m_FirstPerson_Newaction1;
        public InputActionMap Get() { return m_Wrapper.m_FirstPerson; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FirstPersonActions set) { return set.Get(); }
        public void SetCallbacks(IFirstPersonActions instance)
        {
            if (m_Wrapper.m_FirstPersonActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnNewaction;
                @Newaction1.started -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnNewaction1;
                @Newaction1.performed -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnNewaction1;
                @Newaction1.canceled -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnNewaction1;
            }
            m_Wrapper.m_FirstPersonActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
                @Newaction1.started += instance.OnNewaction1;
                @Newaction1.performed += instance.OnNewaction1;
                @Newaction1.canceled += instance.OnNewaction1;
            }
        }
    }
    public FirstPersonActions @FirstPerson => new FirstPersonActions(this);

    // TopDown
    private readonly InputActionMap m_TopDown;
    private ITopDownActions m_TopDownActionsCallbackInterface;
    private readonly InputAction m_TopDown_Newaction;
    public struct TopDownActions
    {
        private @FirstPersonInput m_Wrapper;
        public TopDownActions(@FirstPersonInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_TopDown_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_TopDown; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TopDownActions set) { return set.Get(); }
        public void SetCallbacks(ITopDownActions instance)
        {
            if (m_Wrapper.m_TopDownActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_TopDownActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_TopDownActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_TopDownActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_TopDownActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public TopDownActions @TopDown => new TopDownActions(this);
    public interface IThirdPersonActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
    }
    public interface IFirstPersonActions
    {
        void OnNewaction(InputAction.CallbackContext context);
        void OnNewaction1(InputAction.CallbackContext context);
    }
    public interface ITopDownActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
