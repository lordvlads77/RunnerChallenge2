using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomSpawner : MonoBehaviour
{
    public GameObject _Obstacle, _Obstacle1, _Obstacle2 = default;
    //private float _spawnerObstacle = default;
    [SerializeField] private float _spawnInterval = default;
    [SerializeField] private Transform _spawnerPosition = default;
    [SerializeField] private Transform _spawnerPosition2 = default;
    [SerializeField] private Transform _spawnerPosition3 = default;

    public void Start()
    {
        StartCoroutine(spawnObs());
    }

    

    private void SpawnObstacle()
    {
        int rand = Random.Range(1, 10);

        if (rand == 1)
        {
            GameObject _obstMoricion = Instantiate(_Obstacle, _spawnerPosition);
            Destroy(_obstMoricion, 8f);
        }
        else if (rand == 5)
        {
            GameObject _MoricionObs = Instantiate(_Obstacle1, _spawnerPosition2);
            Destroy(_MoricionObs, 8f);
        }
        else if (rand == 7)
        {
            GameObject _Petacion = Instantiate(_Obstacle2, _spawnerPosition3);
            Destroy(_Petacion, 8f);
        }
        
    }

    IEnumerator spawnObs()
    {
        while (true)
        {
            SpawnObstacle();
            yield return new WaitForSeconds(_spawnInterval);
        }
    }
}
