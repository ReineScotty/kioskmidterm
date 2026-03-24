using UnityEngine;
using TMPro;

public class KioskManager : MonoBehaviour
{
    public TMP_Text cartCountText;

    private int itemCount = 0;
    private float cartTotal = 0f;

    void Start()
    {
        UpdateCartDisplay();
    }

    public void AddToCart(string itemName, float price)
    {
        itemCount++;
        cartTotal += price;
        Debug.Log("Added: " + itemName + " — $" + price.ToString("F2"));
        UpdateCartDisplay();
    }

    void UpdateCartDisplay()
    {
        if (itemCount == 0)
        {
            cartCountText.text = "No items yet";
        }
        else
        {
            cartCountText.text = itemCount + " item" + (itemCount > 1 ? "s" : "")
                                 + " · $" + cartTotal.ToString("F2");
        }
    }

    public void OnPlaceOrderPressed()
    {
        if (itemCount == 0)
        {
            Debug.Log("Cart is empty!");
            return;
        }
        Debug.Log("Order placed! " + itemCount + " items · $" + cartTotal.ToString("F2"));
        itemCount = 0;
        cartTotal = 0f;
        UpdateCartDisplay();
    }
}
