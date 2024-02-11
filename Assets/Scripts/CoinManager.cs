using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{

    [SerializeField] private int _numberOfCoinsInLevel;
    [SerializeField] private TextMeshProUGUI _text;
    public void AddOne()
    {
        _numberOfCoinsInLevel += 1;
        _text.text = _numberOfCoinsInLevel.ToString();
    }

}
