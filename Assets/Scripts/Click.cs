using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Click : MonoBehaviour
{
  [SerializeField]
  private TMP_Text TextCounter;

  [SerializeField]
  private int Multiplier = 1;

  [SerializeField]
  private Counter Counter;

  private void Update()
  {
    TextCounter.text = "Click : " + Counter.CounterValue;
  }

  private void OnMouseDown()
  {
    print("Clicked From Mouse Down");
    Counter.CounterValue += 1 * Multiplier;
    gameObject.GetComponent<SpriteRenderer>().flipX = !gameObject.GetComponent<SpriteRenderer>().flipX;
  }
}

