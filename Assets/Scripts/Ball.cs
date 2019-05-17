using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; 
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    Vector3 startPos;
    Rigidbody rb;

    public Text p;
    public Text a;
    int pScore = 0;
    int aScore = 0; 

    private void Start() {
       
        startPos = transform.position;
        rb = GetComponent<Rigidbody>();
        Play();
        
    }
    
    void Play()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float z = Random.Range(0, 2) == 0 ? -1 : 1;
       
        rb.velocity = new Vector3(x, 0f, z) * speed;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "G1")
        {
            StartCoroutine("Reset");
            aScore++;
            a.text = aScore.ToString(); 
        }

        if (col.gameObject.name == "G2")
        {
            StartCoroutine("Reset");
            pScore++;
            p.text = pScore.ToString();
        }
    }

    IEnumerator Reset()
    {
        transform.position = startPos;
        Debug.Log("1");
        rb.velocity = new Vector3(0, 0f, 0);
        yield return new WaitForSeconds(3f);
        Play();
    }


}
