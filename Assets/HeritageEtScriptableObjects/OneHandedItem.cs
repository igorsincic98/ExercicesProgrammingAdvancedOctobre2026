using UnityEngine;

public abstract class OneHandedItem : ScriptableObject
{
    public string TextSound;
    
    public abstract void Use();
}
