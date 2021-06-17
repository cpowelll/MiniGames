using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject eggPrefab;
    public float minSpawnDelay = .5f;
    public float maxSpawnDelay = 4f;
    public float spawnXLimit = 0f;
    public float speed = 5f;
    Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
      rigidBody = GetComponent<Rigidbody2D>();
      Move(speed);
      Invoke("Spawn", 3f);
    }

    void Move(float theSpeed){
      rigidBody.velocity = new Vector2(theSpeed, 0f);

    }
    void StopMovement(){
      Move(0);
    }

    void Spawn(){
      //Create a egg at a random x position
      // float random = Random.Range(-spawnXLimit, spawnXLimit);
      StopMovement();
      Vector3 spawnPos = transform.position + new Vector3(0f, -1.2f, 0f);
      // Instantiate(eggPrefab, spawnPos, Quaternion.identity);
      float theSpeed = Random.Range(-speed, speed);
      Move(theSpeed);
      Invoke("Spawn", Random.Range(minSpawnDelay, maxSpawnDelay));
    }
}
