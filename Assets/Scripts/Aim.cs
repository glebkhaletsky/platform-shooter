using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    public Transform Pointer;
    public Camera CameraPlayer;
    public Transform Body;

    private void LateUpdate()
    {
        Ray ray = CameraPlayer.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 10f);

        Plane plane = new Plane(-Vector3.forward, Vector3.zero);

        float distance;
        plane.Raycast(ray, out distance);
        Vector3 point = ray.GetPoint(distance);
        Pointer.position = point;

        Vector3 toAim = Pointer.position - transform.position;
        transform.rotation = Quaternion.LookRotation(toAim);

        float y = Mathf.Clamp(toAim.x * -30f, -30f, 30f);
        Body.rotation = Quaternion.Lerp(Body.transform.rotation, Quaternion.Euler(0f, y, 0f), 5f * Time.deltaTime);
    }
}
