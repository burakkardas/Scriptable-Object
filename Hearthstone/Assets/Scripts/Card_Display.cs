using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Card_Display : MonoBehaviour
{
    public Card card;

    public TMP_Text cardName;
    public TMP_Text cardDescription;

    public Image cardImage;

    public TMP_Text cardMana;
    public TMP_Text cardAttack;
    public TMP_Text cardHealt;
    void Start()
    {
        cardName.text = card.name;
        cardDescription.text = card.description;

        cardImage.sprite = card.artwork;

        cardMana.text = card.mana.ToString();
        cardAttack.text = card.attack.ToString();
        cardHealt.text = card.healht.ToString();
    }
}
