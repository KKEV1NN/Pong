using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public float HostTimeScale = 1;

    private void Update()
    {
        Time.timeScale = HostTimeScale; 
    }
}
