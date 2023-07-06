using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class ExampleScript : MonoBehaviour
{
    public void ExampleEvent(GameObject gameObj)
    {
        //trigger a custom event on target game object
        CustomEvent.Trigger(gameObj, "ExampleCustomEvent");
        //Get a VS variable from the target game object
        string TestString = (string)Variables.Object(gameObj).Get("TestString");
        //Debug print
        Debug.Log(TestString);

    }
}
