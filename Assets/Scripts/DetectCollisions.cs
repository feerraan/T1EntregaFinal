using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetectCollisions : MonoBehaviour

{

    [SerializeField] private GameObject[] GoodCoin;
    public float Points = 0f;
    public float Lifes = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(message:Points);
        Debug.Log(message: Lifes);
    }

    private void OnTriggerEnter(Collider CoinsPrefabArray)
    {
        Lifes = Lifes - 1;
        Points = Points + 5;
    }

    If(Collider GoodCoin)
    {
        Debug.LogWarning(message: GoodCoin);

    }
}

