using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time : MonoBehaviour
{
    public static Time obj;

    [SerializeField] Text gameScore;
    [SerializeField] Text ScoreGainded;

    public float score;

    private void Awake()
    {
        obj = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        updateScore();
    }

    public void updateScore() 
    {
        Time.obj.score++;
        Time.obj.gameScore.text = "Score: " + score.ToString();

    }

    public void GetPoints(int points) 
    {
        score += points;
    }

    public void ShareOnScreenScoreAdd() 
    {
        
    }


}
