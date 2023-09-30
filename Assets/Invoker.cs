using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Invoker : MonoBehaviour
{
    public Timer timer; // ?i?u này ph?i là m?t ??i t??ng Timer ?ã t?n t?i trong d? án c?a b?n.
    public UnityEvent noArgumentEvent = new UnityEvent();

    private void Awake()
    {
        // Kh?i t?o ??i t??ng noArgumentEvent.
        noArgumentEvent = new UnityEvent();
    }

    public void AddNoArgumentListener(UnityAction action)
    {
        // Thêm m?t delegate làm ng??i nghe cho noArgumentEvent.
        noArgumentEvent.AddListener(action);
    }

    private void Start()
    {
        // T?o m?t Timer component và c?u hình nó.
        timer = gameObject.AddComponent<Timer>();
        timer.duration = 1.0f;
        timer.Run();

        // Thêm s? ki?n khi Timer hoàn thành.
        timer.OnTimerCompleted.AddListener(OnTimerCompleted);
    }

    private void Update()
    {
        // Khi Timer hoàn thành, g?i event và ch?y l?i Timer.
        if (timer.isFinished)
        {
            noArgumentEvent.Invoke();
            timer.Run();
        }
    }

    private void OnTimerCompleted()
    {
        // X? lý sau khi Timer hoàn thành (n?u c?n).
    }
}