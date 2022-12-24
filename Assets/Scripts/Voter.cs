using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 




public class Voter : MonoBehaviour
{
    public bool charOnCollidier = false;
    public float remainConvincingTime = 1f;
    public static Action<Voter,string> Convinced;
    public string uname = "mert";
    public int voteNum = 1;
    public string targetString = "";
    void Start()
    {
    
    }
    public void Init(System.Action<Voter,string> OnConvinced)
    {
        Convinced += OnConvinced;
    }

    // Update is called once per frame
    void Update()
    {
        if(charOnCollidier){
            remainConvincingTime -= Time.deltaTime;

            if (remainConvincingTime <= 0)
            {
                if (RollDice(0.8f))
                {
                    if(Convinced != null)
                    {
                        Convinced(this,targetString); 
                    }
                }
                 
            }
        }

    }
   
    


    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.gameObject.CompareTag("AttractorTriggerZone"))
        {

        }
        else if(other.gameObject.CompareTag("PlayerTriggerZone"))
        {

        }
           
        
    }
   
   private void OnTriggerExit2D(Collider2D other) {
         charOnCollidier = false;
         remainConvincingTime = 1f;
   }

    bool RollDice(float chance){
        
        float randomFloat = UnityEngine.Random.Range(0,1);

        if (randomFloat<=chance)
        {
            return true;
        }
        
        else
        {
            return false; 
        }
    }
}
