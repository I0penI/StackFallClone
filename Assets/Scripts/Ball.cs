using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;
    public GameObject splashPrefab;
    public GameManager gm;
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.velocity = Vector3.up * jumpForce;




        GameObject splash = Instantiate(splashPrefab, transform.position + new Vector3(0f, -0.2f, 0f), transform.rotation); 
        splash.transform.SetParent(collision.gameObject.transform);

        string meterialName = collision.gameObject.GetComponent<MeshRenderer>().material.name;

        if (meterialName == "SafeColor (Instance)")
        {
            //puan alacak
        }
        else if (meterialName == "UnsafeColor (Instance)")
        {
            gm.RestartGame();
            Debug.Log("Game Over!");
        }
        else if (meterialName == "CompleteColor (Instance)")
        {
            //level up
        }
    }
}
