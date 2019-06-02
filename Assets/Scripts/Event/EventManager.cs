using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public GameObject target;
    public GameObject dialogButton;

    private GameObject _obj;
    private float dist;
    public float near;

    private bool interact = false; 

    private void Start()
    {
        _obj = Instantiate(dialogButton, transform.position + Vector3.up * 6.5f, Quaternion.identity) as GameObject;
        ShowDialogButton(false);
    }

    public void ShowDialogButton(bool flag)
    {
        _obj.SetActive(flag);
    }

    private void Update()
    {
        dist = target.transform.position.x - transform.position.x;
        Debug.Log(dist);
        
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
