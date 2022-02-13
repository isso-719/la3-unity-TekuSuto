using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody playerRigidbody;
    int count_bounce = 0;
    int playerHP = 10;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("プレイヤーのHPは" + playerHP);
        playerRigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerRigidbody.velocity == new Vector3(0, 0, 0))
        {
            transform.Rotate(new Vector3(0, 5f, 0));
        }
        if (Input.GetKey("up"))
        {
            if (playerRigidbody.velocity == new Vector3(0, 0, 0))
            {
                playerRigidbody.velocity = transform.forward * 50f;
                Debug.Log("発射回数" + ++count_bounce);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        playerHP--;
        Debug.Log("プレイヤーのHPは" + playerHP);

        if (playerHP == 0)
        {
            Debug.Log("Game Over!");
        }
    }
}
