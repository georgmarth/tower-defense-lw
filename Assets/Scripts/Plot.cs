using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plot : MonoBehaviour
{
    public Tower Tower;

    public void BuildTower(TowerBlueprint tower)
    {

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
