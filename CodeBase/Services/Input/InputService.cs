using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CodeBase.Services.Input
{
    public class InputService : iInputServices{
    // вынести в другой файл
        private PlayerInput _input;

        private void Awake() {
        
            _input = new PlayerInput();
        }

            private void OnEnable() {
            _input.Enable();
        }

        private void OnDisable() {
         _input.Disable();
        }
        // 
        public Vector2 Axis =>
            _input.Player.Move.ReadValue<Vector2>();
        
    }
}
