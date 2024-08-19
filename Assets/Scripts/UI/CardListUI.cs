using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CardListUI : MonoBehaviour
{
    public List<Card> cardList;

    private void Start()
    {
        DisableCardList();

        //ShowCardList();
    }


    public void ShowCardList()
    {
        GetComponent<RectTransform>().DOAnchorPosY(488,1);
        EnableCardList();
    }

    public void DisableCardList()
    {
        foreach(Card card in cardList)
        {
            card.DisableCard();
        }
    }
    void EnableCardList()
    {
        foreach (Card card in cardList)
        {
            card.EnableCard();
        }
    }
}
