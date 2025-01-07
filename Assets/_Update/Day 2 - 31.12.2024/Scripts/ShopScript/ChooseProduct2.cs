using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseProduct2 : MonoBehaviour
{
    public GameObject ProductTag;
    public Text ProductName;
    public Text ProductNameView;
    public Text PriceOfProduct;
    public Image ImageOfProduct;
    public Sprite SpriteForImageOfProduct;
    public int ProductPrice;
    private string price;
    public InputField AmoutOfProduce;
    private int TotalAmount;
    public Text TotalProductCost;
    private int totalCost;
    private string toStringTotalCost;
    public Text ProductDesc;
    public GameObject ProductPreviewPanel;
    public ChoseProduct choseProductScript;
    
    public ChooseProduct2 chooseProductScript2;
    public void Update(){
        if(ProductTag.tag == "Product2"){
            ProductPrice = 100;
        }

        if (int.TryParse(AmoutOfProduce.text, out TotalAmount))
        {
            TotalAmount = int.Parse(AmoutOfProduce.text);
            totalCost = TotalAmount * ProductPrice;
            toStringTotalCost = totalCost.ToString();
            TotalProductCost.text = "Total Cost: $" + $"{toStringTotalCost}";
        }else
        {
            TotalProductCost.text = "Total Cost: $0";
        }
    }
    public void OnButtonClick(){
        ProductPreviewPanel.SetActive(true);
        if (choseProductScript.enabled && choseProductScript != null){
            choseProductScript.enabled = false;
            chooseProductScript2.enabled = true;
        }
        if(ProductTag.tag == "Product2"){
            print("found nigga2");
            price = ProductPrice.ToString();
            ProductDesc.text = "Is it? A Humannn?";
            ProductNameView.text = $"{ProductName.text}";
            PriceOfProduct.text = $"${price}";
            ImageOfProduct.sprite = SpriteForImageOfProduct;
            //TotalAmount = int.Parse(AmoutOfProduce.text);
            TotalProductCost.text = "Total Cost: " + $"${TotalAmount*100}";
        }
    }
}
