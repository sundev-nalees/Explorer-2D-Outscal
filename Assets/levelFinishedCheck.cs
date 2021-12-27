using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelFinishedCheck : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<playerConrol>()) ;
        {
            //level complete
            Debug.Log("level finished");
        }
    }
}
