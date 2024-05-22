using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem : MonoBehaviour
{
    public void Update () {
        
        if (Input.GetButtonDown("Fire1")) {

            Debug.Log("Fire button pressed");
        }
    }
    
}
