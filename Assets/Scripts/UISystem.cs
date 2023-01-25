using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISystem
{
    private GUIController _gui;
    private InputController _input;
    private Player _player; //dont know where by now. think its lower level hierarhy class;

   public UISystem(Player player)
   {
        _gui = new GUIController();
        _input = new InputController();
        _player = player;
        _player.Initialize(_input);
   } 
}
