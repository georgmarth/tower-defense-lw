using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plot : MonoBehaviour
{
    public Transform TowerPlacement;

    
    private Tower Tower;

    public void BuildTower(TowerBlueprint tower)
    {
        if (Tower == null)
        {
            GameObject towerInstanceObject = Instantiate(tower.Prefab, TowerPlacement.position, TowerPlacement.rotation, TowerPlacement);
            Tower = towerInstanceObject.GetComponent<Tower>();
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
}
