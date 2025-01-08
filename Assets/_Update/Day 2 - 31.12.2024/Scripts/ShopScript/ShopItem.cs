using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItem : MonoBehaviour
{
    public enum Items{
        Coffe,
        Human
    }
    public static int ItemsCost(Items items) {
        switch (items){
            default:
            case Items.Coffe:
                return 10;
            case Items.Human:
                return 100;
        }
    }
}
