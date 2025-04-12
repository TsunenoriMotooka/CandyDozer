using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CandyManager : MonoBehaviour
{
    public TextMeshProUGUI candyAmountLabel;

    const int DefaultCandyAmount = 30;
    const int RecoverSeconds = 10;

    int candy = DefaultCandyAmount;
    int counter;

    public int Candy { get{return this.candy;} }

    public void ConsumeCandy()
    {
        if (candy > 0) candy -= 1;

        UpdateUI();
    }

    // public int GetCandyAmount()
    // {
    //     return candy;
    // }

    public void AddCandy(int amount)
    {
        candy += amount;

        UpdateUI();
    }

    // void OnGUI()
    // {
    //     GUI.color = Color.black;

    //     string label = "Candy : " + this.candy;
    //     GUI.Label(new Rect(50, 50, 100, 30), label);
    // }

    public void UpdateUI()
    {
        candyAmountLabel.text = $"Candy : {candy} {(counter > 0 ? $"({counter}s)" : "")}";
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        if (candy < DefaultCandyAmount && counter <=0)
        {
            StartCoroutine(RecoverCandy());
        }
    }

    IEnumerator RecoverCandy()
    {
        counter = RecoverSeconds;
        UpdateUI();

        while (counter > 0)
        {
            yield return new WaitForSeconds(1.0f);
            counter--;
            UpdateUI();
        }

        candy++;
        UpdateUI();
    }
}
