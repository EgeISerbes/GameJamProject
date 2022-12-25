using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameUIManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject gameManager;
    public Text yourScore;
    public Text EnemyScore1; 
    public Text EnemyScore2;
    public GameManager gm; 
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        gm = gameManager.GetComponent<GameManager>();
        
        yourScore.text =  gm.Scores["name"].ToString() + " " + "OY";
        EnemyScore1.text = gm.Scores["name"].ToString() + " " + "OY";
        EnemyScore2.text = gm.Scores["name"].ToString() + " " + "OY";
        GameManager.updateScores += reWriteScores;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void reWriteScores( )
    {
        yourScore.text = gm.Scores["name"].ToString() + " " + "OY";
        EnemyScore1.text = gm.Scores["name"].ToString() + " " + "OY";
        EnemyScore2.text = gm.Scores["name"].ToString() + " " + "OY";
    }
}
