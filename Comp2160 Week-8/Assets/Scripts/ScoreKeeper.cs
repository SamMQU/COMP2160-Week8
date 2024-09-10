using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField][Min(1)] private int pointPerCoin = 5;
    [SerializeField] private GameObject player;
    private int currentScore;
    // Start is called before the first frame update
    void Awake()
    {
        currentScore = 0;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void updateScore()
    {
        currentScore += pointPerCoin;
    }

    public int getScore()
    {
        return currentScore;
    }
}
