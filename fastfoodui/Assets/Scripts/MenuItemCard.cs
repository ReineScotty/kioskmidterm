using UnityEngine;
using TMPro;

public class MenuItemCard : MonoBehaviour
{
    public string foodName = "Item Name";
    public float price = 0.00f;

    public TMP_Text foodNameText;
    public TMP_Text priceText;

    void Start()
    {
        foodNameText.text = foodName;
        priceText.text = "$" + price.ToString("F2");
    }

    public void OnAddToCartPressed()
    {
        KioskManager manager = FindObjectOfType<KioskManager>();
        if (manager != null)
        {
            manager.AddToCart(foodName, price);
        }
    }
}