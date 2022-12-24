using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Vector3 _prevPos = Vector3.zero;
    private Vector3 _currentPos = Vector3.zero;
    private Vector3 _diff = Vector3.zero;
    private int _tempFingerID = -1;
    private InputValues _inputvalues = new InputValues();
    private Camera _mainCam;

    public bool IsPressed
    {
        get => _inputvalues.isPressed;
    }
    public bool IsReleased
    {
        get => _inputvalues.isReleased;
    }
    public Vector3 WorldPos
    {
        get => _inputvalues.worldPos;
    }
    public Vector3 VectorDifference
    {
        get => _diff;
    }
    private class InputValues
    {
        public bool isPressed;
        public bool isReleased;
        public Vector3 worldPos;

        public InputValues()
        {
            isPressed = false;
            isReleased = false;
            worldPos = Vector3.zero;
        }
    }
    private void Awake()
    {
        _mainCam = Camera.main;
    }
    // Update is called once per frame
    void Update()
    {
        GetInputs();
    }
    private void GetInputs()
    {   





        //_inputvalues.isReleased = false;
        //if (Application.isEditor)
        //{
        //    if(Input.GetMouseButtonDown(0))
        //    {
        //        _inputvalues.isPressed = true;
        //        _inputvalues.worldPos = _mainCam.ScreenToWorldPoint(Input.mousePosition);
        //        _currentPos = _inputvalues.worldPos;
        //        _prevPos = _currentPos;

        //    }
        //    if (Input.GetMouseButton(0))
        //    {
        //        _inputvalues.isPressed = true;
        //        _inputvalues.worldPos = _mainCam.ScreenToWorldPoint(Input.mousePosition);
        //        _currentPos = _inputvalues.worldPos;
        //        _diff = _currentPos - _prevPos;
        //        _prevPos = _currentPos;

        //    }
        //    else if (Input.GetMouseButtonUp(0))
        //    {
        //        _diff = Vector3.zero;
        //        _prevPos = Vector3.zero;
        //        _inputvalues.isReleased = true;
        //        _inputvalues.isPressed = false;
        //    }
        //    else
        //    {
        //        _diff = Vector3.zero;
        //        _inputvalues.isPressed = false;
        //    }
        //}
        //else
        //{
        //    if(Input.touchCount >0)
        //    {
        //        if(_tempFingerID == -1)
        //        {
        //            foreach(Touch inputs in Input.touches)
        //            {
        //                if(inputs.phase == TouchPhase.Began)
        //                {
        //                    _tempFingerID = inputs.fingerId;
        //                    _inputvalues.isPressed = true;
        //                    _inputvalues.isReleased = false;
        //                    _inputvalues.worldPos = _mainCam.ScreenToWorldPoint(inputs.position);
        //                    _currentPos = _inputvalues.worldPos;
        //                    _prevPos = _currentPos;
        //                }
        //            }
        //        }
        //        else
        //        {


        //            foreach (Touch inputs in Input.touches)
        //            {
        //                if (inputs.fingerId == _tempFingerID)
        //                {
        //                    if (inputs.phase == TouchPhase.Moved || inputs.phase == TouchPhase.Stationary)
        //                    {
        //                        _inputvalues.isPressed = true;
        //                        _inputvalues.worldPos = _mainCam.ScreenToWorldPoint(inputs.position);
        //                        _currentPos = _inputvalues.worldPos;
        //                        if (inputs.phase == TouchPhase.Moved)
        //                        {
        //                            _diff = _currentPos - _prevPos;
        //                        }
        //                        _prevPos = _currentPos;
        //                    }
        //                    else if (inputs.phase == TouchPhase.Ended || inputs.phase == TouchPhase.Canceled)
        //                    {
        //                        _inputvalues.isReleased = true;
        //                        _inputvalues.isPressed = false;
        //                        _diff = Vector3.zero;
        //                        _tempFingerID = -1;
        //                    }
        //                    return;
        //                }

        //            }
        //            _inputvalues.isPressed = false;
        //            _inputvalues.isReleased = true;
        //            _tempFingerID = -1;
        //        }
        //    }
        //}
        
    }
}
