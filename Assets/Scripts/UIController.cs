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

public class UIController
{
    private PlayerInputs.UIInputsActions _input;    
    private InventoryUI _inventory; //notimplemented yet it is veiwcontroller and in creates controller and feed inventory to it

    public UIController(IUIInputsProvider inputs, IInventoryDataProvider inventoryData)
    {
        _input = inputs.GetUIInputs();
        SubscribeInputs();
        _inventory.Initialize(inventoryData);
        _input.Inventory.performed += OpenInventory;
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
