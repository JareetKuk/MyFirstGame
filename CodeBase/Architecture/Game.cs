using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeBase.Services.Input;

namespace CodeBace.Arhitecture
{
    public class Game {
        public static iInputServices InputService;

        public Game(){
            InputService = InputService();
        }
    }
}

