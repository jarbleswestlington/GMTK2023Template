using System;
using Unity.VisualScripting;
using UnityEngine;

public class SpeakToScript : Unit
{
[DoNotSerialize]
public ControlInput inputTrigger;

[DoNotSerialize]
public ControlOutput outputTrigger;

[DoNotSerialize]
public ValueInput ScriptCommunicator;

[DoNotSerialize]
public ValueInput TargetObject;

[DoNotSerialize]
public ValueInput EventName;

[DoNotSerialize]
public ValueInput ScriptName;


    private GameObject TargetGameObject;
private string EventNamePass;
    private string ScriptNamed;

    private GameObject Communicator;
private CommunicatorScript CommunicatorScript;

    protected override void Definition()
{
    //The lambda to execute our node action when the inputTrigger port is triggered.
    inputTrigger = ControlInput("inputTrigger", (flow) =>
    {
        TargetGameObject = flow.GetValue<GameObject>(TargetObject);
        Communicator = flow.GetValue<GameObject>(ScriptCommunicator);
        EventNamePass = flow.GetValue<String>(EventName);
        ScriptNamed = flow.GetValue<String>(ScriptName);

        //communicate with another script
        //Get a script component called cummunicator
        CommunicatorScript = Communicator.GetComponent<CommunicatorScript>();
        //execute a function called SendMessage including target game object
        CommunicatorScript.SendMessage(TargetGameObject, EventNamePass, ScriptNamed);

        return outputTrigger;

    });
        ScriptCommunicator = ValueInput<GameObject>("ScriptCommunicator");
        TargetObject = ValueInput<GameObject>("TargetObject");
        EventName = ValueInput<string>("EventName");
        ScriptName = ValueInput<string>("ScriptName");
        outputTrigger = ControlOutput("outputTrigger");

}
}