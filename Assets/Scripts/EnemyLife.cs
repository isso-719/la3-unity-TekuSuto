using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{

    public int enemyHP = 10;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("敵のHPは" + enemyHP);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        enemyHP--;
        Debug.Log("敵のHPは" + enemyHP);

        if (enemyHP == 0)
        {
            Debug.Log("Clear!");
        }
    }
}
