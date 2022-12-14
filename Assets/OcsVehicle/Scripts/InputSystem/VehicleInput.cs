// GENERATED AUTOMATICALLY FROM 'Assets/OcsVehicle/Scripts/InputSystem/VehicleInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Ocs.Input
{
    public class @VehicleInput : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @VehicleInput()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""VehicleInput"",
    ""maps"": [
        {
            ""name"": ""Car"",
            ""id"": ""3a787cf5-c818-453a-85dc-388ffe93e02d"",
            ""actions"": [
                {
                    ""name"": ""Accel"",
                    ""type"": ""Button"",
                    ""id"": ""4715564f-1219-4099-a076-7feed548e067"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""Button"",
                    ""id"": ""946e8425-5e46-4a77-84d8-66a059b424cd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShiftUp"",
                    ""type"": ""Button"",
                    ""id"": ""e9ad70c9-ac4e-4e92-93f0-5886db46c686"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShiftDown"",
                    ""type"": ""Button"",
                    ""id"": ""4dc883c5-b116-4e83-80d3-439b96c8c10f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Steering"",
                    ""type"": ""Value"",
                    ""id"": ""7e58a3e1-5354-4644-a09f-b2a12f91e71b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""12f71fe1-013a-4dde-ba9b-e2c0c0363529"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Accel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""571e0121-17dc-4cf5-b2df-9288e31ab6eb"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""13ead5e4-6813-4268-ad11-96c30ce279dc"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd17ec32-d1f2-4d8f-a66d-88e984ee2bb1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""57a90925-d16a-4294-963d-2e922116b91d"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ShiftUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b32824a-8963-4f01-9f22-b300d83ad916"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShiftUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a1ff0b3-e9da-4875-9d6e-9c24f011863b"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ShiftDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3c5dd9a-2cca-482d-8d60-2d73e3ec5435"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShiftDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e8b413f-8c33-479b-8ea6-de5cf5810131"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""1df4a0e6-360d-4e52-bee4-ba839ce6a066"",
                    ""path"": ""Dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d01afcbe-8dfd-4c80-a479-c4a18aea6646"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9425977e-c23f-47df-b9f7-7d26465a3908"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8d8ae76c-0c1c-4778-a544-55cb8fb56f83"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a814bbc1-c14b-4cab-a8e9-f19fe1186758"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""42b2e801-51ac-40d4-9148-69e50f287321"",
                    ""path"": ""<XRController>/{Primary2DAxis}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4d33c476-150d-441f-84ac-864225f69089"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Crawler"",
            ""id"": ""36d8e253-24b2-4dab-9733-1f93e0ecc605"",
            ""actions"": [
                {
                    ""name"": ""RightForward"",
                    ""type"": ""Button"",
                    ""id"": ""13d9c47c-66b0-49d5-a8e7-55b967b6e3d2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightReverse"",
                    ""type"": ""Button"",
                    ""id"": ""f657710a-eee3-4bff-9640-ed14c47f220f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftForward"",
                    ""type"": ""Button"",
                    ""id"": ""32ee027c-cb1f-4b37-9b12-d8d3ef1d0679"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftReverse"",
                    ""type"": ""Button"",
                    ""id"": ""7ac3ea4c-2d22-4d96-8d4e-a023f488c2cb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a7b57970-ecd0-4209-8750-79730c9d1174"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""RightForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85080ecd-23a4-4ee5-b801-abfed8430998"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LeftForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1e90a956-6dba-45a1-87f9-eed4ca3d4f9e"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LeftReverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5afb5b28-e869-46cb-bd44-237caa64a2c1"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""RightReverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Equipment"",
            ""id"": ""12bf3a77-c603-42fd-bf4e-684ac072156b"",
            ""actions"": [
                {
                    ""name"": ""Light"",
                    ""type"": ""Button"",
                    ""id"": ""1c9b00d6-1388-4513-bd9d-d0e39373e889"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Hone"",
                    ""type"": ""Button"",
                    ""id"": ""f2c78c1b-fca6-4e44-9e4d-0fe92bf86804"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftWinker"",
                    ""type"": ""Button"",
                    ""id"": ""6d63e532-0ad3-499b-860f-f04fb8da4250"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightWinker"",
                    ""type"": ""Button"",
                    ""id"": ""76fe9ec3-d15c-44f4-95b1-d78e23a0b9a6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8d037b23-9240-4eb2-ab80-917fb8de4274"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Light"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""66e7a427-2fd9-40be-aea3-182f8d204624"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Light"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81f5ce25-814c-40c5-8fb9-370c71b7b95b"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d3a8cd42-1fa0-4954-983f-1549aff4024b"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Alt + Left Arrow"",
                    ""id"": ""84e90a10-ca8e-4108-b116-d98c1bb7f5fc"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftWinker"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""cbbc4205-4fd8-4462-8cd6-995c5a7237e1"",
                    ""path"": ""<Keyboard>/alt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftWinker"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""1fc4bf6a-e79f-403a-956f-48f4ee3ea29d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftWinker"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Alt + Right Arrow"",
                    ""id"": ""b61498fd-de2f-4a4c-9739-2cab30b2c6f3"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightWinker"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""496f9bf5-81de-4a58-9ab1-729bc3830f97"",
                    ""path"": ""<Keyboard>/alt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightWinker"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""7f9deca7-99fe-44e8-bf42-52e11e566008"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightWinker"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""DumpTruck"",
            ""id"": ""74b1e065-5308-4e3e-bf48-d47f11b5061d"",
            ""actions"": [
                {
                    ""name"": ""Work"",
                    ""type"": ""Button"",
                    ""id"": ""7f7a2aee-72d7-4c14-a935-5438895082c5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""94b122e3-1763-4ec2-80de-60ce83a855d2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Work"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""624dee2f-35fb-4fad-a69c-f3c802f7169e"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Work"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""00fe324b-3bc5-41cd-b2ed-cbb82e5726d8"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Work"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""b8d01f4a-d706-421a-9220-0c7f0f6cdd68"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Work"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e7947233-8b8e-476f-9fe9-e36888982f95"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Work"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7d6cdae1-67fb-476d-80d1-1f9af3c31b80"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Work"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Backhoe"",
            ""id"": ""fcc6bed9-0e47-42f6-ad4d-b5b25a16ba0a"",
            ""actions"": [
                {
                    ""name"": ""Lever0"",
                    ""type"": ""Button"",
                    ""id"": ""440157d0-4eac-4ef4-ab27-ee446ec954d5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Lever1"",
                    ""type"": ""Button"",
                    ""id"": ""25738e96-248c-4839-ad5b-aae1d38a985b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""56bb6e3c-17bf-4ef1-821f-1a762b333030"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Lever1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ec3b0e4-9528-48c4-a03d-17417db9c5d7"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Lever0"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Car
            m_Car = asset.FindActionMap("Car", throwIfNotFound: true);
            m_Car_Accel = m_Car.FindAction("Accel", throwIfNotFound: true);
            m_Car_Brake = m_Car.FindAction("Brake", throwIfNotFound: true);
            m_Car_ShiftUp = m_Car.FindAction("ShiftUp", throwIfNotFound: true);
            m_Car_ShiftDown = m_Car.FindAction("ShiftDown", throwIfNotFound: true);
            m_Car_Steering = m_Car.FindAction("Steering", throwIfNotFound: true);
            // Crawler
            m_Crawler = asset.FindActionMap("Crawler", throwIfNotFound: true);
            m_Crawler_RightForward = m_Crawler.FindAction("RightForward", throwIfNotFound: true);
            m_Crawler_RightReverse = m_Crawler.FindAction("RightReverse", throwIfNotFound: true);
            m_Crawler_LeftForward = m_Crawler.FindAction("LeftForward", throwIfNotFound: true);
            m_Crawler_LeftReverse = m_Crawler.FindAction("LeftReverse", throwIfNotFound: true);
            // Equipment
            m_Equipment = asset.FindActionMap("Equipment", throwIfNotFound: true);
            m_Equipment_Light = m_Equipment.FindAction("Light", throwIfNotFound: true);
            m_Equipment_Hone = m_Equipment.FindAction("Hone", throwIfNotFound: true);
            m_Equipment_LeftWinker = m_Equipment.FindAction("LeftWinker", throwIfNotFound: true);
            m_Equipment_RightWinker = m_Equipment.FindAction("RightWinker", throwIfNotFound: true);
            // DumpTruck
            m_DumpTruck = asset.FindActionMap("DumpTruck", throwIfNotFound: true);
            m_DumpTruck_Work = m_DumpTruck.FindAction("Work", throwIfNotFound: true);
            // Backhoe
            m_Backhoe = asset.FindActionMap("Backhoe", throwIfNotFound: true);
            m_Backhoe_Lever0 = m_Backhoe.FindAction("Lever0", throwIfNotFound: true);
            m_Backhoe_Lever1 = m_Backhoe.FindAction("Lever1", throwIfNotFound: true);
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

        // Car
        private readonly InputActionMap m_Car;
        private ICarActions m_CarActionsCallbackInterface;
        private readonly InputAction m_Car_Accel;
        private readonly InputAction m_Car_Brake;
        private readonly InputAction m_Car_ShiftUp;
        private readonly InputAction m_Car_ShiftDown;
        private readonly InputAction m_Car_Steering;
        public struct CarActions
        {
            private @VehicleInput m_Wrapper;
            public CarActions(@VehicleInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Accel => m_Wrapper.m_Car_Accel;
            public InputAction @Brake => m_Wrapper.m_Car_Brake;
            public InputAction @ShiftUp => m_Wrapper.m_Car_ShiftUp;
            public InputAction @ShiftDown => m_Wrapper.m_Car_ShiftDown;
            public InputAction @Steering => m_Wrapper.m_Car_Steering;
            public InputActionMap Get() { return m_Wrapper.m_Car; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(CarActions set) { return set.Get(); }
            public void SetCallbacks(ICarActions instance)
            {
                if (m_Wrapper.m_CarActionsCallbackInterface != null)
                {
                    @Accel.started -= m_Wrapper.m_CarActionsCallbackInterface.OnAccel;
                    @Accel.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnAccel;
                    @Accel.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnAccel;
                    @Brake.started -= m_Wrapper.m_CarActionsCallbackInterface.OnBrake;
                    @Brake.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnBrake;
                    @Brake.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnBrake;
                    @ShiftUp.started -= m_Wrapper.m_CarActionsCallbackInterface.OnShiftUp;
                    @ShiftUp.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnShiftUp;
                    @ShiftUp.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnShiftUp;
                    @ShiftDown.started -= m_Wrapper.m_CarActionsCallbackInterface.OnShiftDown;
                    @ShiftDown.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnShiftDown;
                    @ShiftDown.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnShiftDown;
                    @Steering.started -= m_Wrapper.m_CarActionsCallbackInterface.OnSteering;
                    @Steering.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnSteering;
                    @Steering.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnSteering;
                }
                m_Wrapper.m_CarActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Accel.started += instance.OnAccel;
                    @Accel.performed += instance.OnAccel;
                    @Accel.canceled += instance.OnAccel;
                    @Brake.started += instance.OnBrake;
                    @Brake.performed += instance.OnBrake;
                    @Brake.canceled += instance.OnBrake;
                    @ShiftUp.started += instance.OnShiftUp;
                    @ShiftUp.performed += instance.OnShiftUp;
                    @ShiftUp.canceled += instance.OnShiftUp;
                    @ShiftDown.started += instance.OnShiftDown;
                    @ShiftDown.performed += instance.OnShiftDown;
                    @ShiftDown.canceled += instance.OnShiftDown;
                    @Steering.started += instance.OnSteering;
                    @Steering.performed += instance.OnSteering;
                    @Steering.canceled += instance.OnSteering;
                }
            }
        }
        public CarActions @Car => new CarActions(this);

        // Crawler
        private readonly InputActionMap m_Crawler;
        private ICrawlerActions m_CrawlerActionsCallbackInterface;
        private readonly InputAction m_Crawler_RightForward;
        private readonly InputAction m_Crawler_RightReverse;
        private readonly InputAction m_Crawler_LeftForward;
        private readonly InputAction m_Crawler_LeftReverse;
        public struct CrawlerActions
        {
            private @VehicleInput m_Wrapper;
            public CrawlerActions(@VehicleInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @RightForward => m_Wrapper.m_Crawler_RightForward;
            public InputAction @RightReverse => m_Wrapper.m_Crawler_RightReverse;
            public InputAction @LeftForward => m_Wrapper.m_Crawler_LeftForward;
            public InputAction @LeftReverse => m_Wrapper.m_Crawler_LeftReverse;
            public InputActionMap Get() { return m_Wrapper.m_Crawler; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(CrawlerActions set) { return set.Get(); }
            public void SetCallbacks(ICrawlerActions instance)
            {
                if (m_Wrapper.m_CrawlerActionsCallbackInterface != null)
                {
                    @RightForward.started -= m_Wrapper.m_CrawlerActionsCallbackInterface.OnRightForward;
                    @RightForward.performed -= m_Wrapper.m_CrawlerActionsCallbackInterface.OnRightForward;
                    @RightForward.canceled -= m_Wrapper.m_CrawlerActionsCallbackInterface.OnRightForward;
                    @RightReverse.started -= m_Wrapper.m_CrawlerActionsCallbackInterface.OnRightReverse;
                    @RightReverse.performed -= m_Wrapper.m_CrawlerActionsCallbackInterface.OnRightReverse;
                    @RightReverse.canceled -= m_Wrapper.m_CrawlerActionsCallbackInterface.OnRightReverse;
                    @LeftForward.started -= m_Wrapper.m_CrawlerActionsCallbackInterface.OnLeftForward;
                    @LeftForward.performed -= m_Wrapper.m_CrawlerActionsCallbackInterface.OnLeftForward;
                    @LeftForward.canceled -= m_Wrapper.m_CrawlerActionsCallbackInterface.OnLeftForward;
                    @LeftReverse.started -= m_Wrapper.m_CrawlerActionsCallbackInterface.OnLeftReverse;
                    @LeftReverse.performed -= m_Wrapper.m_CrawlerActionsCallbackInterface.OnLeftReverse;
                    @LeftReverse.canceled -= m_Wrapper.m_CrawlerActionsCallbackInterface.OnLeftReverse;
                }
                m_Wrapper.m_CrawlerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @RightForward.started += instance.OnRightForward;
                    @RightForward.performed += instance.OnRightForward;
                    @RightForward.canceled += instance.OnRightForward;
                    @RightReverse.started += instance.OnRightReverse;
                    @RightReverse.performed += instance.OnRightReverse;
                    @RightReverse.canceled += instance.OnRightReverse;
                    @LeftForward.started += instance.OnLeftForward;
                    @LeftForward.performed += instance.OnLeftForward;
                    @LeftForward.canceled += instance.OnLeftForward;
                    @LeftReverse.started += instance.OnLeftReverse;
                    @LeftReverse.performed += instance.OnLeftReverse;
                    @LeftReverse.canceled += instance.OnLeftReverse;
                }
            }
        }
        public CrawlerActions @Crawler => new CrawlerActions(this);

        // Equipment
        private readonly InputActionMap m_Equipment;
        private IEquipmentActions m_EquipmentActionsCallbackInterface;
        private readonly InputAction m_Equipment_Light;
        private readonly InputAction m_Equipment_Hone;
        private readonly InputAction m_Equipment_LeftWinker;
        private readonly InputAction m_Equipment_RightWinker;
        public struct EquipmentActions
        {
            private @VehicleInput m_Wrapper;
            public EquipmentActions(@VehicleInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Light => m_Wrapper.m_Equipment_Light;
            public InputAction @Hone => m_Wrapper.m_Equipment_Hone;
            public InputAction @LeftWinker => m_Wrapper.m_Equipment_LeftWinker;
            public InputAction @RightWinker => m_Wrapper.m_Equipment_RightWinker;
            public InputActionMap Get() { return m_Wrapper.m_Equipment; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(EquipmentActions set) { return set.Get(); }
            public void SetCallbacks(IEquipmentActions instance)
            {
                if (m_Wrapper.m_EquipmentActionsCallbackInterface != null)
                {
                    @Light.started -= m_Wrapper.m_EquipmentActionsCallbackInterface.OnLight;
                    @Light.performed -= m_Wrapper.m_EquipmentActionsCallbackInterface.OnLight;
                    @Light.canceled -= m_Wrapper.m_EquipmentActionsCallbackInterface.OnLight;
                    @Hone.started -= m_Wrapper.m_EquipmentActionsCallbackInterface.OnHone;
                    @Hone.performed -= m_Wrapper.m_EquipmentActionsCallbackInterface.OnHone;
                    @Hone.canceled -= m_Wrapper.m_EquipmentActionsCallbackInterface.OnHone;
                    @LeftWinker.started -= m_Wrapper.m_EquipmentActionsCallbackInterface.OnLeftWinker;
                    @LeftWinker.performed -= m_Wrapper.m_EquipmentActionsCallbackInterface.OnLeftWinker;
                    @LeftWinker.canceled -= m_Wrapper.m_EquipmentActionsCallbackInterface.OnLeftWinker;
                    @RightWinker.started -= m_Wrapper.m_EquipmentActionsCallbackInterface.OnRightWinker;
                    @RightWinker.performed -= m_Wrapper.m_EquipmentActionsCallbackInterface.OnRightWinker;
                    @RightWinker.canceled -= m_Wrapper.m_EquipmentActionsCallbackInterface.OnRightWinker;
                }
                m_Wrapper.m_EquipmentActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Light.started += instance.OnLight;
                    @Light.performed += instance.OnLight;
                    @Light.canceled += instance.OnLight;
                    @Hone.started += instance.OnHone;
                    @Hone.performed += instance.OnHone;
                    @Hone.canceled += instance.OnHone;
                    @LeftWinker.started += instance.OnLeftWinker;
                    @LeftWinker.performed += instance.OnLeftWinker;
                    @LeftWinker.canceled += instance.OnLeftWinker;
                    @RightWinker.started += instance.OnRightWinker;
                    @RightWinker.performed += instance.OnRightWinker;
                    @RightWinker.canceled += instance.OnRightWinker;
                }
            }
        }
        public EquipmentActions @Equipment => new EquipmentActions(this);

        // DumpTruck
        private readonly InputActionMap m_DumpTruck;
        private IDumpTruckActions m_DumpTruckActionsCallbackInterface;
        private readonly InputAction m_DumpTruck_Work;
        public struct DumpTruckActions
        {
            private @VehicleInput m_Wrapper;
            public DumpTruckActions(@VehicleInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Work => m_Wrapper.m_DumpTruck_Work;
            public InputActionMap Get() { return m_Wrapper.m_DumpTruck; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(DumpTruckActions set) { return set.Get(); }
            public void SetCallbacks(IDumpTruckActions instance)
            {
                if (m_Wrapper.m_DumpTruckActionsCallbackInterface != null)
                {
                    @Work.started -= m_Wrapper.m_DumpTruckActionsCallbackInterface.OnWork;
                    @Work.performed -= m_Wrapper.m_DumpTruckActionsCallbackInterface.OnWork;
                    @Work.canceled -= m_Wrapper.m_DumpTruckActionsCallbackInterface.OnWork;
                }
                m_Wrapper.m_DumpTruckActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Work.started += instance.OnWork;
                    @Work.performed += instance.OnWork;
                    @Work.canceled += instance.OnWork;
                }
            }
        }
        public DumpTruckActions @DumpTruck => new DumpTruckActions(this);

        // Backhoe
        private readonly InputActionMap m_Backhoe;
        private IBackhoeActions m_BackhoeActionsCallbackInterface;
        private readonly InputAction m_Backhoe_Lever0;
        private readonly InputAction m_Backhoe_Lever1;
        public struct BackhoeActions
        {
            private @VehicleInput m_Wrapper;
            public BackhoeActions(@VehicleInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Lever0 => m_Wrapper.m_Backhoe_Lever0;
            public InputAction @Lever1 => m_Wrapper.m_Backhoe_Lever1;
            public InputActionMap Get() { return m_Wrapper.m_Backhoe; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(BackhoeActions set) { return set.Get(); }
            public void SetCallbacks(IBackhoeActions instance)
            {
                if (m_Wrapper.m_BackhoeActionsCallbackInterface != null)
                {
                    @Lever0.started -= m_Wrapper.m_BackhoeActionsCallbackInterface.OnLever0;
                    @Lever0.performed -= m_Wrapper.m_BackhoeActionsCallbackInterface.OnLever0;
                    @Lever0.canceled -= m_Wrapper.m_BackhoeActionsCallbackInterface.OnLever0;
                    @Lever1.started -= m_Wrapper.m_BackhoeActionsCallbackInterface.OnLever1;
                    @Lever1.performed -= m_Wrapper.m_BackhoeActionsCallbackInterface.OnLever1;
                    @Lever1.canceled -= m_Wrapper.m_BackhoeActionsCallbackInterface.OnLever1;
                }
                m_Wrapper.m_BackhoeActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Lever0.started += instance.OnLever0;
                    @Lever0.performed += instance.OnLever0;
                    @Lever0.canceled += instance.OnLever0;
                    @Lever1.started += instance.OnLever1;
                    @Lever1.performed += instance.OnLever1;
                    @Lever1.canceled += instance.OnLever1;
                }
            }
        }
        public BackhoeActions @Backhoe => new BackhoeActions(this);
        public interface ICarActions
        {
            void OnAccel(InputAction.CallbackContext context);
            void OnBrake(InputAction.CallbackContext context);
            void OnShiftUp(InputAction.CallbackContext context);
            void OnShiftDown(InputAction.CallbackContext context);
            void OnSteering(InputAction.CallbackContext context);
        }
        public interface ICrawlerActions
        {
            void OnRightForward(InputAction.CallbackContext context);
            void OnRightReverse(InputAction.CallbackContext context);
            void OnLeftForward(InputAction.CallbackContext context);
            void OnLeftReverse(InputAction.CallbackContext context);
        }
        public interface IEquipmentActions
        {
            void OnLight(InputAction.CallbackContext context);
            void OnHone(InputAction.CallbackContext context);
            void OnLeftWinker(InputAction.CallbackContext context);
            void OnRightWinker(InputAction.CallbackContext context);
        }
        public interface IDumpTruckActions
        {
            void OnWork(InputAction.CallbackContext context);
        }
        public interface IBackhoeActions
        {
            void OnLever0(InputAction.CallbackContext context);
            void OnLever1(InputAction.CallbackContext context);
        }
    }
}
