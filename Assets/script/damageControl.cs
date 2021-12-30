using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageControl : MonoBehaviour
{
    [SerializeField] private int enemy1Damage;
    [SerializeField] private playerHealth _playerHealth;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<playerConrol>())
        {
            Damage();
        }

        void Damage()
        {
            _playerHealth.pHealth = _playerHealth.pHealth - enemy1Damage;
            _playerHealth.UpdateHealth();
        }
    }
}
