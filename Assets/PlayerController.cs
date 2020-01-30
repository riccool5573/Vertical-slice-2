// GENERATED AUTOMATICALLY FROM 'Assets/PlayerController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerController : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public @PlayerController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerController"",
    ""maps"": [
        {
            ""name"": ""GamePlay"",
            ""id"": ""ada019cf-1f74-4959-841a-1ce87bd4955c"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""438460b4-9f1e-485f-9d17-f03872798b10"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""44b55ecc-d553-4431-a255-e7acc1a1c4a4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Button"",
                    ""id"": ""e87450e2-e406-49d4-bb88-e5a3aa310ac6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Breath"",
                    ""type"": ""Button"",
                    ""id"": ""a06f2f2a-d291-4e67-b345-f450d2d54045"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TimeSlow"",
                    ""type"": ""Button"",
                    ""id"": ""b109dcee-d1f6-4d66-9e34-779c4ebfcdc7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""51bc8336-b055-49c2-95b1-781550db9be0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ed7fcdb7-8cdc-4e32-a9bf-8c3b8de5fb10"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""58e74985-1e29-4087-9137-9e73a892246c"",
                    ""path"": ""<HID::Logitech Logitech Dual Action>/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d55c89c6-7e3a-4a78-acbf-c7fab8cf4cc2"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3048e03c-de19-4eca-95ad-a48ecc350ac2"",
                    ""path"": ""<HID::Logitech Logitech Dual Action>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4de87b78-c471-4a63-8fbd-126a2e7a6299"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf8bd148-f279-4c3b-a38c-43daf56d2e7d"",
                    ""path"": ""<HID::Logitech Logitech Dual Action>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d4998e2f-56c9-4d9a-bd9c-c795ee47bebb"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Breath"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0493f43e-956a-4e83-944b-f4b44893d013"",
                    ""path"": ""<HID::Logitech Logitech Dual Action>/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Breath"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9405ddb3-508a-4ba9-8d0c-ef6b6565fcf2"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TimeSlow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a06ba6c-ef0c-4355-bf27-27d779405c8c"",
                    ""path"": ""<HID::Logitech Logitech Dual Action>/button5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TimeSlow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38cd8750-009e-457e-8cbe-7f44b5d7b658"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d597b20-a2fd-4d5e-b233-678e6ba0a604"",
                    ""path"": ""<HID::Logitech Logitech Dual Action>/button6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GamePlay
        m_GamePlay = asset.FindActionMap("GamePlay", throwIfNotFound: true);
        m_GamePlay_Jump = m_GamePlay.FindAction("Jump", throwIfNotFound: true);
        m_GamePlay_Move = m_GamePlay.FindAction("Move", throwIfNotFound: true);
        m_GamePlay_Rotate = m_GamePlay.FindAction("Rotate", throwIfNotFound: true);
        m_GamePlay_Breath = m_GamePlay.FindAction("Breath", throwIfNotFound: true);
        m_GamePlay_TimeSlow = m_GamePlay.FindAction("TimeSlow", throwIfNotFound: true);
        m_GamePlay_Sprint = m_GamePlay.FindAction("Sprint", throwIfNotFound: true);
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

    // GamePlay
    private readonly InputActionMap m_GamePlay;
    private IGamePlayActions m_GamePlayActionsCallbackInterface;
    private readonly InputAction m_GamePlay_Jump;
    private readonly InputAction m_GamePlay_Move;
    private readonly InputAction m_GamePlay_Rotate;
    private readonly InputAction m_GamePlay_Breath;
    private readonly InputAction m_GamePlay_TimeSlow;
    private readonly InputAction m_GamePlay_Sprint;
    public struct GamePlayActions
    {
        private @PlayerController m_Wrapper;
        public GamePlayActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_GamePlay_Jump;
        public InputAction @Move => m_Wrapper.m_GamePlay_Move;
        public InputAction @Rotate => m_Wrapper.m_GamePlay_Rotate;
        public InputAction @Breath => m_Wrapper.m_GamePlay_Breath;
        public InputAction @TimeSlow => m_Wrapper.m_GamePlay_TimeSlow;
        public InputAction @Sprint => m_Wrapper.m_GamePlay_Sprint;
        public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
        public void SetCallbacks(IGamePlayActions instance)
        {
            if (m_Wrapper.m_GamePlayActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnJump;
                @Move.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMove;
                @Rotate.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRotate;
                @Breath.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBreath;
                @Breath.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBreath;
                @Breath.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBreath;
                @TimeSlow.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTimeSlow;
                @TimeSlow.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTimeSlow;
                @TimeSlow.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTimeSlow;
                @Sprint.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSprint;
            }
            m_Wrapper.m_GamePlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Breath.started += instance.OnBreath;
                @Breath.performed += instance.OnBreath;
                @Breath.canceled += instance.OnBreath;
                @TimeSlow.started += instance.OnTimeSlow;
                @TimeSlow.performed += instance.OnTimeSlow;
                @TimeSlow.canceled += instance.OnTimeSlow;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
            }
        }
    }
    public GamePlayActions @GamePlay => new GamePlayActions(this);
    public interface IGamePlayActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnBreath(InputAction.CallbackContext context);
        void OnTimeSlow(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
    }
}
