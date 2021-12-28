using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<playerConrol>()!=null)
        {
          playerConrol playerConrol = collision.gameObject.GetComponent<playerConrol>();
          playerConrol.pickUpKey();
          Destroy(gameObject);
        }
        
    }


}
