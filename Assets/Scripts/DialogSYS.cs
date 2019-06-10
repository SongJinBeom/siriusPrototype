using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class DialogSYS : MonoBehaviour
{

    public Text txt;
    public Image panel;
    private bool isDialogue = false;
    private int count = 0;

    List<Dictionary<string, object>> dialogue;

    // Use this for initialization
    void Start()
    {
        dialogue = CSVReader.Read("dialog");
    }

    public void OnOff(bool _flag)
    {
        txt.gameObject.SetActive(_flag);
        if(panel != null)
        {
            panel.gameObject.SetActive(_flag);
        }
    }

    public void ShowDialogue()
    {
        OnOff(true);
        count = 0;
        isDialogue = true;
        NextDialogue();
    }

    public void HideDialogue()
    {
        OnOff(false);
        isDialogue = false;
    }

    public void NextDialogue()
    {
        txt.text = (string) dialogue[count]["dia"];
        count++;
    }
    // Update is called once per frame
    void Update()
    {
        if (isDialogue)
        {
            if (Input.GetMouseButtonDown(0))
            {

                if (count < dialogue.Count)
                {
                    NextDialogue();
                }
                else
                    HideDialogue();
            }
        }
    }
}