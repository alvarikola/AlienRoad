using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;
    public Button restartButton;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        isGameActive = false;
        panel = GameObject.Find("Panel");
    }

    public void StartGame() {
        isGameActive = true;
        panel.SetActive(false);
    }

    public void GameOver() {
        gameOverText.gameObject.SetActive(true); 
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
