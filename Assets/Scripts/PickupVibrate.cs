using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupVibrate : MonoBehaviour
{
    bool Pressed = false;

    void OnMouseDown()
    {
        Pressed = true;
    }
    void OnMouseUP()
    {
        Pressed = false;
    }
     void DestroyGameObject()
    {
        Destroy(gameObject);
    }
    void Update()
    {
        if (Pressed)
        {
            Vector3 mousePos = Input.mousePosition;
            Handheld.Vibrate();
            DestroyGameObject();
        }
    }
}
