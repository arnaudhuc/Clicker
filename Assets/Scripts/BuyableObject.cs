using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BuyableObject : MonoBehaviour
{
  public int price;

  [SerializeField]
  private TMP_Text PriceText;

  [SerializeField]
  private Counter Counter;

  public bool isBuyable = true;

  private void Start()
  {
    PriceText.text = price.ToString();
  }
  private void OnMouseDown()
  {
    if (Counter.CounterValue >= price)
    {
      gameObject.GetComponent<SpriteRenderer>().color = Color.white;
      Counter.CounterValue -= price;
      Destroy(PriceText);
    }
  }
}
