using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem : MonoBehaviour
{
    public void Update () {

        if (DetermineInput("Fire1")) {

            Debug.Log("Fire button pressed");
        }
    }

    private bool DetermineInput(string input) {

        bool output;
        output = Input.GetButtonDown(input);
        return output;
    }
    
}
