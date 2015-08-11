using UnityEngine;
using System.Collections;

public class CombatTextManager : MonoBehaviour
{
    public static float health;

    private static CombatTextManager instance;

    public GameObject textPrefab;

    public RectTransform canvasTransform;

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

    public void CreateText(Vector3 position)
    {
        GameObject sct = (GameObject)Instantiate(textPrefab, position, Quaternion.identity);

        sct.transform.SetParent(canvasTransform);
        sct.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
    }
}
