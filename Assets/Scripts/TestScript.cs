using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            inst();
        }
    }

    void inst()
    {
        for(int i = 0; i < 10; i++)
        {
            Vector3 nv = new Vector3(i, 0, 0);
            Instantiate(gameObject, nv, gameObject.transform.rotation);
        }
    }
}
