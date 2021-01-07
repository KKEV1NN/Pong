using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    float Speed = 5;
    public bool IsPlayer;
    float zPos = Mathf.Clamp(0, -8, 8);
    Vector3 dir;
    public GameObject ball;

    public void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball"); 

    }

    private void Update()
    {
        if (IsPlayer)
        {
            transform.Translate(0f, 0f, Input.GetAxis("Vertical") * Speed * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit(); 
            }
        }
        else if (!IsPlayer)
        {
            dir = (ball.transform.position - transform.position).normalized;
            transform.position += new Vector3(0, 0, dir.z) * Speed * Time.deltaTime;
        }

    }
}
