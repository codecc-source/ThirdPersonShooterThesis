using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestructableTimeTrial : MonoBehaviour
{
    public GameObject destroyedVersion;

    public void Destroy()
    {
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision was with the player object
        if (collision.gameObject.CompareTag("Player"))
        {            
            Destroy();
            timeTrialScore.instance.ttAddScore();
        }
    }
}
