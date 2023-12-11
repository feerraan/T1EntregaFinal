using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private int Points = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(message:Points);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Points = Points + 5;
    }
}

