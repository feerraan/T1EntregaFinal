using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGood : MonoBehaviour
{
    public float Points = 0f;
    private float tiempo = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(message: Points);

        tiempo += Time.deltaTime;
        if (tiempo > 3)
        {
            Destroy(gameObject);
            tiempo = 0;
        }
    }

     private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Points = Points + 5;
    }
}