using UnityEngine;
using System.Collections;

public class PlayerHealthManager : MonoBehaviour {

    public int startingHealth;
    private int currentHealth;

    public float flashLenght;
    private float flashCounter;

    private Renderer rend;
    private Color storedColor;

	// Use this for initialization
	void Start () {
        currentHealth = startingHealth;
        rend = GetComponent<Renderer>();
        storedColor = rend.material.GetColor("_Color");
	}
	
	// Update is called once per frame
	void Update () {
        if(currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
	
        if(flashCounter > 0)
        {
            flashCounter -= Time.deltaTime;
            if(flashCounter <= 0)
            {
                rend.material.SetColor("_Color", storedColor);
            }
        }

	}

    public void HurtPlayer(int damageAmount)
    {
        currentHealth -= damageAmount;
        flashCounter = flashLenght;
        rend.material.SetColor("_Color", Color.red);
    }
}
