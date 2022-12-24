using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 




public class Voter : MonoBehaviour
{
    // Start is called before the first frame update
    public bool charOnCollidier = false;
    public float remainConvincingTime = 1f;
    public static Action<Voter> Convinced;
    public string uname = "mert";
    public int voteNum = 1; 
    void Start()
    {
    
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
                        Convinced(this); 
                    }
                }
                 
            }
        }

    }
   
    


    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.tag == "PartyFlag")
        {
            print("Burasi bayrak");
        } 
        if (other.tag == "Character")
        {
            charOnCollidier = true;
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
