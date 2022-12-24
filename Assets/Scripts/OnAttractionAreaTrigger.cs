using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnAttractionAreaTrigger : MonoBehaviour
{
    private System.Action<int> _onAttractionTrigger;
    public void Init(System.Action<int> AttractionFunc)
    {
        _onAttractionTrigger += AttractionFunc;
    }
    public void OnTriggerWithVoter(int val)
    {
        _onAttractionTrigger(val);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {

        }
    }

}
