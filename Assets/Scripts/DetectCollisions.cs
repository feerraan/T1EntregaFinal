using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public float Points = 0f;
    public float Lifes = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Points = Points + 5;
        Lifes = Lifes - 1;
        Debug.Log(message: Lifes);
        Debug.Log(message: Points);

    }

}

