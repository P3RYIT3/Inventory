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

    public int[] GetStatMods()
    {
        int[] statChanges = new int[2];
        statChanges[0] = modHealth;
        statChanges[1] = modMana;
        statChanges[2] = modStamina;

        return statChanges;

        //return [modHealth, modMana, modStamina];
    }

    public double GetEffectTimeout()
    {
        return effectTimeout;
    }
}
