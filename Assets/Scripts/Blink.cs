using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    public Renderer[] Renderers;

    public void ShowBlink()
    {
        StartCoroutine(BlinkEffect());
    }
    public IEnumerator BlinkEffect()
    {
        for (float t = 0; t < 1; t+=Time.deltaTime)
        {
            for (int i = 0; i < Renderers.Length; i++)
            {
                Renderers[i].material.SetColor("_EmissionColor", new Color(Mathf.Sin(t * 30) * 0.5f + 0.5f, 0, 0, 0));
                yield return null;
            }
        }
    }
}
