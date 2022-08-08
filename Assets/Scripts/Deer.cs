using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deer : Animal
{
    protected override void Start() // assign name on startup
    {
        base.Start();
        animalName = "Deer~";
    }

    public override void OnMouseOver() // right-click, change chosenAnimal index
    {
        base.OnMouseOver();
        if (Input.GetMouseButtonDown(1))
        {
            mainUIManager.chosenAnimal = 0;
        }
    }
}
