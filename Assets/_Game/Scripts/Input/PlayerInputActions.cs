// GENERATED AUTOMATICALLY FROM 'Assets/_Game/Scripts/Input/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""MenuNavigation"",
            ""id"": ""5b606ac7-d145-48e4-8a89-659891493217"",
            ""actions"": [
                {
                    ""name"": ""Change"",
                    ""type"": ""Value"",
                    ""id"": ""1e7eae1f-fcb2-4f56-938f-8a6873fbcf2c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""b7bdcff2-15d3-422e-91f6-7ff58d93a654"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""bd37da83-a850-4a92-ad31-f63d1c632095"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""0f04f1b9-bc2d-4ca4-8a86-8d3c4c53991a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""cc4f2f3d-8974-4eaa-8924-0bb1aa761d2d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""25315b70-2f03-43c0-a392-cf9a76b19dd0"",
                    ""path"": ""*/{Back}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Gamepad"",
                    ""action"": ""Change"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""9dfd3b2d-0d06-4dac-bf09-1d506a90578b"",
                    ""path"": ""*/{Forward}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Gamepad"",
                    ""action"": ""Change"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3d75439e-320d-4270-9e1b-7edbadefb943"",
                    ""path"": ""*/{Submit}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Gamepad"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6821f61c-8693-4e5d-bacb-751449ab9321"",
                    ""path"": ""*/{PrimaryAction}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Gamepad"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17084ab2-dcae-4b48-876e-9e60c308e33a"",
                    ""path"": ""*/{Cancel}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Gamepad"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""641adad1-1520-49be-bf64-c5237235a785"",
                    ""path"": ""*/{Menu}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Gamepad"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerControles3d"",
            ""id"": ""f7b302e4-cd89-4319-aa5c-96ec88aac27a"",
            ""actions"": [
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""3d00d37a-a097-4adc-b72b-7e5197ea0c54"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""67572843-2a20-4b3a-a37c-8484baa3216a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""d406b8ca-fe19-47a6-9b45-9eadcd5f285f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""7014123f-b2cc-48d3-815a-5eb48268c8c5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Use"",
                    ""type"": ""Button"",
                    ""id"": ""794c1193-c5b3-4560-bc5f-8dd0bfc34cbd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""6af798b4-3945-4e69-a24c-b4f577f8984c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""eb649ce2-bf0a-45e3-a018-1f4e17cd3164"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07c9c92e-bc4b-4c3a-b98b-7d505009b8ec"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7d93e72b-9fed-4a78-acbb-558475dd7d67"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6e70ca4-9592-4c28-ad74-26683d9aa4df"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32000ed9-389f-4ddf-a63a-288ed6839366"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d75cffcc-d611-4728-b8cb-1462a23bbbd9"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8a0ec840-12a1-4910-a54f-e74412e1a98a"",
                    ""path"": ""*/{Menu}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Gamepad"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1a84104-6362-4beb-9914-f5c8c03fb068"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""keyboard"",
                    ""id"": ""c9118466-382b-4065-ab7f-8463de2d32a1"",
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
                    ""id"": ""5016535b-850e-444b-a7fe-37e603802ea3"",
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
                    ""id"": ""0f3fa2c9-f17f-4314-85a6-1b3bdf7bed5d"",
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
                    ""id"": ""eb866b5b-f9cf-4943-8651-f8bdac0ed79c"",
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
                    ""id"": ""5d64840b-7fc5-4f2f-be66-0074fa8929aa"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""arrows"",
                    ""id"": ""8b85f417-54c9-411c-a9d6-4b30d67dd82d"",
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
                    ""id"": ""6efcb641-7786-465d-a2f8-abb45fc42df6"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""af419085-c84e-480c-8927-864ca85e2ef3"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cf07ec18-8ef2-4b56-95da-902f7c5d8221"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7ea3627e-2966-4d05-bf27-20f717c1da82"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9caa3048-d446-485c-8a04-2c44d4b07f58"",
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
                    ""id"": ""a28b38e9-9679-4157-ba92-4ed67f2ed05d"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c0fb7a9-5a7a-4e05-bbe0-1631709019b9"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""13b7154d-3626-4d19-b21f-536dae5b1300"",
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
            ""name"": ""PlayerAlt3d"",
            ""id"": ""823ccacb-0b90-4c4f-9960-108fa158be07"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""85f82884-8e67-4115-8a1a-907dede84d2a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""109cc268-dbbe-490f-bc85-e39064bc04cb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c62c9ad3-4491-4b6e-9df9-b7479e27a6fd"",
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
                    ""id"": ""ccee438c-a639-4617-b56d-46d86c0741e4"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a22b4931-1a4f-4105-9886-e16e7a926421"",
                    ""path"": ""*/{Cancel}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerControles2d"",
            ""id"": ""cd1863d7-f03b-410d-8f16-1df477cd0b46"",
            ""actions"": [
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""3173a98c-3382-430d-9399-c1319f679f7c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""139e6d4a-8ca0-45d3-af50-545c4d4d6e92"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""0778d6d6-c796-4071-ae3c-59b849aa3580"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Use"",
                    ""type"": ""Button"",
                    ""id"": ""66f868b4-fea5-4860-bfba-ec3b9322c77a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""5027cc66-cfa8-420f-95bb-705ece8dbdd7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""62b32e3d-2fea-4564-bc09-a81bc279be1b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d26e26bf-da7e-4947-af01-6ffdcf7f9a44"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9b7a867a-4a3a-4e82-a2df-1c8177958c71"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""338153e2-d5c4-4552-a9e4-3f331b91d5a0"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""744e1c65-b0de-4ca4-9d5c-2474cba204e8"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aff114ca-7a7c-4308-baf4-f7c6f2224b29"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bdfb1d45-f732-4555-ab34-c0755722a180"",
                    ""path"": ""*/{Menu}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Gamepad"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7bf1f9c7-d840-4b87-8ffb-b66ce8024343"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""CursorNavigation"",
            ""id"": ""c799260a-7f87-4a64-9902-41384de281a6"",
            ""actions"": [
                {
                    ""name"": ""Clic"",
                    ""type"": ""Button"",
                    ""id"": ""9da1a739-b1ff-4451-a72a-b13068065521"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Position"",
                    ""type"": ""Value"",
                    ""id"": ""6dd5cdb5-e3a5-400b-95e4-f980525df950"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5158c362-d029-497b-af00-5098c90e08da"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""16307e3f-6eab-46da-95f8-135ca756fbe8"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Clic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef52cc73-55c7-4064-81d5-fbbefb277a3e"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Clic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4afd31c7-f6ce-4fff-96a2-5d610dba3a97"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e662dfe-d2dc-4ff1-8c83-55376731f19b"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d88ee0a-4e1a-49e7-986e-4952c55bc973"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94686bca-f747-45f8-a83a-6972bd574589"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // MenuNavigation
        m_MenuNavigation = asset.FindActionMap("MenuNavigation", throwIfNotFound: true);
        m_MenuNavigation_Change = m_MenuNavigation.FindAction("Change", throwIfNotFound: true);
        m_MenuNavigation_Select = m_MenuNavigation.FindAction("Select", throwIfNotFound: true);
        m_MenuNavigation_Cancel = m_MenuNavigation.FindAction("Cancel", throwIfNotFound: true);
        m_MenuNavigation_Menu = m_MenuNavigation.FindAction("Menu", throwIfNotFound: true);
        // PlayerControles3d
        m_PlayerControles3d = asset.FindActionMap("PlayerControles3d", throwIfNotFound: true);
        m_PlayerControles3d_Menu = m_PlayerControles3d.FindAction("Menu", throwIfNotFound: true);
        m_PlayerControles3d_Look = m_PlayerControles3d.FindAction("Look", throwIfNotFound: true);
        m_PlayerControles3d_Move = m_PlayerControles3d.FindAction("Move", throwIfNotFound: true);
        m_PlayerControles3d_Jump = m_PlayerControles3d.FindAction("Jump", throwIfNotFound: true);
        m_PlayerControles3d_Use = m_PlayerControles3d.FindAction("Use", throwIfNotFound: true);
        m_PlayerControles3d_Attack = m_PlayerControles3d.FindAction("Attack", throwIfNotFound: true);
        // PlayerAlt3d
        m_PlayerAlt3d = asset.FindActionMap("PlayerAlt3d", throwIfNotFound: true);
        m_PlayerAlt3d_Move = m_PlayerAlt3d.FindAction("Move", throwIfNotFound: true);
        m_PlayerAlt3d_Exit = m_PlayerAlt3d.FindAction("Exit", throwIfNotFound: true);
        // PlayerControles2d
        m_PlayerControles2d = asset.FindActionMap("PlayerControles2d", throwIfNotFound: true);
        m_PlayerControles2d_Menu = m_PlayerControles2d.FindAction("Menu", throwIfNotFound: true);
        m_PlayerControles2d_Move = m_PlayerControles2d.FindAction("Move", throwIfNotFound: true);
        m_PlayerControles2d_Jump = m_PlayerControles2d.FindAction("Jump", throwIfNotFound: true);
        m_PlayerControles2d_Use = m_PlayerControles2d.FindAction("Use", throwIfNotFound: true);
        m_PlayerControles2d_Attack = m_PlayerControles2d.FindAction("Attack", throwIfNotFound: true);
        // CursorNavigation
        m_CursorNavigation = asset.FindActionMap("CursorNavigation", throwIfNotFound: true);
        m_CursorNavigation_Clic = m_CursorNavigation.FindAction("Clic", throwIfNotFound: true);
        m_CursorNavigation_Position = m_CursorNavigation.FindAction("Position", throwIfNotFound: true);
        m_CursorNavigation_Move = m_CursorNavigation.FindAction("Move", throwIfNotFound: true);
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

    // MenuNavigation
    private readonly InputActionMap m_MenuNavigation;
    private IMenuNavigationActions m_MenuNavigationActionsCallbackInterface;
    private readonly InputAction m_MenuNavigation_Change;
    private readonly InputAction m_MenuNavigation_Select;
    private readonly InputAction m_MenuNavigation_Cancel;
    private readonly InputAction m_MenuNavigation_Menu;
    public struct MenuNavigationActions
    {
        private @PlayerInputActions m_Wrapper;
        public MenuNavigationActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Change => m_Wrapper.m_MenuNavigation_Change;
        public InputAction @Select => m_Wrapper.m_MenuNavigation_Select;
        public InputAction @Cancel => m_Wrapper.m_MenuNavigation_Cancel;
        public InputAction @Menu => m_Wrapper.m_MenuNavigation_Menu;
        public InputActionMap Get() { return m_Wrapper.m_MenuNavigation; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuNavigationActions set) { return set.Get(); }
        public void SetCallbacks(IMenuNavigationActions instance)
        {
            if (m_Wrapper.m_MenuNavigationActionsCallbackInterface != null)
            {
                @Change.started -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnChange;
                @Change.performed -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnChange;
                @Change.canceled -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnChange;
                @Select.started -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnSelect;
                @Cancel.started -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnCancel;
                @Menu.started -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_MenuNavigationActionsCallbackInterface.OnMenu;
            }
            m_Wrapper.m_MenuNavigationActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Change.started += instance.OnChange;
                @Change.performed += instance.OnChange;
                @Change.canceled += instance.OnChange;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
            }
        }
    }
    public MenuNavigationActions @MenuNavigation => new MenuNavigationActions(this);

    // PlayerControles3d
    private readonly InputActionMap m_PlayerControles3d;
    private IPlayerControles3dActions m_PlayerControles3dActionsCallbackInterface;
    private readonly InputAction m_PlayerControles3d_Menu;
    private readonly InputAction m_PlayerControles3d_Look;
    private readonly InputAction m_PlayerControles3d_Move;
    private readonly InputAction m_PlayerControles3d_Jump;
    private readonly InputAction m_PlayerControles3d_Use;
    private readonly InputAction m_PlayerControles3d_Attack;
    public struct PlayerControles3dActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerControles3dActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Menu => m_Wrapper.m_PlayerControles3d_Menu;
        public InputAction @Look => m_Wrapper.m_PlayerControles3d_Look;
        public InputAction @Move => m_Wrapper.m_PlayerControles3d_Move;
        public InputAction @Jump => m_Wrapper.m_PlayerControles3d_Jump;
        public InputAction @Use => m_Wrapper.m_PlayerControles3d_Use;
        public InputAction @Attack => m_Wrapper.m_PlayerControles3d_Attack;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControles3d; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControles3dActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControles3dActions instance)
        {
            if (m_Wrapper.m_PlayerControles3dActionsCallbackInterface != null)
            {
                @Menu.started -= m_Wrapper.m_PlayerControles3dActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_PlayerControles3dActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_PlayerControles3dActionsCallbackInterface.OnMenu;
                @Look.started -= m_Wrapper.m_PlayerControles3dActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerControles3dActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerControles3dActionsCallbackInterface.OnLook;
                @Move.started -= m_Wrapper.m_PlayerControles3dActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerControles3dActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerControles3dActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_PlayerControles3dActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerControles3dActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerControles3dActionsCallbackInterface.OnJump;
                @Use.started -= m_Wrapper.m_PlayerControles3dActionsCallbackInterface.OnUse;
                @Use.performed -= m_Wrapper.m_PlayerControles3dActionsCallbackInterface.OnUse;
                @Use.canceled -= m_Wrapper.m_PlayerControles3dActionsCallbackInterface.OnUse;
                @Attack.started -= m_Wrapper.m_PlayerControles3dActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_PlayerControles3dActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_PlayerControles3dActionsCallbackInterface.OnAttack;
            }
            m_Wrapper.m_PlayerControles3dActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Use.started += instance.OnUse;
                @Use.performed += instance.OnUse;
                @Use.canceled += instance.OnUse;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
            }
        }
    }
    public PlayerControles3dActions @PlayerControles3d => new PlayerControles3dActions(this);

    // PlayerAlt3d
    private readonly InputActionMap m_PlayerAlt3d;
    private IPlayerAlt3dActions m_PlayerAlt3dActionsCallbackInterface;
    private readonly InputAction m_PlayerAlt3d_Move;
    private readonly InputAction m_PlayerAlt3d_Exit;
    public struct PlayerAlt3dActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerAlt3dActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerAlt3d_Move;
        public InputAction @Exit => m_Wrapper.m_PlayerAlt3d_Exit;
        public InputActionMap Get() { return m_Wrapper.m_PlayerAlt3d; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerAlt3dActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerAlt3dActions instance)
        {
            if (m_Wrapper.m_PlayerAlt3dActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerAlt3dActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerAlt3dActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerAlt3dActionsCallbackInterface.OnMove;
                @Exit.started -= m_Wrapper.m_PlayerAlt3dActionsCallbackInterface.OnExit;
                @Exit.performed -= m_Wrapper.m_PlayerAlt3dActionsCallbackInterface.OnExit;
                @Exit.canceled -= m_Wrapper.m_PlayerAlt3dActionsCallbackInterface.OnExit;
            }
            m_Wrapper.m_PlayerAlt3dActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Exit.started += instance.OnExit;
                @Exit.performed += instance.OnExit;
                @Exit.canceled += instance.OnExit;
            }
        }
    }
    public PlayerAlt3dActions @PlayerAlt3d => new PlayerAlt3dActions(this);

    // PlayerControles2d
    private readonly InputActionMap m_PlayerControles2d;
    private IPlayerControles2dActions m_PlayerControles2dActionsCallbackInterface;
    private readonly InputAction m_PlayerControles2d_Menu;
    private readonly InputAction m_PlayerControles2d_Move;
    private readonly InputAction m_PlayerControles2d_Jump;
    private readonly InputAction m_PlayerControles2d_Use;
    private readonly InputAction m_PlayerControles2d_Attack;
    public struct PlayerControles2dActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerControles2dActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Menu => m_Wrapper.m_PlayerControles2d_Menu;
        public InputAction @Move => m_Wrapper.m_PlayerControles2d_Move;
        public InputAction @Jump => m_Wrapper.m_PlayerControles2d_Jump;
        public InputAction @Use => m_Wrapper.m_PlayerControles2d_Use;
        public InputAction @Attack => m_Wrapper.m_PlayerControles2d_Attack;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControles2d; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControles2dActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControles2dActions instance)
        {
            if (m_Wrapper.m_PlayerControles2dActionsCallbackInterface != null)
            {
                @Menu.started -= m_Wrapper.m_PlayerControles2dActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_PlayerControles2dActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_PlayerControles2dActionsCallbackInterface.OnMenu;
                @Move.started -= m_Wrapper.m_PlayerControles2dActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerControles2dActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerControles2dActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_PlayerControles2dActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerControles2dActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerControles2dActionsCallbackInterface.OnJump;
                @Use.started -= m_Wrapper.m_PlayerControles2dActionsCallbackInterface.OnUse;
                @Use.performed -= m_Wrapper.m_PlayerControles2dActionsCallbackInterface.OnUse;
                @Use.canceled -= m_Wrapper.m_PlayerControles2dActionsCallbackInterface.OnUse;
                @Attack.started -= m_Wrapper.m_PlayerControles2dActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_PlayerControles2dActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_PlayerControles2dActionsCallbackInterface.OnAttack;
            }
            m_Wrapper.m_PlayerControles2dActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Use.started += instance.OnUse;
                @Use.performed += instance.OnUse;
                @Use.canceled += instance.OnUse;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
            }
        }
    }
    public PlayerControles2dActions @PlayerControles2d => new PlayerControles2dActions(this);

    // CursorNavigation
    private readonly InputActionMap m_CursorNavigation;
    private ICursorNavigationActions m_CursorNavigationActionsCallbackInterface;
    private readonly InputAction m_CursorNavigation_Clic;
    private readonly InputAction m_CursorNavigation_Position;
    private readonly InputAction m_CursorNavigation_Move;
    public struct CursorNavigationActions
    {
        private @PlayerInputActions m_Wrapper;
        public CursorNavigationActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Clic => m_Wrapper.m_CursorNavigation_Clic;
        public InputAction @Position => m_Wrapper.m_CursorNavigation_Position;
        public InputAction @Move => m_Wrapper.m_CursorNavigation_Move;
        public InputActionMap Get() { return m_Wrapper.m_CursorNavigation; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CursorNavigationActions set) { return set.Get(); }
        public void SetCallbacks(ICursorNavigationActions instance)
        {
            if (m_Wrapper.m_CursorNavigationActionsCallbackInterface != null)
            {
                @Clic.started -= m_Wrapper.m_CursorNavigationActionsCallbackInterface.OnClic;
                @Clic.performed -= m_Wrapper.m_CursorNavigationActionsCallbackInterface.OnClic;
                @Clic.canceled -= m_Wrapper.m_CursorNavigationActionsCallbackInterface.OnClic;
                @Position.started -= m_Wrapper.m_CursorNavigationActionsCallbackInterface.OnPosition;
                @Position.performed -= m_Wrapper.m_CursorNavigationActionsCallbackInterface.OnPosition;
                @Position.canceled -= m_Wrapper.m_CursorNavigationActionsCallbackInterface.OnPosition;
                @Move.started -= m_Wrapper.m_CursorNavigationActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CursorNavigationActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CursorNavigationActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_CursorNavigationActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Clic.started += instance.OnClic;
                @Clic.performed += instance.OnClic;
                @Clic.canceled += instance.OnClic;
                @Position.started += instance.OnPosition;
                @Position.performed += instance.OnPosition;
                @Position.canceled += instance.OnPosition;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public CursorNavigationActions @CursorNavigation => new CursorNavigationActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IMenuNavigationActions
    {
        void OnChange(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
    }
    public interface IPlayerControles3dActions
    {
        void OnMenu(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnUse(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
    }
    public interface IPlayerAlt3dActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnExit(InputAction.CallbackContext context);
    }
    public interface IPlayerControles2dActions
    {
        void OnMenu(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnUse(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
    }
    public interface ICursorNavigationActions
    {
        void OnClic(InputAction.CallbackContext context);
        void OnPosition(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
}
