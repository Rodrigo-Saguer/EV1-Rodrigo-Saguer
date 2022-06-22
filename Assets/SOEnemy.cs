using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "Game/Enemy")]
public class SOEnemy : ScriptableObject
{
    [Header("Values")]
    [SerializeField] private string m_name;
    [SerializeField] private int m_damage;
    [SerializeField] private int m_hp;
    [SerializeField] private Sprite m_sprite;

    public string enemyName => m_name;
    public int damage => m_damage;
    public int hp => m_hp;
    public Sprite sprite => m_sprite;
}
