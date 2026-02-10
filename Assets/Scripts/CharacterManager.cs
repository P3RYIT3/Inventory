using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class CharacterManager : MonoBehaviour
{
    [SerializeField] private Slider healthSlider;
    [SerializeField] private Slider manaSlider;
    [SerializeField] private Slider staminaSlider;
    [SerializeField] private TMP_Text healthSliderText;
    [SerializeField] private TMP_Text manaSliderText;
    [SerializeField] private TMP_Text staminaSliderText;
    
    [SerializeField] private TMP_Text attackDamageText;
    [SerializeField] private TMP_Text defenseText;
    [SerializeField] private Image weaponImage;
    [SerializeField] private Image[] armourImages;

    private int health;
    private int mana;
    private int stamina;
    private int defense;
    private Weapon weapon;
    private List<Armour> armourSet = new List<Armour>();

    public void UseItem(Item item)
    {
        if (item is Consumable)
        {
            Consume((Consumable) item);
            
        } else if (item is Weapon)
        {
            SetWeapon((Weapon)item);
        }
        else if (item is Armour)
        {
            SetArmour((Armour)item);
        }
    }

    private void Consume(Consumable consumable)
    {
        health += consumable.GetHealth();
        if (health <= 100)
        {
            healthSlider.value = health;
            healthSliderText.text = $"{health}";
        }
        
        mana += consumable.GetMana();
        if (mana <= 100)
        {
            manaSlider.value = mana;  
            manaSliderText.text = $"{mana}";
        }
        
        stamina += consumable.GetStamina();
        if (stamina <= 100)
        {
            staminaSlider.value = stamina;  
            staminaSliderText.text = $"{stamina}";
        }
    }

    private void SetWeapon(Weapon weapon)
    {
        this.weapon = weapon;
        attackDamageText.text = weapon.GetDamage().ToString();
        weaponImage.sprite = weapon.GetSprite();
    }

    private void SetArmour(Armour armour)
    {
        armourSet.Add(armour);
        if (armourSet.Count > 3)
        {
            armourSet.RemoveAt(0);
        }

        defense = 0;
        for (int i = 0; i < armourSet.Count; i++)
        {
            defense += armourSet[i].GetDefenseValue();
            armourImages[i].sprite = armourSet[i].GetSprite();
        }
        
        defenseText.text = $"{defense}";

    }
}
