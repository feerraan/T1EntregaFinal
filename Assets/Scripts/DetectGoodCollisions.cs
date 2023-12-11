using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectGoodCollisions : MonoBehaviour
{
    public float Points = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(message: Points);
    }

    private void OnTriggerEnter(Collider other)
    {
        Points = Points + 5;
    }
}
