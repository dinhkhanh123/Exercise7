using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    public float duration = 1.0f;  // Thời gian đếm ngược
    public bool isFinished = false;

    public UnityEvent OnTimerCompleted = new UnityEvent();

    private float timer = 0.0f;

    private void Update()
    {
        if (!isFinished)
        {
            timer += Time.deltaTime;

            if (timer >= duration)
            {
                isFinished = true;
                timer = duration;
                OnTimerCompleted.Invoke();
            }
        }
    }

    public void Run()
    {
        timer = 0.0f;
        isFinished = false;
    }
}