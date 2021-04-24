using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Automat : Gun
{
    [Header("Automat")]
    public int Bullets;
    public Text BulletsText;
    public PlayerArmory PlayerArmory;
    public override void Shooter()
    {
        base.Shooter();
        Bullets -= 1;
        UpdateText();
        if (Bullets <= 0)
        {
            PlayerArmory.TakeGunByIndex(0);
            
        }
    }

    public override void Activate()
    {
        base.Activate();
        BulletsText.enabled = true;
        UpdateText();
    }

    public override void Deactivate()
    {
        base.Deactivate();
        BulletsText.enabled = false;
    }

    void UpdateText()
    {
        BulletsText.text = "Bullets: " + Bullets.ToString();
    }

    public override void AddBullets(int numberOfBullets)
    {
        base.AddBullets(numberOfBullets);
        Bullets += numberOfBullets;
        PlayerArmory.TakeGunByIndex(1);
        UpdateText();
    }
}
