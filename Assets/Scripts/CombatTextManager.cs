﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CombatTextManager : MonoBehaviour
{
    public static float health;

    private static CombatTextManager instance;

    public GameObject textPrefab;

    public RectTransform canvasTransform;

    public float speed;

    public float fadeTime;

    public Vector3 direction;

    public GameObject player;

    public static CombatTextManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<CombatTextManager>();
            }

            return instance;
        }
    }

    public void CreateText(Vector3 position, string text, Color color, bool crit)
    {
        GameObject sct = (GameObject) Instantiate(textPrefab, position, Quaternion.identity);

        sct.transform.SetParent(canvasTransform);
        sct.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        sct.GetComponent<CombatText>().Initialize(speed, direction, fadeTime, crit);
        sct.GetComponent<Text>().text = text;
        sct.GetComponent<Text>().color = color;

    }
}