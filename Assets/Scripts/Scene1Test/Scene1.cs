using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1 : MonoBehaviour
{
    public DialogueSystem dialogueSystem;

    private bool isdialog;

    // Start is called before the first frame update
    void Start()
    {
        dialogueSystem = FindObjectOfType<DialogueSystem>();
        isdialog = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!isdialog)
            {
                isdialog = true;
                dialogueSystem.ShowDialogue();
            }
            // 다이얼 시스템이 끝나면 다음 씬으로
        }
    }
}
