using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using System.Threading;
using UnityEngine.UIElements;

public class Player_Controller : MonoBehaviour
{

    public float CurrentSpeed;
    public Vector3 mousePosG;
    Camera cam;
    public Vector2 newPosition;
    private TextMeshProUGUI ScoreText;


    private int score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ScoreText = GetComponentInChildren<TextMeshProUGUI>();


        if (ScoreText == null)
        {
            Debug.LogError("No TextMeshProUGUI component found on this GameObject.");
        }

        cam = Camera.main;
    }

    void FixedUpdate()
    {
        mousePosG = cam.ScreenToWorldPoint(Input.mousePosition);

        newPosition = Vector2.MoveTowards(transform.position, mousePosG, CurrentSpeed * Time.fixedDeltaTime);

        transform.position = newPosition;

        setScoreText();
    }

    public void setScoreText()
    {
        
        string message = string.Format("SCORE: {0000000}", score);
        ScoreText.SetText(message);
    }
    public void AddScore(int points)
    {
        score += points;
        setScoreText(); 
    }
}
