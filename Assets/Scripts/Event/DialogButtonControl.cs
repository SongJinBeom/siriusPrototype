using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogButtonControl : MonoBehaviour
{
    private DialogSYS dialogueSystem;

    // Start is called before the first frame update
    void Start()
    {
        dialogueSystem = FindObjectOfType<DialogSYS>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        dialogueSystem.ShowDialogue();
    }
}
