using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform SpawnPosition;
    public float BulletSpeed;
    public float ShotPeriod;
    public AudioSource Shot;
    public GameObject Flash;

    float _timer;

    private void Update()
    {
        _timer += Time.unscaledDeltaTime;
        if (_timer >= ShotPeriod)
        {
            if (Input.GetMouseButton(0))
            {
                _timer = 0f;
                Shooter();
            }
        }
        
    }
    public virtual void Shooter()
    {
        GameObject newBullet = Instantiate(BulletPrefab, SpawnPosition.position, SpawnPosition.rotation);
        newBullet.GetComponent<Rigidbody>().velocity = SpawnPosition.forward * BulletSpeed;
        Shot.Play();
        Flash.SetActive(true);
        Invoke("HideFlash", 0.1f);
    }

    public void HideFlash()
    {
        Flash.SetActive(false);
    }
    public virtual void Activate()
    {
        gameObject.SetActive(true);
    }
    
    public virtual void Deactivate()
    {
        gameObject.SetActive(false);
    }

    public virtual void AddBullets(int numberOfBullets)
    {

    }
}
