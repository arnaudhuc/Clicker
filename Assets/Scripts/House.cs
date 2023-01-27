using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class House : MonoBehaviour
{
  [SerializeField]
  private TMP_Text TextCounter;
  [SerializeField]
  private int Multiplier = 1;
  [SerializeField]
  private Counter Counter;
  public int price;
  [SerializeField]
  private TMP_Text PriceText;
  [SerializeField]
  private GameObject Canvas;
  public bool isBuyable = true;
  public bool owned = false;

  private void Start()
  {
    if (PriceText)
    {
      PriceText.text = price.ToString();
    }
  }
  private void Update()
  {
    TextCounter.text = "Coins : " + Counter.CounterValue;
  }

  private void OnMouseDown()
  {
    if (isBuyable && Counter.CounterValue >= price)
    {
      gameObject.GetComponent<SpriteRenderer>().color = Color.white;
      Counter.CounterValue -= price;
      Destroy(Canvas);
      isBuyable = false;
      owned = true;
    }
    else if (!isBuyable)
    {
      AddToCounter();
    }
  }

  private void AddToCounter()
  {
    Counter.CounterValue += 1 * Multiplier;
    gameObject.GetComponent<SpriteRenderer>().flipX = !gameObject.GetComponent<SpriteRenderer>().flipX;
  }
}
