using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    private string _name;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("test");
    }


    public string GetName()
    {
        return _name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
