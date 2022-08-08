using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : Animal // INHERITANCE
{
    protected override void Start() // assign name on startup
    {
        base.Start();
        animalName = "Fox!";
    }

    protected override void Jump() // POLYMORPHISM
    {
        base.Jump();
        base.Jump();
    }

    public override void OnMouseOver() // right-click, change chosenAnimal index
    {
        base.OnMouseOver();
        if (Input.GetMouseButtonDown(1))
        {
            mainUIManager.chosenAnimal = 1;
        }
    }
}
