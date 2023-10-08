using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyRotation : MonoBehaviour
{
    public float rotationSpeed, movementSpeed, distanceFromPlayer, detectPlayerDistance;
    private float distance;
    public GameObject player;

    void Update()
    {
        distance = Vector3.Distance(player.transform.position, transform.position);
        if(distance <= detectPlayerDistance)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(transform.position - player.transform.position), rotationSpeed * Time.deltaTime);

            if(distance >= distanceFromPlayer)
            {
                transform.position += -transform.forward * movementSpeed * Time.deltaTime;
            }
        }
    }
}
