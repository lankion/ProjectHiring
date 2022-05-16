using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class KeyManager : GameManager
{
    private Key[] keyDefault; //Array to armazenate the keys data.
    private short cooldownColor = 1;
    private Color beenPressed, notPressed;
    void Start()
    {
        beenPressed = new Color(1.0f, 0.1f, 0.1f);
        notPressed = new Color(1.0f, 1.0f, 1.0f);
        StartTheKeys();
        UpdateTheKeys();
    }

    void Update()
    {
        if(Input.anyKeyDown) CheckInput(Input.inputString);
    }

    void StartTheKeys() //Get all the keys and they respective GOs.
    {
        keyDefault = new Key[8];

        keyDefault[0] = new Key("a", GameObject.Find("Letters/Canvas/00").GetComponent<TextMeshProUGUI>());
        keyDefault[1] = new Key("s", GameObject.Find("Letters/Canvas/01").GetComponent<TextMeshProUGUI>());
        keyDefault[2] = new Key("d", GameObject.Find("Letters/Canvas/02").GetComponent<TextMeshProUGUI>());
        keyDefault[3] = new Key("f", GameObject.Find("Letters/Canvas/03").GetComponent<TextMeshProUGUI>());
        keyDefault[4] = new Key("j", GameObject.Find("Letters/Canvas/04").GetComponent<TextMeshProUGUI>());
        keyDefault[5] = new Key("k", GameObject.Find("Letters/Canvas/05").GetComponent<TextMeshProUGUI>());
        keyDefault[6] = new Key("l", GameObject.Find("Letters/Canvas/06").GetComponent<TextMeshProUGUI>());
        keyDefault[7] = new Key("ç", GameObject.Find("Letters/Canvas/07").GetComponent<TextMeshProUGUI>());
    }

    void UpdateTheKeys() //Update in the scene the text with the key letter/character.
    {
        for (int i = 0; i < 8; i++)
        {
            keyDefault[i].tmp.GetComponent<TextMeshProUGUI>().SetText(keyDefault[i].button.ToUpper());
        }
    }

    public class Key //Class to organize and easily update the keys data.
    {
        [HideInInspector] public string button;
        [HideInInspector] public TextMeshProUGUI tmp;
        public Key(string b, TextMeshProUGUI g)
        {
            button = b;
            tmp = g;
        }

        public Key(string b)
        {
            button = b;
        }
    }

    void CheckInput(string keyPressed)
    {
        for (int i = 0; i < 8; i++)
        {
            if(keyPressed == keyDefault[i].button)
            {
                Debug.Log(keyDefault[i].button + " has been pressed.");
                StartCoroutine(ChangeTheColor(keyDefault[i].tmp));
                return;
            }
        }
        Debug.Log("A random key has been pressed");
    }

    IEnumerator ChangeTheColor(TextMeshProUGUI tmpToChange) //Change the color for some seconds and change back.
    {
        tmpToChange.color = beenPressed;
        yield return new WaitForSeconds(cooldownColor);
        tmpToChange.color = notPressed;
    }
}
