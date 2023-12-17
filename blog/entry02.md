# Entry 2
The journey begins (Featuring Xin Yan) 12/12/2023

As always with Entry 2, we begin tinkering with our tool. Before we started tinkering though, we decided to do our own seperate mini project to get the hand with Unity before working on the main project. This way, we have a clear grasp of how Unity operates and no one is left confused or how x thing works.

The tutorial we used was created by [Natty GameDev](https://www.youtube.com/@NattyGameDev) and he made a [series](https://www.youtube.com/watch?v=rJqP5EesxLk&list=PLGUw8UNswJEOv8c5ZcoHarbON6mIEUFBC) where he teaches Unity beginners on how to make a simple first person shooter game. This tutorial was not that lengthy and provided enough information to us so we decided to take on it.

As I established before, me and Xin Yan are doing our own seperate mini project to get the hang with Unity. Our plan is to use the tutorial mentioned and create a simple little game to ourselves. Now you might be thinking this is a huge time waster as me and Xin Yan are basically making the freedom project seperately but this is not the case! In fact, it allows even more time efficient! By making 2 seperate mini projects, we can just copy and paste whatever we have on our mini project and adding more details there and there.

Now we did have a stict deadline for this and it is to complete all the tutorials before winter break because we want to work on the main project over the break. The first few months was mostly there for testing and trying out Unity. Our next couple of months is working on the main project itself and hopefully pushing it to a full game release.

**NOTE: We had a little update on this! Due to the increase workload (Mainly our English class), our deadline was pushed back to the end of break. This means that we will be working on our mini project over the break and starting our main project after the break.**

At this point, lets highlight my experience during with my tinkering days. You can see [Xin Yan's](https://github.com/xinyanh4701/apcsa-freedom-project/blob/main/blog/entry02.md) journey here.

Before jumping into the tutorial, I need to learn the C# programming language. I found a tutorial where I can learn [C# in 10 minutes of less](https://www.youtube.com/watch?v=IFayQioG71A). This tutorial although fast, will teach you the basics of C#. What I found surprising is that C# is basically similar to Java with some slight wording differences. This is good as I keep learning Java, I can translate that to C#.

For example, take this function method.

In java...

```java
public static void functionname(parameters){
 // Code here
}
```

in C#...

```cs
static void functionname(parameters){
 // Code here
}
```

Pratically similar! Code was essentially a non issue to me now. Now I'm definitely ready to learn Unity!

Throughout the journey, I was to create a player and made it move using Unitys input system. There were some parts that were outdatted such as the "2D Vector Composite" which is used to create the keybinds for the movements. Thankfully, there was a [reddit thread](https://www.reddit.com/r/Unity3D/comments/s5t1bs/unity_isnt_showing_the_add_2d_vector_composite/) stating that it was renamed to the "Vector 2" + "Add Up/Down/Left/Right Composite".

After setting up the keybinds, I created my first C# script which was the [inputManager](../tool/codesnippits/inputmanagersnippit.cs) and [PlayerMotor](../tool/codesnippits/playermansnippit.cs) script. There was a slight error in the naming. I named the PlayerMotor to PlayerMotto which was a silly mistake which I eventually fixed.

There was another bug related to the inputmanager. When I tested the inputs, my character wasn't moving. This is where I realized that Update needs to be changed to FixedUpdate.

```cs
//Before
    void Update()
    {
        motor.ProcessMove(onFoot.Movement.ReadValue<Vector2>());
    }

//After
    void FixedUpdate()
    {
        motor.ProcessMove(onFoot.Movement.ReadValue<Vector2>());
    }
```
I'm assuming that FixedUpdate is somewhat similar to 0 or 1's so that it will know when to enable or disable instead of Update which will change every millisecond. After the fix, My character was able to move!

This took me a while to realize the error. [Attention to detail](https://hstatsep.github.io/students/#skills) was critical here because when I rewatched the video and retraced my steps, I missed this. In the near future, I will make sure to carefully watch the little details I notice in the tutorials.





[Previous](entry01.md) | [Next](entry03.md)

[Home](../README.md)