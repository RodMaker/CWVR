using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CursorLock : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }
}
