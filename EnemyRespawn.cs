using UnityEngine;
using System.Collections;

public class EnemyRespawn : MonoBehaviour {

    public Transform Octopus;
    public Transform respawnPoint;
    public Transform respawnPoint1;
    public Transform respawnPoint2;

    public float spawnTime = 3.0f; 

    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    void Spawn ()
    {
        Instantiate(Octopus, respawnPoint.position, respawnPoint.rotation);
        Instantiate(Octopus, respawnPoint1.position, respawnPoint1.rotation);
        Instantiate(Octopus, respawnPoint2.position, respawnPoint2.rotation);
        Octopus.GetComponent<EnemyAI>().speed += 1;
    }
}
