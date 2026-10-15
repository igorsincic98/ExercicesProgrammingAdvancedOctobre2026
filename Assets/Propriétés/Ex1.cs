using UnityEngine;

namespace Propriétés
{
    public class Ex1 : MonoBehaviour
    {
        public Character character = new Character(2);

        [ContextMenu("Damage")]
        public void Damage()
        {
            character.Health--;
            Debug.Log("The Character takes 1 damage.");
        }
        
        private void Update()
        {
            if (character.IsDead) Debug.Log("The Character is dead !");
        }
    }

    public class Character
    {
        private int _health;
        public bool IsDead { get; private set; }

        public int Health
        {
            get { return _health ; }
            set {_health = value;
                if (_health <= 0)
                {
                    IsDead = true;
                }
            }
        }
        public Character(int health)
        {
            _health = health;
        }
            
    }
}
