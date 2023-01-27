using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinEverySecond : MonoBehaviour
{
  public Counter Counter;
  public int CoinPerSecond = 1, CoinPerSecondMultiplier = 1;

  private House House;
  void Start()
  {
    House = gameObject.GetComponent<House>();
    InvokeRepeating("AddCoin", 0f, 1f);
  }

  void AddCoin()
  {
    if (House.owned)
    {
      Counter.CounterValue += CoinPerSecond * CoinPerSecondMultiplier;
    }
  }
}
