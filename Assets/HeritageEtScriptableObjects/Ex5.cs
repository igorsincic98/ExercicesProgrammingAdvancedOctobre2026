using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace HeritageEtScriptableObjects
{
    public class Ex5 : MonoBehaviour
    {
        public Spell CurrentSpell;

        private void Update()
        {
            if (CurrentSpell != null && Mouse.current.leftButton.isPressed) Debug.Log(" Your spell " + CurrentSpell.name + " inflicts " + CurrentSpell.Damage + " " + CurrentSpell.Effect + " damage.");
        }
    }

    [CreateAssetMenu(fileName = " Spell ")]
    public class Spell : ScriptableObject
    {
        public int Damage;
        public string Effect;
    }
}