using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public GameObject target;
    public GameObject dialogButton;
    
    private float dist;
    public float near;

    private bool interact = false; 

    private void Start()
    {
        ShowDialogButton(false);
    }

    public void ShowDialogButton(bool flag)
    {
        dialogButton.SetActive(flag);
    }

    private void Update()
    {
        dist = target.transform.position.x - transform.position.x;
        
        if (Mathf.Abs(dist) < near)
        {
            if (!interact)
            {
                ShowDialogButton(true);
            }
        }
        else
        {
            ShowDialogButton(false);
        }
    }
}
