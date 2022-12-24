using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Character _targetCharacter;

    [Header("Camera Follow Settings")]
    private Camera _camMain;
    public float playerFollowRateX;
    public float playerVelocityXApproachRate;
    public float playerFollowRateY;
    public float playerVelocityYApproachRate;
    [SerializeField] private float _smoothTime;
    private Vector3 _velocity = Vector3.zero;
    [SerializeField] private float _cur_Multiplier;

    [Header("Camera Position Settings")]
    [SerializeField] private Transform _startPos;
    [SerializeField] private Transform _endPos;
    private Vector3 _temp = Vector3.zero;


    public enum CameraState
    {
        Idle,
        Started,
        EndPhase
    }

    private CameraState cameraState = CameraState.Idle;

    public void Init(Character _targetCharacter)
    {
        this._targetCharacter = _targetCharacter;
        cameraState = CameraState.Started;
    }
    private void Awake()
    {
        _camMain = Camera.main;
        cameraState = CameraState.Started;
    }
    void Start()
    {
        transform.position = _targetCharacter.transform.position;

    }
    private void LateUpdate()
    {
        if (cameraState == CameraState.Started)
        {
            _temp = transform.position;
            //_temp = new Vector2(Mathf.MoveTowards(_temp.x, (_targetCharacter.transform.position.x) , playerVelocityXApproachRate*Time.deltaTime), Mathf.MoveTowards(_temp.y, (_targetCharacter.transform.position.y), playerVelocityYApproachRate*Time.deltaTime));
            _temp = Vector3.SmoothDamp(_temp, new Vector3(_targetCharacter.transform.position.x, _targetCharacter.transform.position.y, _temp.z), ref _velocity, _smoothTime);
            transform.position = _temp;
        }
    }


    public void EndPhaseStarted()
    {
        cameraState = CameraState.EndPhase;
    }
}
