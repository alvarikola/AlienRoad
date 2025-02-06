using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecibePoints : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;
    private GameObject objeto;

    private Vector3 coordenadasInicio;
    private Vector3 initialPosition;
    private float rotationSpeed = 50f;
    private float floatAmplitude = 0.5f;
    private float floatSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateScore(0);
        objeto = GameObject.Find("Player");
        coordenadasInicio = new Vector3(-30, 0, 5);
        initialPosition = transform.position;
    }

    private void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Puntos: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.World);

        float newY = initialPosition.y + Mathf.Sin(Time.time * floatSpeed) * floatAmplitude;
        transform.position = new Vector3(initialPosition.x, newY, initialPosition.z);
    }

    void OnTriggerEnter(Collider other)
    {
        UpdateScore(1);
        objeto.transform.position = coordenadasInicio;
    }
}
