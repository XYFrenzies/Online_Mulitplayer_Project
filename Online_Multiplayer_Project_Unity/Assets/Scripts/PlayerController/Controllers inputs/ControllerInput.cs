// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerController/Controllers inputs/ControllerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ControllerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ControllerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ControllerInput"",
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
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f7355c3e-b819-4f67-bd3b-464e368faf39"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""3bc695cf-42e3-48cf-8e27-adc96743a470"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mouse X"",
                    ""type"": ""PassThrough"",
                    ""id"": ""89c25adf-bead-43d3-bb2a-475e7c290676"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mouse Y"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e2c649e6-2a32-46ac-8689-0325db41f35e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""db6a937f-91e5-4616-9e70-419e213b9ab0"",
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
                    ""id"": ""c5a4f88e-9ae3-4b26-9969-6c1851b2fa83"",
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
                    ""id"": ""324c362d-9a9f-49a2-b34e-d9727594bd63"",
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
                    ""id"": ""9d681b34-b6d2-49a9-b739-6c84e24fdd3b"",
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
                    ""id"": ""9ffcaf47-ac73-4dc2-916e-c096a06f327b"",
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
                    ""id"": ""b20f60ef-6ce1-4035-8af7-87792edee5c6"",
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
                    ""id"": ""2a0bd936-79d3-4ce3-8aa9-6b32a7932054"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ff3e517-137f-44eb-8c07-838b8bc5d5fc"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse Y"",
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
        m_FirstPerson_Move = m_FirstPerson.FindAction("Move", throwIfNotFound: true);
        m_FirstPerson_Jump = m_FirstPerson.FindAction("Jump", throwIfNotFound: true);
        m_FirstPerson_MouseX = m_FirstPerson.FindAction("Mouse X", throwIfNotFound: true);
        m_FirstPerson_MouseY = m_FirstPerson.FindAction("Mouse Y", throwIfNotFound: true);
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
        private @ControllerInput m_Wrapper;
        public ThirdPersonActions(@ControllerInput wrapper) { m_Wrapper = wrapper; }
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
    private readonly InputAction m_FirstPerson_Move;
    private readonly InputAction m_FirstPerson_Jump;
    private readonly InputAction m_FirstPerson_MouseX;
    private readonly InputAction m_FirstPerson_MouseY;
    public struct FirstPersonActions
    {
        private @ControllerInput m_Wrapper;
        public FirstPersonActions(@ControllerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_FirstPerson_Move;
        public InputAction @Jump => m_Wrapper.m_FirstPerson_Jump;
        public InputAction @MouseX => m_Wrapper.m_FirstPerson_MouseX;
        public InputAction @MouseY => m_Wrapper.m_FirstPerson_MouseY;
        public InputActionMap Get() { return m_Wrapper.m_FirstPerson; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FirstPersonActions set) { return set.Get(); }
        public void SetCallbacks(IFirstPersonActions instance)
        {
            if (m_Wrapper.m_FirstPersonActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnJump;
                @MouseX.started -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnMouseX;
                @MouseX.performed -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnMouseX;
                @MouseX.canceled -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnMouseX;
                @MouseY.started -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnMouseY;
                @MouseY.performed -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnMouseY;
                @MouseY.canceled -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnMouseY;
            }
            m_Wrapper.m_FirstPersonActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @MouseX.started += instance.OnMouseX;
                @MouseX.performed += instance.OnMouseX;
                @MouseX.canceled += instance.OnMouseX;
                @MouseY.started += instance.OnMouseY;
                @MouseY.performed += instance.OnMouseY;
                @MouseY.canceled += instance.OnMouseY;
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
        private @ControllerInput m_Wrapper;
        public TopDownActions(@ControllerInput wrapper) { m_Wrapper = wrapper; }
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
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
    }
    public interface ITopDownActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
