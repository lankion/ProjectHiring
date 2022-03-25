using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class KeyManager : GameManager
{
    private Key[] key; //Array to armazenate the keys data
    void Start()
    {
        StartTheKeys();
        UpdateTheKeys();
    }

    void Update()
    {
        CheckInput();
    }

    void StartTheKeys() //Get all the keys and they respective GOs
    {
        key = new Key[8];

        key[0] = new Key('A', GameObject.Find("Letters/Canvas/00"));
        key[1] = new Key('S', GameObject.Find("Letters/Canvas/01"));
        key[2] = new Key('D', GameObject.Find("Letters/Canvas/02"));
        key[3] = new Key('F', GameObject.Find("Letters/Canvas/03"));
        key[4] = new Key('J', GameObject.Find("Letters/Canvas/04"));
        key[5] = new Key('K', GameObject.Find("Letters/Canvas/05"));
        key[6] = new Key('L', GameObject.Find("Letters/Canvas/06"));
        key[7] = new Key('Ç', GameObject.Find("Letters/Canvas/07"));
    }

    void UpdateTheKeys() //Update in the scene the text with the key letter/character
    {
        for (int i = 0; i < 8; i++)
        {
            //Debug.Log(key[i].gObject.GetComponent<TextMeshProUGUI>());
            key[i].gObject.GetComponent<TextMeshProUGUI>().SetText(key[i].button.ToString());
        }
    }

    public class Key //Class to organize and easily update the keys data
    {
        [HideInInspector] public char button;
        [HideInInspector] public GameObject gObject;
        public Key(char b, GameObject g)
        {
            button = b;
            gObject = g;
        }

        public Key(char b)
        {
            button = b;
        }
    }

    public void CheckInput()
    {
        if(Input.anyKeyDown)
        {
            if(Input.GetButtonDown("key0"))
            {
                Debug.Log(key[0].button.ToString() + " has been pressed");
                return;
            }

            if(Input.GetButtonDown("key1"))
            {
                Debug.Log(key[1].button.ToString() + " has been pressed");
                return;
            }

            if(Input.GetButtonDown("key2"))
            {
                Debug.Log(key[2].button.ToString() + " has been pressed");
                return;
            }

            if(Input.GetButtonDown("key3"))
            {
                Debug.Log(key[3].button.ToString() + " has been pressed");
                return;
            }

            if(Input.GetButtonDown("key4"))
            {
                Debug.Log(key[4].button.ToString() + " has been pressed");
                return;
            }

            if(Input.GetButtonDown("key5"))
            {
                Debug.Log(key[5].button.ToString() + " has been pressed");
                return;
            }

            if(Input.GetButtonDown("key6"))
            {
                Debug.Log(key[6].button.ToString() + " has been pressed");
                return;
            }

            if(Input.GetButtonDown("key7"))
            {
                Debug.Log(key[7].button.ToString() + " has been pressed");
                return;
            }
            Debug.Log("A random key has been pressed");
        }
    }
}
