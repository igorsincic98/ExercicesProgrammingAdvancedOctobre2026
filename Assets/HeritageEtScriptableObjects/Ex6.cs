using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace HeritageEtScriptableObjects
{
    public class Ex6 : MonoBehaviour
    {
        public OneHandedItem RightHand;
        public OneHandedItem LeftHand;

        private void Update()
        {
            if (RightHand != null && Mouse.current.leftButton.wasPressedThisFrame) RightHand.Use();
            if (LeftHand != null && Mouse.current.leftButton.wasPressedThisFrame) LeftHand.Use();
        }
    }
}