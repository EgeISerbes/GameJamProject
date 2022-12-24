//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Attractor : MonoBehaviour
//{
//    [SerializeField] private int _quota;
//    [SerializeField] private OnAttractionAreaTrigger _areaTrigger;
//    private Character _targetChar;
//    private Character _contesterChar;
//    [SerializeField] private float _timeToConquest;
//    private float _conquestTimer;

//    private bool _isCaptured = false;
//    private bool _canCapture = false;
//    void Start()
//    {

//    }
//    private void Awake()
//    {
//        _areaTrigger.Init(OnTriggerActionEnter,OnTriggerActionExit);
//    }
//    // Update is called once per frame
//    void Update()
//    {
//        if(_canCapture)
//        {
//            _conquestTimer += Time.deltaTime;
//            if(_conquestTimer>=_timeToConquest)
//            {
//                _canCapture = false;
//                _conquestTimer = 0f;
//                _targetChar = _contesterChar;
//            }
//        }
//    }
//    private void OnTriggerActionEnter(bool isPlayer,GameObject obj)
//    {
//        if(isPlayer)
//        {   
//            if(!_canCapture)
//            {
//                _canCapture = true;
//                _contesterChar = obj.GetComponent<Character>();

//            }
//        }
//        else if(_isCaptured)
//        {

//        }
//        else
//        {
//            return;
//        }
//    }
    
//}
