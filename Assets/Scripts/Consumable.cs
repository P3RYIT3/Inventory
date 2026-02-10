using UnityEngine;

[CreateAssetMenu(fileName = "Consumable", menuName = "Scriptable Objects/Consumable")]

public class Consumable: Item
{
    [SerializeField] protected int modHealth;
    [SerializeField] protected int modMana;
    [SerializeField] protected int modStamina;
    [SerializeField] protected int modSTR;
    [SerializeField] protected int modEND;
    [SerializeField] protected int modCHA;
    [SerializeField] protected int modINT;
    [SerializeField] protected int modPER;
    [SerializeField] protected int modLCK;
    [SerializeField] protected double effectTimeout;

    public int GetHealth()
    {
        return modHealth;
    }

    public int GetMana()
    {
        return modMana;
    }

    public int GetStamina()
    {
        return modStamina;
    }

    public double GetEffectTimeout()
    {
        return effectTimeout;
    }
}
