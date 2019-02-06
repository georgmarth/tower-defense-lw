using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plot : MonoBehaviour
{
    public Transform TowerPlacement;
    public PlayerStats PlayerStats;
    
    private Tower Tower;

    public void BuildTower(TowerBlueprint towerBP)
    {
        if (Tower == null)
        {
            if (PlayerStats.Pay(towerBP.Cost))
            {
                GameObject towerInstanceObject = Instantiate(towerBP.Prefab, TowerPlacement.position, TowerPlacement.rotation, TowerPlacement);
                Tower = towerInstanceObject.GetComponent<Tower>();
                Tower.PlayerStats = PlayerStats;
            }
        }
    }

    public void SellTower()
    {
        if (Tower != null)
        {
            Tower.Sell();
            Tower = null;
        }
    }

    public void Click(TowerBlueprint tower)
    {
        if (Tower == null)
        {
            BuildTower(tower);
        }
        else
        {
            SellTower();
        }
    }
}
