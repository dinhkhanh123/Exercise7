using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Invoker : MonoBehaviour
{
    public Timer timer; // ?i?u n�y ph?i l� m?t ??i t??ng Timer ?� t?n t?i trong d? �n c?a b?n.
    public UnityEvent noArgumentEvent = new UnityEvent();

    private void Awake()
    {
        // Kh?i t?o ??i t??ng noArgumentEvent.
        noArgumentEvent = new UnityEvent();
    }

    public void AddNoArgumentListener(UnityAction action)
    {
        // Th�m m?t delegate l�m ng??i nghe cho noArgumentEvent.
        noArgumentEvent.AddListener(action);
    }

    private void Start()
    {
        // T?o m?t Timer component v� c?u h�nh n�.
        timer = gameObject.AddComponent<Timer>();
        timer.duration = 1.0f;
        timer.Run();

        // Th�m s? ki?n khi Timer ho�n th�nh.
        timer.OnTimerCompleted.AddListener(OnTimerCompleted);
    }

    private void Update()
    {
        // Khi Timer ho�n th�nh, g?i event v� ch?y l?i Timer.
        if (timer.isFinished)
        {
            noArgumentEvent.Invoke();
            timer.Run();
        }
    }

    private void OnTimerCompleted()
    {
        // X? l� sau khi Timer ho�n th�nh (n?u c?n).
    }
}