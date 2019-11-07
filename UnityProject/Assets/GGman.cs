using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GGman : MonoBehaviour
{

    // Use this for initialization

    [Header("對話")]
    public string Say = "早安你好";
    public float SaySpeed = 1.5f;

    [Header("任務")]
    public bool Complete = false;
    public int  BateryFinish = 5;
    public int Batery = 0;
}
