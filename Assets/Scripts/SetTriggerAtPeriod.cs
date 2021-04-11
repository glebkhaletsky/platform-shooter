using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTriggerAtPeriod : MonoBehaviour
{
    public Animator Animator;
    public float Period = 7f;
    float _timer;
    public string TriggerName = "Attack";

    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > Period)
        {
            _timer = 0;
            Animator.SetTrigger(TriggerName);
        }
    }
}
