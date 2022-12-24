using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class VoterManager : MonoBehaviour
{

    public int NumVoter=10;
    public int maxNumVoter = 50;
    public int minNumVoter = 20;
    public GameObject voterPrefab;
    public static Action<string,int> incrementVote;
    List<GameObject> SpawnZoneList = new List<GameObject>();
    List<Voter> VotersList = new List<Voter>();
    void Start()
    {   
        SpawnZoneList = GameObject.FindGameObjectsWithTag("SpawnZone").ToList();
        Voter.Convinced += DestroyVoter;
        Voter.Convinced += UpdateVote;
        print(SpawnZoneList.Count);
    }

    // Update is called once per frame
   
    void Update()
    {

       if (NumVoter <= minNumVoter)
        {
            float[] xyCoord = getRandomLocation(SpawnZoneList);
            SpawnVoter(xyCoord);
        }
    


    }


    float[] getRandomLocation(List<GameObject> SpawnZoneList)
    {
        float[] xyCoord = new float[2];
        int randomIndex = UnityEngine.Random.Range(0, SpawnZoneList.Count);
        Vector2 center = SpawnZoneList[randomIndex].transform.position;
        float zoneRadius = SpawnZoneList[randomIndex].GetComponent<CircleCollider2D>().radius;
        float randomFloatforX = UnityEngine.Random.Range(-zoneRadius, zoneRadius);
        float randomFloatforY = UnityEngine.Random.Range(-zoneRadius, zoneRadius);
        xyCoord[0] = center.x + randomFloatforX;
        xyCoord[1] = center.y + randomFloatforY;
        return xyCoord; 

    }


    void UpdateVote(Voter voter)
    {
        if (incrementVote != null)
        {
            incrementVote(voter.uname, voter.voteNum);
        }
    }

    void SpawnVoter(float[] coord)
    {
        Voter newVoter = gameObject.GetComponent<Voter>();
        Instantiate(voterPrefab, new Vector3(coord[0], coord[1], 0), Quaternion.identity);
        VotersList.Add(newVoter);
        NumVoter += 1;
    }

    void DestroyVoter(Voter voter)
    {
        
        VotersList.Remove(voter);
        Destroy(voter.gameObject); 
    }
}
