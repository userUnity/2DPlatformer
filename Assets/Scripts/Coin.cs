using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public void PickUp()
    {
        gameObject.SetActive(false);
    }
}
