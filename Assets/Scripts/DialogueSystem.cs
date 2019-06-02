using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue
{
    [TextArea] // 한 줄말고 여러줄로 쓸 수 있게
    public string dialogue;
    public int characterNum;
}

public class DialogueSystem : MonoBehaviour
{

    [SerializeField] private SpriteRenderer sprite_StandingCG;
    [SerializeField] private Image sprite_DialogueBox;
    [SerializeField] private Text txt_Dialogue;
    [SerializeField] private Image panel;
    [SerializeField] private Sprite merry;
    [SerializeField] private Sprite martha;
    [SerializeField] private Sprite medlock;


    private bool isDialogue = false;
    private int count = 0;

    [SerializeField] private Dialogue[] dialogue;



    public void OnOff(bool _flag)
    {
        panel.gameObject.SetActive(_flag);
        sprite_DialogueBox.gameObject.SetActive(_flag);
        sprite_StandingCG.gameObject.SetActive(_flag);
        txt_Dialogue.gameObject.SetActive(_flag);
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

    private void NextDialogue()
    {
        txt_Dialogue.text = dialogue[count].dialogue;
        if(dialogue[count].characterNum == 1)
        {
            sprite_StandingCG.sprite = merry;
        }
        else if(dialogue[count].characterNum == 2)
        {
            sprite_StandingCG.sprite = martha;
        }
        else if (dialogue[count].characterNum == 3)
        {
            sprite_StandingCG.sprite = medlock;
        }
        count++;
    }
    void Update()
    {
        if (isDialogue)
        {
            if (Input.GetMouseButtonDown(0))
            {
                
                if (count < dialogue.Length)
                {
                    NextDialogue();

                }
                else
                    HideDialogue();
            }
        }
    }
}
