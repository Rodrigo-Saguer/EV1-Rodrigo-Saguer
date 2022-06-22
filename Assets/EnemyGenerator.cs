using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] private GameObject m_enemyPrefab;

    List<GameObject> m_pool;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        m_pool = new List<GameObject>();
        StartCoroutine(Generate());
    }

    private void CreateEnemy()
    {
        Vector2 position;
        position.x = Random.Range(-10, 10);
        position.y = Random.Range(-5, 5);

        GameObject instance = m_pool.Find(c => !c.gameObject.activeSelf);
        if (instance == null)
        {
            instance = Instantiate(m_enemyPrefab);
            m_pool.Add(instance);
        }

        instance.SetActive(true);
        instance.transform.position = position;
    }

    IEnumerator Generate()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 3));
            CreateEnemy();
        }
    }
}
