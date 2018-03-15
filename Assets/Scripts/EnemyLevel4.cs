using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLevel4 : MonoBehaviour
{

    [SerializeField] GameObject deathFX;
    [SerializeField] int hits = 9;
    [SerializeField] int hitScore = 10;

    GameScore scoreBoard;

    // Use this for initialization
    void Start()
    {
        AddBoxCollider();
        scoreBoard = FindObjectOfType<GameScore>();
    }

    private void AddBoxCollider()
    {
        Collider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;
    }

    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
        if (hits <= 1)
        {
            KillEnemy();
        }
    }

    private void ProcessHit()
    {
        scoreBoard.OnEnemyHit(hitScore);
        hits = hits - 1;
    }

    private void KillEnemy()
    {
        GameObject fx = Instantiate(deathFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
