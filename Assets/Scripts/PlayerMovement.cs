using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    Rigidbody2D rb;


  
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { 
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (touchPos.x < 0)
            {
                rb.AddForce(Vector2.left * moveSpeed * 10);
            }
            else
            {
                rb.AddForce(Vector2.right * moveSpeed * 10);
            }
        
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Block")
        {
            SceneManager.LoadScene(0);
        }
    }
}
