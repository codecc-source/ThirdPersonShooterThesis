using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTarget : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int enemyhealth = 500;
    public GameObject destroyedVersion;
    public int enemyDamage = 1;
    public AudioSource splashEffect;

    public void EnemytakeDamage(int amount)
    {
        enemyhealth -= amount;

        if(enemyhealth <= 0)
        {
            Die();
            ScoringScript.instance.AddScore();
        }
    }

    void Die()
    {
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        splashEffect.Play();
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Taking damage");
            playerHealth.playerTakeDamage(enemyDamage);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Taking damage");
            playerHealth.playerTakeDamage(enemyDamage);
        }
    }
}
