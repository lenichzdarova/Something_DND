using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// highest ui layer
/// all ui lower sections mast be prefabed and load from resouces while initialize IUcontroller
/// inventoryUI, CharacterSheetUI, etc
/// </summary>

public class UIController : MonoBehaviour 
{
    private PlayerInputs.UIInputsActions _input;    
    [SerializeField] private InventoryUI _inventory;
    [SerializeField] private GroupPanelController _groupPanel;


    public void Initialize(IUIInputsProvider inputs)
    {
        _input = inputs.GetUIInputs();
        SubscribeInputs();
        //_inventory.Initialize(inventoryData);
        _groupPanel.Initialize(new PlayerGroup()); //GAG!!!!!!!!
    }    
    
    private void SubscribeInputs()
    {
        _input.Inventory.performed += OpenInventory;
    }

    private void UnsubscribeInputs()
    {
        _input.Inventory.performed -= OpenInventory;
    }

    private void OpenInventory(InputAction.CallbackContext context)
    {
        _inventory.Activate();
    }
}
