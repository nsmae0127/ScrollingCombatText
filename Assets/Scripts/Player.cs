using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed;

    private bool onCD;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CombatTextManager.Instance.CreateText(transform.position, "Hello", Color.white, false);
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            CombatTextManager.Instance.CreateText(transform.position, "Hello", Color.white, true);
        }

        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        transform.Translate(new Vector3(horizontal, vertical) * speed * Time.deltaTime);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == "Fire")
        {
            if (!onCD)
            {
                StartCoroutine(CoolDownDamage());
                int random = Random.Range(0, 2);
                if (random == 0)
                {
                    int rndDmg = Random.Range(3, 10);
                    CombatTextManager.Instance.CreateText(transform.position, "-" + rndDmg.ToString(), Color.red, false);
                } else
                {
                    int rndDmg = Random.Range(11, 20);
                    CombatTextManager.Instance.CreateText(transform.position, "-" + rndDmg.ToString(), Color.red, false);
                }
            }
        } else if (other.name == "Heart")
        {
            if (!onCD)
            {
                StartCoroutine(CoolDownDamage());
                int random = Random.Range(0, 2);
                if (random == 0)
                {
                    int rndDmg = Random.Range(3, 10);
                    CombatTextManager.Instance.CreateText(transform.position, "+" + rndDmg.ToString(), Color.green, false);
                } else
                {
                    int rndDmg = Random.Range(11, 20);
                    CombatTextManager.Instance.CreateText(transform.position, "+" + rndDmg.ToString(), Color.green, true);
                }
            }
        }
    }

    private IEnumerator CoolDownDamage()
    {
        onCD = true;
        yield return new WaitForSeconds(3);
        onCD = false;
    }
}
