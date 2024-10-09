using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DisplayGhost : MonoBehaviour
{
    [SerializeField] private GameObject ghost;
    [SerializeField] private TextMeshPro ghostMessage;
    [SerializeField] private AudioSource audioSource;


    private string messageText = "Find the book of evil...";
    private char[] messageTextSplit;
    private char[] messageTextToPrintSplit;
    private bool isPrinting = false;
    private float printDelay = 0.1f;

    public void Activate()
    {
        ghost.SetActive(true);
        audioSource.Play();

        messageTextSplit = messageText.ToCharArray();
        messageTextToPrintSplit = new char[messageTextSplit.Length];
        StartCoroutine(PrintMessageText());
    }

    public void Deactivate()
    {
        ghost.SetActive(false);
        ghostMessage.SetText("");
    }

    IEnumerator PrintMessageText()
    {
        for(int i = 0; i < messageTextSplit.Length; i++)
        {
            messageTextToPrintSplit[i] = messageTextSplit[i];
            string messageTextToPrint = new string(messageTextToPrintSplit);
            ghostMessage.SetText(messageTextToPrint);
            yield return new WaitForSeconds(printDelay);
        }
    }
}

