using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager obj;

    [SerializeField] Text pointsPlayer1;
    [SerializeField] Text pointsPlayer2;
    [SerializeField] Ball ball;


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
        
    }

    public void UpdatePoints(int player) 
    {
        int points1 = ball.pointsOfPlayer1;
        int points2 = ball.pointsOfPlayer2;

        string points1ToString1 = points1.ToString();
        string points1ToString2 = points1.ToString();

        if (player == 1)
        {
            UIManager.obj.pointsPlayer1.text = points1ToString1;
        }

        if(player == 2) 
        {
            UIManager.obj.pointsPlayer2.text = points1ToString2;
        }
    }
}
