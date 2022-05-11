using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerObjects : MonoBehaviour
{
    [SerializeField] private Coin _prefab;

    private List<Transform> _points;
    private int _currentPoint;

    private void Awake()
    {
        CreatePointsSpawn();
        Spawn();
    }

    private void CreatePointsSpawn()
    {
        _points = new List<Transform>();

        for (int i = 0; i < transform.childCount; i++)
            _points.Add(gameObject.transform.GetChild(i));
    }

    private void Spawn()
    {
        for (_currentPoint = 0; _currentPoint < _points.Count; _currentPoint++)
            Instantiate(_prefab, _points[_currentPoint]);
    }
}
