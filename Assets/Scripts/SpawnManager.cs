using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{

    [SerializeField] private GameObject[] CoinsPrefabsArray;
    private int CoinsIndex;

    private float spawnRangeX = 9.5f;
    private float SpawnRangeZ = 7f;

    private float tiempo = 0f;

    [SerializeField] private float StartDelay = 2f;
    [SerializeField] private float SpawnInterval = 1.5f;


    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnRandomCoin", StartDelay, SpawnInterval);
        

    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
     
        Debug.Log(tiempo);
    }

    private void SpawnRandomCoin()
    {
        CoinsIndex = Random.Range(0, CoinsPrefabsArray.Length);
        Instantiate(CoinsPrefabsArray[CoinsIndex],
            RandomSpawnPos(),
            Quaternion.Euler(0, 180, 0));
        if (tiempo > 3)
        {
            Destroy(this);
        }
    }

    private Vector3 RandomSpawnPos()
    {
        float randomx = Random.Range(-spawnRangeX, spawnRangeX);
        float randomz = Random.Range(-SpawnRangeZ, SpawnRangeZ);
        return new Vector3(randomx, 0, randomz);

    }


}
