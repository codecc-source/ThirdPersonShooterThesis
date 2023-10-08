using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotationMoveAway : MonoBehaviour
{
    public float rotationSpeed, movementSpeed, distanceFromPlayer, detectPlayerDistance;
    private float distance;
    public GameObject player;

    void Update()
    {
        distance = Vector3.Distance(player.transform.position, transform.position);
        if (distance <= detectPlayerDistance)
        {
            // Calculate the direction away from the player
            Vector3 directionToPlayer = player.transform.position - transform.position;
            Vector3 directionAwayFromPlayer = -directionToPlayer.normalized;

            // Rotate towards the direction away from the player
            Quaternion targetRotation = Quaternion.LookRotation(directionAwayFromPlayer);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            if (distance >= distanceFromPlayer)
            {
                transform.position += transform.forward * movementSpeed * Time.deltaTime;
            }
        }
    }
}