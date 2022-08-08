using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainUIManager : MonoBehaviour
{
    [SerializeField] GameObject inputField; // reference to show input field

    [SerializeField] Animal[] animals; // array of all animals
    public int chosenAnimal; // tracks which animal is currently chosen

    [SerializeField] TextMeshProUGUI newName; // reference to get the new name for assignment

    public void OpenInputField() // show input field
    {
        inputField.SetActive(true);
    }

    void ChangeName() // assign new animal name, hide input field
    {
        animals[chosenAnimal].animalName = newName.text;
        inputField.SetActive(false);
    }
}
