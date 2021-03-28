using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageScreen : MonoBehaviour
{
    public Image DamageFrame;

    public void ShowEffect()
    {
        StartCoroutine(DamageEffect());
    }
    public IEnumerator DamageEffect()
    {
        DamageFrame.enabled = true;
        for (float t = 1; t > 0; t-=Time.deltaTime)
        {
            DamageFrame.color = new Color(1, 0, 0, t);
            yield return null;
        }
        DamageFrame.enabled = false;
    }
}
