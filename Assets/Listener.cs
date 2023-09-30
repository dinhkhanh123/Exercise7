using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listener : MonoBehaviour
{
    private void Start()
    {
        // L?y Invoker component t? Camera chính (Main Camera).
        Invoker invoker = Camera.main.GetComponent<Invoker>();

        if (invoker != null)
        {
            // ??ng ký method PrintMessage c?a MessageEvent làm ng??i nghe.
            invoker.AddNoArgumentListener(PrintMessage);
        }
        else
        {
            Debug.LogError("Invoker not found on Main Camera.");
        }
    }

    // Ph??ng th?c này s? ???c g?i khi Timer hoàn thành.
    private void PrintMessage()
    {
        Debug.Log("This is a message from the listener!");
    }
}
