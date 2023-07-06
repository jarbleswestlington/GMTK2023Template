using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommunicatorScript : MonoBehaviour
{
    public ExampleScript ExampleScript;
    //public SerpentineMovement SerpentineMovement;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void SendMessage(GameObject gameObj, string EventName, string ScriptName)
    {


    if (EventName == "Example")
        {
            ExampleScript.ExampleEvent(gameObj);
        }
         //   if (EventName == "SerpentineStart")
        //{
         //   SerpentineMovement.SerpentineStart(gameObj);
        //}    

    }
}
