using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// An event invoker
/// </summary>
public class Invoker : MonoBehaviour
{
    // add your fields for your message event support here
    int count;
    Timer countMessageTimer;
    Timer messageTimer;

    MessageEvent messageevent;
    CountMessageEvent countMessageEvent;
    // add your fields for your count message event support here

    /// <summary>
    /// Awake is called before Start
    /// </summary>
    public void Awake()
    {
        // add your code here
        messageevent = new MessageEvent();
        countMessageEvent = new CountMessageEvent();

    }

    /// <summary>
    /// Use this for initialization
    /// </summary>
    public void Start()
    {
        // add your code here
        EventManager.AddNoArgumentInvoker(this);
        messageTimer = gameObject.AddComponent<Timer>();
        messageTimer.Duration = 1f;
        messageTimer.Run();

        EventManager.AddIntArgumentInvoker(this);
        countMessageTimer = gameObject.AddComponent<Timer>();
        countMessageTimer.Duration = 1f;
        countMessageTimer.Run();
        count = 0;

    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        // add your code here
        if (messageTimer.Finished)
        {
            InvokeNoArgumentEvent();
        }
        if (countMessageTimer.Finished)
        {
            InvokeOneArgumentEvent(count++);
        }

    }

    /// <summary>
    /// Adds the given listener to the no argument event
    /// </summary>
    /// <param name="listener">listener</param>
    public void AddNoArgumentListener(UnityAction listener)
    {
        // add your code here to add the given listener for
        // the message event
        messageevent.AddListener(listener);
    }

    /// <summary>
    /// Adds the given listener to the one argument event
    /// </summary>
    /// <param name="listener">listener</param>
    public void AddOneArgumentListener(UnityAction<int> listener)
    {
        // add your code here to add the given listener for
        // the count message event
        countMessageEvent.AddListener(listener);
    }

    /// <summary>
    /// Removes the given listener to the no argument event
    /// </summary>
    /// <param name="listener">listener</param>
    public void RemoveNoArgumentListener(UnityAction listener)
    {
        // add your code here to remove the given listener from the
        // message event
        messageevent.RemoveListener(listener);

    }

    /// <summary>
    /// Removes the given listener to the one argument event
    /// </summary>
    /// <param name="listener">listener</param>
    public void RemoveOneArgumentListener(UnityAction<int> listener)
    {
        // add your code here to remove the given listener from the
        // count message event
        countMessageEvent.RemoveListener(listener);
    }

    /// <summary>
    /// Invokes the no argument event
    /// 
    /// NOTE: We need this public method for the autograder to work
    /// </summary>
    public void InvokeNoArgumentEvent()
    {
        // add your code here to invoke the message event
        messageevent.Invoke();
    }

    /// <summary>
    /// Invokes the one argument event
    /// 
    /// NOTE: We need this public method for the autograder to work
    /// </summary>
    /// <param name="argument">argument to use for the Invoke</param>
    public void InvokeOneArgumentEvent(int argument)
    {
        // add your code here to invoke the count message event
        // with the given argument
        countMessageEvent.Invoke(argument);
    }
}
