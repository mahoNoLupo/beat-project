using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatsPerMinute : MonoBehaviour
{

    public static BeatsPerMinute _BeatsPerMinuteInstance;
   

    public float _bpm;

    public float _beatInterval;   
    
    public float _beatTimer;

    public  bool _beatFull;    

    public  bool _isOnBeat;

    public  int _beatCount;


    public void isOnBeat()
    {
        _beatFull = false;                
        _beatTimer += Time.deltaTime;        
        if(_beatTimer >= _beatInterval)
        {
            _beatCount++;
            Debug.Log($"Beat number {_beatCount} on time: {_beatTimer}");
            _beatTimer -= _beatInterval;
            _beatFull = true;  
        }   
    }


    private void Awake()
    {
        if(_BeatsPerMinuteInstance != null && _BeatsPerMinuteInstance != this)
        {
            Destroy(this.gameObject);
        }

        else
        {
            _BeatsPerMinuteInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }


        _beatInterval = 60 / _bpm;
    }
        
    void Update()
    {
        isOnBeat();
    }
}
