using System;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu]
public class PlayerStats : ScriptableObject
{
    public int StartingHealth = 100;
    public int StartingMoney = 100;

    public int Health { get; private set; }
    public int Money { get; private set; }

    public Action<int, int> OnHealthChanged;
    public Action<int, int> OnMoneyChanged;

    public void Initialize()
    {
        Health = StartingHealth;
        Money = StartingMoney;
    }

    public bool Pay(int amount)
    {
        if (Money >= amount)
        {
            int oldAmount = Money;
            Money -= amount;
            OnMoneyChanged?.Invoke(oldAmount, Money);
            return true;
        }
        return false;
    }

    public void GainMoney(int amount)
    {
        int oldAmount = Money;
        Money += amount;
        OnMoneyChanged?.Invoke(oldAmount, Money);
    }
}

[CustomEditor(typeof(PlayerStats))]
public class PlayerStatsEditor : Editor
{
    PlayerStats PlayerStats;
    Action<int, int> ValueChangedLambda;

    private void OnEnable()
    {
        ValueChangedLambda = (int oldAmount, int Amount) => EditorUtility.SetDirty(target);
        PlayerStats = target as PlayerStats;
        PlayerStats.OnMoneyChanged += ValueChangedLambda;
        PlayerStats.OnHealthChanged += ValueChangedLambda;
    }

    private void OnDisable()
    {
        PlayerStats.OnMoneyChanged -= ValueChangedLambda;
        PlayerStats.OnHealthChanged -= ValueChangedLambda;
    }

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        EditorGUILayout.BeginVertical();
        EditorGUILayout.LabelField("Current Money: " + PlayerStats.Money);
        EditorGUILayout.LabelField("Current Health: " + PlayerStats.Health);
        EditorGUILayout.EndVertical();
    }
}
