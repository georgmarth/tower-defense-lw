using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public float LookRadius = 3f;
    public LayerMask EnemyMask;
    public Transform TowerHead;

    private void Update()
    {
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

        }
    }

    private void Target(Transform enemy)
    {
        Quaternion rotation = TowerHead.rotation;
        TowerHead.LookAt(enemy);
    }
}
