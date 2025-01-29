using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    
    public Transform bulletSpawnPoint; // The bullet spawn point
    public GameObject bulletPrefab; // The bullet prefab
    public float bulletSpeed = 10;
    
    void Update()
    {

        Transform bulletSpawnPoint = transform;
        
        {
            // Check if the prefab and spawn point are not null
            if (bulletPrefab != null)
            {
                //Instantiate the  bullet prefab at the bullet spawn point
                GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

                //Check if the bullet was instatiated correctly
                if (bullet != null)
                {
                    Debug.Log("Bullet instantiated correctly");

                }

            }
            else
            {
                Debug.LogError("Bullet prefab or spawn point is null");

            }
        }
    }
}



