using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyableObject : MonoBehaviour
{
  [SerializeField]
  private int price;

  private void OnMouseDown()
  {
    gameObject.GetComponent<SpriteRenderer>().color = Color.white;
  }
}
