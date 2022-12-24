using System.Collections;
using System.Collections.Generic;
using UnityEngine;




[CreateAssetMenu(fileName = "EndGameScores", menuName = "EndGameScores")]


public class EndGameScores : ScriptableObject
{
    public IDictionary<string, int> Scores = new Dictionary<string, int>();
    

}
