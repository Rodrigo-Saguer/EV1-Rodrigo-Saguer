using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBrain : MonoBehaviour
{
    //Variables
    [SerializeField] private SOEnemy[] m_enemies;
    [SerializeField] private SpriteRenderer m_spriteRenderer;
    [Space]
    [SerializeField] private string m_name;
    [SerializeField] private int m_damage;
    [SerializeField] private int m_hp;

    //Methods
    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    private void OnEnable()
    {
        SetValues(m_enemies[Random.Range(0, m_enemies.Length)]);
        StartCoroutine(DisableOnSeconds(3));
    }

    public void SetValues(SOEnemy enemy)
    {
        m_name = enemy.enemyName;
        m_damage = enemy.damage;
        m_hp = enemy.hp;
        m_spriteRenderer.sprite = enemy.sprite;
    }

    //Coroutines
    private IEnumerator DisableOnSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        gameObject.SetActive(false);
    }
}
