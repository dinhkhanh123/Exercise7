using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MessageEvent : MonoBehaviour
{
    public UnityEvent myEvent = new UnityEvent();

    // ?o?n code in ra Console m� b?n mu?n th?c hi?n khi event ???c g?i.
    // V� d?:
    public void PrintMessage()
    {
        Debug.Log("This is a message from the event!");
    }
}
