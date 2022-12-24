using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] users;
    public float GameTimeSeconds = 180f ;
    [SerializeField] public EndGameScores endGameScores;
    IDictionary<string, int> Scores = new Dictionary<string, int>();
    void Start()
    {
        
        users = GameObject.FindGameObjectsWithTag("User");
        foreach(GameObject user in users)
        {
            Scores.Add("name", 1);
        }
        VoterManager.incrementVote += UpdateVotes;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameTimeSeconds >= 0)
        {
            GameTimeSeconds -= Time.deltaTime;
            print(GameTimeSeconds);
        }
        else
        {
            endGameScores.Scores = Scores;
            SceneManager.LoadScene("EndGameScene");
        }
        
    }

    void UpdateVotes(string username, int voteNum)
    {

        if (Scores.ContainsKey(username))
        {
            Scores[username] += voteNum;
        }
       
    }
}
