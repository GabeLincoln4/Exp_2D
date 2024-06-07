using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputDebugger : MonoBehaviour
{
    public void DisplayFire1ButtonHeldMessage ()
    { Debug.Log("Fire1 button is being held down..."); }

    public void DisplayFire1ButtonReleasedMessage ()
    { Debug.Log("Fire1 button is released"); }

    public void DisplayButtonOptions ()
    { Debug.Log("Press W\nPress A\nPress S\nPress D"); }

    public void DisplayMagicAttackMessage ()
    { Debug.Log("Magic Attack Invoked"); }

    public void DisplayButtonPromptAStatus ()
    { Debug.Log("Button Prompt A is active"); }
}