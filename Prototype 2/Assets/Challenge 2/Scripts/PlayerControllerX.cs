using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float pressInterval = 1.0f;
    private int flag = 0;

    private void Start()
    {
        InvokeRepeating("EnablePress", 0, pressInterval);
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (flag == 1)
        {
           
            if (Input.GetKeyDown(KeyCode.Space))
            {

                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                flag = 0;
            }

        }
    }
    void EnablePress()
    {
        flag = 1;
    }
}
