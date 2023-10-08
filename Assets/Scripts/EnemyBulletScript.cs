using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletScript : MonoBehaviour
{
    public float speed = 10f;
    public int damageAmount = 10;

    private Vector3 target;

    public void SetTarget(Vector3 target, int damageAmount)
    {
        this.target = target;
        this.damageAmount = damageAmount;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (transform.position == target)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>().playerTakeDamage(damageAmount);
            Destroy(gameObject);
        }
    }
}