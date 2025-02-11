using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoseProduct : MonoBehaviour
{
    public static ChoseProduct instance {get; private set;}
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
    public int totalCost;
    private string toStringTotalCost;
    public Text ProductDesc;
    public GameObject ProductPreviewPanel;
    public ChoseProduct choseProductScript;
    public ChooseProduct2 chooseProductScript2;

    void Awake(){
        if (instance == null)
        {
            instance = this;
        }
    }
    public void Update(){
        if(ProductTag.tag == "Product1"){
            ProductPrice = 10;
        }
        // else if(ProductTag.tag == "Product2"){
        //     ProductPrice = 100;
        // }

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
         if (chooseProductScript2.enabled && chooseProductScript2 != null){
            chooseProductScript2.enabled = false;
            choseProductScript.enabled =true;
        }
        ProductPreviewPanel.SetActive(true);
        if(ProductTag.tag == "Product1"){
            print("found nigga1");
            price = ProductPrice.ToString();
            ProductDesc.text = "Want more cafein???";
            ProductNameView.text = $"{ProductName.text}";
            PriceOfProduct.text = $"${price}";
            ImageOfProduct.sprite = SpriteForImageOfProduct;
            //TotalAmount = int.Parse(AmoutOfProduce.text);
            TotalProductCost.text = "Total Cost: " + $"${TotalAmount*ProductPrice}";
        }
        // else if(ProductTag.tag == "Product2"){
        //     print("found nigga2");
        //     ProductPrice = 100;
        //     price = ProductPrice.ToString();
        //     ProductDesc.text = "Is it? A Humannn?";
        //     ProductNameView.text = $"{ProductName.text}";
        //     PriceOfProduct.text = $"${price}";
        //     ImageOfProduct.sprite = SpriteForImageOfProduct;
        //     TotalAmount = int.Parse(AmoutOfProduce.text);
        //     TotalProductCost.text = "Total Cost: " + $"${TotalAmount*100}";
        // }
    }
    
}
