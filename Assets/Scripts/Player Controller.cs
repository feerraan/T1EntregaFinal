using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private AudioSource playerAudioSource;
    [SerializeField] private AudioSource cameraAudioSource;
    [SerializeField] private float speed = 10f;

    [SerializeField] private AudioClip bonaClip;

    private const string buena = "Good Coin";
    private const string mala = "Bad Coin";

    private float horitzontalInput;

    private float verticalInput;

    private float xRange = 9.5f;

    private float zRange = 7f;

    private int puntos = 0;

    private int vidas = 3;

    public bool Win;

    public bool GameOver;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Tienes {puntos} puntos");
        Debug.Log($"Tienes {vidas} vidas");
    }

    // Update is called once per frame
    void Update()
    {

        horitzontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horitzontalInput * Time.deltaTime * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        PlayerInBounds();

    }

    private void PlayerInBounds()
    {
        Vector3 pos = transform.position;

        if (pos.x < -xRange)
        {
            transform.position = new Vector3(-xRange, pos.y, pos.z);

        }

        if (pos.x > xRange)
        {
            transform.position = new Vector3(xRange, pos.y, pos.z);


        }

        if (pos.z < -zRange)
        {
            transform.position = new Vector3(pos.x, pos.y, -zRange);

        }

        if (pos.z > zRange)
        {
            transform.position = new Vector3(pos.x, pos.y, zRange);


        }

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag(buena))
        {
            Destroy(collision.gameObject);
            puntos = puntos + 5;
            Debug.Log($"Tienes {puntos} puntos");
            

            if (puntos == 50)
            {
                Win = true;
                Debug.Log($"Has Ganado");

            }
        }

        if (collision.gameObject.CompareTag(mala))
        {
            Destroy(collision.gameObject);
            vidas = vidas - 1;
            Debug.Log ($"Tienes {vidas} vidas");

            if (vidas == 0)
            {
                GameOver = true;
                Debug.Log($"Has Perdido");

            }
        }
    }

}
