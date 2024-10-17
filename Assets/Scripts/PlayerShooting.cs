using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    public int speacialBulletNum;
    public GameObject normalBullet;
    public GameObject specialBullet;
    public GameObject shootPoint;

    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(normalBullet, transform.position, transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (speacialBulletNum > 0) 
            {
                Instantiate(specialBullet, transform.position, transform.rotation);
                speacialBulletNum--;
            }
            
        }*/
    }

    public void OnFire(InputValue value)
    {
        Debug.Log("OnFire ȣ���");
        if (value.isPressed)
        {
            GameObject clone = Instantiate(normalBullet);

            clone.transform.position = shootPoint.transform.position;
            clone.transform.rotation = shootPoint.transform.rotation;
        }
    }
}
