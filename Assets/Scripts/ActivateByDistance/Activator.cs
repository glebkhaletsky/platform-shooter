using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public List<ActivateByDistance> ActiveEnames = new List<ActivateByDistance>();

    public Transform PlayerTransform;


    private void Update()
    {
        for (int i = 0; i < ActiveEnames.Count; i++)
        {
            ActiveEnames[i].CheckDistance(PlayerTransform.position);
        }
    }
}
