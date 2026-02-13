using System;
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

    private int health = 50;
    private int mana = 50;
    private int stamina = 50;
    private int defense;
    private Weapon weapon;
    private List<Armour> armourSet = new List<Armour>();
    
    //SLIDERS

    private void Awake()
    {
        healthSlider.value = health;
        healthSliderText.text = $"{health}";
        
        manaSlider.value = mana;  
        manaSliderText.text = $"{mana}";
        
        staminaSlider.value = stamina;  
        staminaSliderText.text = $"{stamina}";
        
    }


    public void UseItem(Item item)
    {
        if (item is Consumable)
        {
            Consume((Consumable) item);
            
        } else if (item is Weapon)
        {
            SetWeapon((Weapon) item);
        }
        else if (item is Armour)
        {
            SetArmour((Armour) item);
        }
    }

    private void Consume(Consumable consumable)
    {
        switch (health + consumable.GetHealth())
        {
            case > 100:
                health = 100;
                healthSlider.value = 100;
                healthSliderText.text = "100";
                break;
            case < 0:
                health = 0;
                healthSliderText.text = "0";
                healthSlider.value = 0;
                break;
            default:
                health += consumable.GetHealth();
                healthSlider.value = health;
                healthSliderText.text = $"{health}";
                break;
        }
        
        switch (mana + consumable.GetMana())
        {
            case > 100:
                mana = 100;
                manaSlider.value = 100;
                manaSliderText.text = "100";
                break;
            case < 0:
                mana = 0;
                manaSliderText.text = "0";
                manaSlider.value = 0;
                break;
            default:
                mana += consumable.GetMana();
                manaSlider.value = mana;
                manaSliderText.text = $"{mana}";
                break;
        }
        
        switch (stamina+ consumable.GetStamina())
        {
            case > 100:
                stamina = 100;
                staminaSlider.value = 100;
                staminaSliderText.text = "100";
                break;
            case < 0:
                stamina = 0;
                staminaSliderText.text = "0";
                staminaSlider.value = 0;
                break;
            default:
                stamina += consumable.GetStamina();
                staminaSlider.value = stamina;
                staminaSliderText.text = $"{stamina}";
                break;
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
