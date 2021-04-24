using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JetPackIcon : MonoBehaviour
{
    public Image Background;
    public Image Foreground;
 
    public void SetChangeValue(float currentChange, float maxChange)
    {
        Background.fillAmount = currentChange / maxChange;
    }
    public void Deactivate()
    {
        Foreground.color = new Color(1f, 1f, 1f, 0.3f);
    }

    public void Activate()
    {
        Foreground.color = new Color(1f, 1f, 1f, 1f);
    }
}
