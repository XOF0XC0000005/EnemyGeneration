using System.Collections;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private Transform _parentSpawner;
    private Transform[] _spawners;

    void Start()
    {
        GetAllSpawners();
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            for (int i = 0; i < _spawners.Length; i++)
            {
                Instantiate(_enemyPrefab, _spawners[i].transform.position * 2, _spawners[i].transform.rotation);
                yield return new WaitForSeconds(2);
            }
        }    
    }

    private void GetAllSpawners()
    {
        _spawners = new Transform[_parentSpawner.childCount];

        for (int i = 0; i < _parentSpawner.childCount; i++)
        {
            _spawners[i] = _parentSpawner.GetChild(i);
        }
    }
}
