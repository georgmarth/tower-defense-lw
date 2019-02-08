using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public float LookRadius = 3f;
    public LayerMask EnemyMask;
    public Transform TowerHead;
    public Transform Spawner;

    public GameObject[] Beans;
    public float Rate = 1f;
    public float EjectVelocity = 5f;

    float countDownTimer;

    private void Start()
    {
        countDownTimer = Rate;
    }

    private void Update()
    {
        countDownTimer -= Time.deltaTime;

        var enemies = Physics.OverlapSphere(TowerHead.position, LookRadius, EnemyMask);
        Collider closest = null;
        float currentEnemyDst = float.MaxValue;
        foreach (var enemy in enemies)
        {
            float dst = (enemy.transform.position - TowerHead.position).sqrMagnitude;
            if (dst < currentEnemyDst)
            {
                closest = enemy;
                currentEnemyDst = dst;
            }
        }

        if (closest != null)
        {
            Target(closest.transform);
            Shoot();
        }
    }

    private void Target(Transform enemy)
    {
        Quaternion rotation = TowerHead.rotation;
        TowerHead.LookAt(enemy);
    }

    private void Shoot()
    {
        if (countDownTimer <= 0f)
        {
            countDownTimer = Rate;
            int index = Random.Range(0, Beans.Length);
            var bean = Instantiate(Beans[index], Spawner.position, Spawner.rotation);
            Rigidbody beanRB = bean.GetComponent<Rigidbody>();
            beanRB.velocity = bean.transform.forward * EjectVelocity;
        }
    }
}
