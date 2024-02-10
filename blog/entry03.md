# Entry 3
A slow progress, but manageable. 2/9/2024

Wow, this month was slow. Most of our time between me and Xin Yan were mostly allocated for school work instead of the freedom project. Not to mention all the college related tasks that we have to keep tabs on. Due to this, expect this entry to be shorter than the rest.

I was able to create an interactable door using the scripts provided in [Video 2.5](https://www.youtube.com/watch?v=_UIiwzfZoZA&list=PLGUw8UNswJEOv8c5ZcoHarbON6mIEUFBC&index=3) of Natty's Gamedev video. Using the code below...

```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPad : Interactable
{
    [SerializeField]
    private GameObject door;
    private bool doorOpen;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    // This is where we design our interaction using code
    protected override void Interact(){
        // base.Interact();
        doorOpen = !doorOpen;
        Debug.Log(doorOpen);
        door.GetComponent<Animator>().SetBool("isOpen", doorOpen);
    }
}
```

This script is placed into our interactable. In this case, we will be using a red keypad to open our very big door.

![e3-01](img/fp-e3-01.png)

Now we have the keypad interactable, but we can only interact with it. What will happen if we interact it. Thats where we need to create another script which you may have seen in the image above. We need to create a script on what will happen when the interactable gets interacted. We will be using of course our script file, but we will be also using the animation editor.

Now our interaction event script is a bit short because it is directly linked to the **interactable** script we have later on.

```cs
using UnityEngine.Events;
using UnityEngine;

public class InteractionEvent : MonoBehaviour
{
    public UnityEvent OnInteract;
}

```

Our interactable script looks like this

```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    // Add or remove an interaction event component to this game object.
    public bool useEvents;
    // Msg displayed to player when looking at interactable
    public string promptMessage;

    // This function will be called from our player
    public void BaseInteract(){
        if(useEvents){
            GetComponent<InteractionEvent>().OnInteract.Invoke();
        }
        Interact();
    }
    protected virtual void Interact(){
        // No code is written in this function. It is going to get overwritten by subclasses.
    }
}
```



[Previous](entry02.md) | [Next](entry04.md)

[Home](../README.md)