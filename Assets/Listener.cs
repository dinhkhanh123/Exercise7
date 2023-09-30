using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listener : MonoBehaviour
{
    private void Start()
    {
        // L?y Invoker component t? Camera ch�nh (Main Camera).
        Invoker invoker = Camera.main.GetComponent<Invoker>();

        if (invoker != null)
        {
            // ??ng k� method PrintMessage c?a MessageEvent l�m ng??i nghe.
            invoker.AddNoArgumentListener(PrintMessage);
        }
        else
        {
            Debug.LogError("Invoker not found on Main Camera.");
        }
    }

    // Ph??ng th?c n�y s? ???c g?i khi Timer ho�n th�nh.
    private void PrintMessage()
    {
        Debug.Log("This is a message from the listener!");
    }
}
