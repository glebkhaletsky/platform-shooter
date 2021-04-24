using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateByDistance : MonoBehaviour
{
    public float DistanceToActivate = 20f;
    private bool _isActivate = true;
    Activator _activator;

    private void Start()
    {
        _activator = FindObjectOfType<Activator>();
        _activator.ActiveEnames.Add(this);
    }
    public void CheckDistance(Vector3 playerPosition)
    {
        float distance = Vector3.Distance(transform.position, playerPosition);
        if (_isActivate)
        {
            if (distance > DistanceToActivate + 2f)
            {
                Deactivate();
            }
        }
        else
        {
            if (distance < DistanceToActivate)
            {
                Activate();
            }
        }
    }

    public void Activate()
    {
        _isActivate = true;
        gameObject.SetActive(true);

    }

    public void Deactivate()
    {
        _isActivate = false;
        gameObject.SetActive(false);
    }

    private void OnDestroy()
    {
        _activator.ActiveEnames.Remove(this);
    }
}
