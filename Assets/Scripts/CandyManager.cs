using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CandyManager : MonoBehaviour
{
    public TextMeshProUGUI candyAmountLabel;

    const int DefaultCandyAmount = 30;

    int candy = DefaultCandyAmount;

    public int Candy { get{return this.candy;} }

    public void ConsumeCandy()
    {
        if (candy > 0) candy -= 1;

        UpdateCandy();
    }

    // public int GetCandyAmount()
    // {
    //     return candy;
    // }

    public void AddCandy(int amount)
    {
        candy += amount;
        
        UpdateCandy();
    }

    // void OnGUI()
    // {
    //     GUI.color = Color.black;

    //     string label = "Candy : " + this.candy;
    //     GUI.Label(new Rect(50, 50, 100, 30), label);
    // }

    public void UpdateCandy()
    {
        candyAmountLabel.text = $"Candy : {candy}";   
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateCandy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
