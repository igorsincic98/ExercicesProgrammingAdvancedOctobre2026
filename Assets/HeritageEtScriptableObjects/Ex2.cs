using System;
using UnityEngine;

namespace HeritageEtScriptableObjects
{
    public class Ex2 : MonoBehaviour
    {
        private void Start()
        {
            Dog woofgang = new Dog(true, 4);
            woofgang.Bark();
            woofgang.Die();
            woofgang.Bark();
        }
    }

    public abstract class Animal
    {
        public bool IsAlive;

        public void Die()
        {
            IsAlive = false;
        }
        
    }

    public abstract class Mammal : Animal
    {
        public int PawNumber;
        
    }

    public class Dog : Mammal
    {
        public Dog(bool isAlive, int pawNumber)
        {
            IsAlive = isAlive;
            PawNumber = pawNumber;
        }

        public void Bark()
        {
            if (IsAlive) Debug.Log("Woof !");
        }
    }
}