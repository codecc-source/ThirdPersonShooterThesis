using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float bulletSpeed = 20f;
    public float spawnRate = 1f;
    public int damageAmount = 10;

    private GameObject player;
    private float timer = 0f;
    private Vector3 playerLastPosition;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        // Check if the player object is null
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            return;
        }

        // Calculate the distance between the enemy and the player
        float distance = Vector3.Distance(transform.position, player.transform.position);

        // Check if the player is within range
        if (distance < 15f)
        {
            // Increment the timer
            timer += Time.deltaTime;

            // Check if enough time has passed to spawn another bullet
            if (timer >= spawnRate)
            {
                // Reset the timer
                timer = 0f;

                // Store the player's last position
                playerLastPosition = player.transform.position;

                // Create a new bullet
                GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);

                // Set the bullet's velocity towards the player's last position
                Vector3 direction = (playerLastPosition - transform.position).normalized;
                bullet.GetComponent<Rigidbody>().velocity = direction * bulletSpeed;

                // Set the rotation of the bullet to face the player
                bullet.transform.LookAt(playerLastPosition);
                bullet.transform.Rotate(90f, 0f, 0f);

                // Set the bullet's target to the player's last position
                bullet.GetComponent<EnemyBulletScript>().SetTarget(playerLastPosition, damageAmount);

                // Destroy the bullet after 5 seconds
                Destroy(bullet, 5f);
            }
        }
    }
}