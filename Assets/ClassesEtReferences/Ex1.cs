using System;
using UnityEngine;
namespace ClassesEtReferences
{
    public class Ex1 : MonoBehaviour
    {
        public class Cat
        {
            private string Name;
            private string Color;
            private int Weight;

            public Cat(string name, string color, int weight)
            {
                Name = name;
                Color = color;
                Weight = weight;
            }

            public void Display()
            {
                Debug.Log(Name + " is " + Color + " and weights " + Weight + " kilos");
            }

        }

        private void Start()
        {
            Cat picatso = new Cat("picatso", "white", 5);
            picatso.Display();

        }
    }
}
        
