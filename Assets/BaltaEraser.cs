using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaltaEraser : MonoBehaviour
{
    private DialogueTrigger dialogueTrigger;
    private void Start()
    {
        dialogueTrigger = GetComponent<DialogueTrigger>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            StartCoroutine(NewSceneLoader.NextSceneAfterDialogue(dialogueTrigger, 2f));
        }
    }
}
