using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBack : MonoBehaviour
{
    [SerializeField]
    Transform spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            CharacterController controller = other.gameObject.GetComponent<CharacterController>();
            controller.enabled = false;
            other.gameObject.transform.position = spawnPoint.position;
            controller.enabled = true;

        }

    }
}
