using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetPack : MonoBehaviour
{
    public bool Active;
    public bool Flight;
    public float MaxFlightTime = 3f;
    public float CurrentFlightTime;
    public JetPackIcon JetPackIcon;

    private void Update()
    {
        if (Flight==true)
        {
            CurrentFlightTime -= Time.unscaledDeltaTime;
        }
        else
        {
            if (CurrentFlightTime < MaxFlightTime)
            {
                CurrentFlightTime += Time.unscaledDeltaTime/2;
            }
        }
        if (CurrentFlightTime <= 0)
        {
            Active = false;
            JetPackIcon.Deactivate();
        }
        if (CurrentFlightTime >= MaxFlightTime)
        {
            Active = true;
            JetPackIcon.Activate();
        }
        /*else
        {
            Active = true;
        }*/




        if (CurrentFlightTime >= MaxFlightTime)
        {
            CurrentFlightTime = MaxFlightTime;
        }
        JetPackIcon.SetChangeValue(CurrentFlightTime, MaxFlightTime);
    }
}
