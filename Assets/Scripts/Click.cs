using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Click : MonoBehaviour
{
  [SerializeField]
  public TMP_Text TextCounter;
  public int Counter, Multiplier = 1;

  private void Update()
  {
    TextCounter.text = "Click : " + Counter;
  }

  public void OnClick()
  {
    Counter += 1 * Multiplier;
  }
}
