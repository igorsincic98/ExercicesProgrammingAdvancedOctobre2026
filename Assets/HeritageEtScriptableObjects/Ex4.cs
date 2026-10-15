using System;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace HeritageEtScriptableObjects
{

    public class Ex4 : MonoBehaviour
    {
        private void Start()
        {
            Weapon weapon = new Weapon(5, "Sunglasses", 4);
            Armor armor = new Armor(5, "Swimsuit", 10);
            weapon.Buy();
            armor.Buy();
            weapon.Attack();   
            armor.Protect();
        }
    }

    public abstract class Item
    {
        public int Price;
        public string Name;

        public void Buy()
        {
            Debug.Log("You buy " + Name + " for " + Price + " gold.");
        }
    }

    public class Weapon : Item

    {
        public int Damage;

        public Weapon(int price, string name, int damage)
        {
            Price = price;
            Name = name;
            Damage = damage;
        }

        public void Attack()
        {
            Debug.Log("You deal " + Damage + " damage with " + Name + ".");
        }
    }

    public class Armor : Item
    {
        public int Protection;

        public Armor(int price, string name, int protection)
        {
            Price = price;
            Name = name;
            Protection = protection;
        }

        public void Protect()
        {
            Debug.Log(Name + " protects you from " + Protection + " damage.");
        }
    }
    
}