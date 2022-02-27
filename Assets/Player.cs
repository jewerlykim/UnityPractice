using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string myName;
    Rigidbody2D rid2D;
    int playerSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I am alive and my name is " + myName);
        rid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        if  (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(playerSpeed * Time.deltaTime, 0, 0));
            // rid2D.AddForce(new Vector2(playerSpeed, 0), ForceMode2D.Force);
        }

        if  (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-playerSpeed * Time.deltaTime, 0, 0));
            // rid2D.AddForce(new Vector2(-playerSpeed, 0), ForceMode2D.Force);
        }

        if  (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, playerSpeed * Time.deltaTime, 0));
            // rid2D.AddForce(new Vector2(0, playerSpeed), ForceMode2D.);
        }

        if  (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -playerSpeed * Time.deltaTime, 0));
            // rid2D.AddForce(new Vector2(0, -playerSpeed), ForceMode2D.Force);
        }
    }
}
