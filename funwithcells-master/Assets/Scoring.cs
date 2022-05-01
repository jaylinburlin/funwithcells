using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public float score = 0f;
    [SerializeField] Text scoreText;   // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        if(Input.GetMouseButtonDown(0))
        {
            score += 250;
        }   
    }
}
