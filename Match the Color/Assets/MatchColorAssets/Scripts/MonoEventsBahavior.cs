using System;
using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBahavior : MonoBehaviour
{
    public UnityEvent startEvent, updateEvent, awakeEvent;
    void Start()
    {
        startEvent.Invoke();
    }
    
    void Update()
    {
        updateEvent.Invoke();
    }

    private void Awake()
    {
        awakeEvent.Invoke();
    }
}
