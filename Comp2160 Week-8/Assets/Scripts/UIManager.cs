using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    private ScoreKeeper scoreKeeper;
    [SerializeField] private TextMeshProUGUI scorePanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI scoreCounter = scorePanel.GetComponent<TextMeshProUGUI>();
        scoreCounter.text = string.Format("Score: {0}", scoreKeeper.getScore());
    }
}
