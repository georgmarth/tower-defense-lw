using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGame : MonoBehaviour
{
    public PlayerStats stats;

    private void Awake()
    {
        stats.Initialize();
    }
}
