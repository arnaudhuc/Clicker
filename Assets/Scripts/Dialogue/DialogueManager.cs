using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DialogueManager : MonoBehaviour
{
  private Queue<string> sentences;
  public TMP_Text nameText;
  public TMP_Text dialogueText;
  public Animator animator;
  public int textSpeed = 50;

  // Start is called before the first frame update
  void Start()
  {
    sentences = new Queue<string>();
  }

  public void StartDialogue(Dialogue dialogue)
  {
    animator.SetBool("isOpen", true);
    nameText.text = dialogue.name;
    sentences.Clear();
    foreach (string sentence in dialogue.sentences)
    {
      sentences.Enqueue(sentence);
    }
    DisplayNextSentence();
  }

  public void DisplayNextSentence()
  {
    if (sentences.Count == 0)
    {
      EndDialogue();
      return;
    }
    textSpeed = 50;
    string sentence = sentences.Dequeue();

    StopAllCoroutines();
    StartCoroutine(TypeSentence(sentence));
  }

  IEnumerator TypeSentence(string sentence)
  {
    dialogueText.text = "";
    foreach (char letter in sentence.ToCharArray())
    {
      dialogueText.text += letter;
      System.Threading.Thread.Sleep(textSpeed);
      yield return null;
    }
  }

  void EndDialogue()
  {
    animator.SetBool("isOpen", false);
  }

  public void SetTextSpeedToMax()
  {
    textSpeed = 0;
  }
}
