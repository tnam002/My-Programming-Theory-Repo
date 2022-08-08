using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : Animal
{

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Jump()
    {
        base.Jump();
        base.Jump();
    }
}
