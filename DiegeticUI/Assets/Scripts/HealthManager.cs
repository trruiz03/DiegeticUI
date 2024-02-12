using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{

    public Image damageScreen;
    public int life = 10;
    int maxLife;

    Color alphaColor;
    // Start is called before the first frame update
    void Start()
    {

        maxLife = life;
        alphaColor = damageScreen.color;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            doDamage();
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            Heal();
        }
    }

    public void doDamage()
    {

        maxLife--;

        if(life > 0 )
        {
            life--;
            alphaColor.a += .1f;
            damageScreen.color = alphaColor;
        }
        Debug.Log("Health: " + life);
    }

    public void Heal()
    {
        maxLife++;

        if(life < maxLife )
        {
            life++;
            alphaColor.a -= .1f;
            damageScreen.color = alphaColor;
            
        }
        Debug.Log("Health: " + life);
    }
}
