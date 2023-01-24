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

  [SerializeField]
  private BuyableObject? BuyableObject;

  private void Update()
  {
    TextCounter.text = "Click : " + Counter.CounterValue;
  }

  private void OnMouseDown()
  {
    if (BuyableObject != null && BuyableObject.isBuyable && BuyableObject.price >= Counter.CounterValue)
    {
      print("not Buyable");
      BuyableObject.isBuyable = !(BuyableObject.isBuyable && BuyableObject.price >= Counter.CounterValue);
    }
    else
    {
      print("Clicked From Mouse Down");
      Counter.CounterValue += 1 * Multiplier;
      gameObject.GetComponent<SpriteRenderer>().flipX = !gameObject.GetComponent<SpriteRenderer>().flipX;
    }

  }
}

