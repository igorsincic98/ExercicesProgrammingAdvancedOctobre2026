using System;
using Unity.VisualScripting;
using UnityEngine;

namespace HeritageEtScriptableObjects
{

    public class Ex1 : MonoBehaviour
    {
        private void Start()
        {
            Son john = new Son();
            Debug.Log(john.Nom);
        }
    }

    public class Dad
    {
        public string Nom = "Mac Couille";
    }

    public class Son : Dad
    {
        
    }
}