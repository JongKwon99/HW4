using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactDamager : MonoBehaviour
{
    public float damage;

    private void OnTriggerEnter(Collider other)
    {
        //Destroy(gameObject);    // ���𰡿� �ε����� �ڱ��ڽ��� �ı�

        Life life = other.GetComponent<Life>();

        if (life != null )
        {
            life.amount -= damage;
        }
    }
}
