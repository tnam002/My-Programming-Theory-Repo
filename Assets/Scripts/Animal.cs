using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Animal : MonoBehaviour
{
    [SerializeField] GameObject information; // container for current animal name and instructions ("left-click to rename"!)
    [SerializeField] TextMeshProUGUI animalNameUI; // reference to current animal name in UI when hovering

    [SerializeField] GameObject inputField; // container for text input and button for name change

    [SerializeField] protected MainUIManager mainUIManager; // for calling OpenInputField() and children to change chosenAnimal index

    protected Rigidbody animalRigidBody; // rigidbody for jumping
    protected float jumpForce = 200; // base jump power for animal

    string m_animalName; // member animal name
    public string animalName // ENCAPSULATION
    {
        get
        {
            return m_animalName;
        }
        set
        {
            if (value.Length > 10)
            {
                Debug.Log("Name is too long!");
            } else
            {
                m_animalName = value;
            }
        }
    }

    protected virtual void Start()
    {
        animalRigidBody = gameObject.GetComponent<Rigidbody>();
    }

    public virtual void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)) // left-click, animal jumps
        {
            Jump(); // ABSTRACTION
        } else if (Input.GetMouseButtonDown(1)) // right-click, open input field. child changes chosenAnimal index
        {
            mainUIManager.OpenInputField();
        }
    }

    private void OnMouseEnter()
    {
        ShowAnimalName();
    }

    private void OnMouseExit()
    {
        HideAnimalName();
    }

    virtual protected void Jump() // ABSTRACTION
    {
        animalRigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Force);
    }

    void ShowAnimalName()
    {
        animalNameUI.text = animalName;
        information.SetActive(true);
    }

    void HideAnimalName()
    {
        information.SetActive(false);
    }
}
