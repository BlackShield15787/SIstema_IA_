using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI numEnemy;
    // public TextMeshProUGUI followText;

    private EnemigoAI[] enemies;
    private int following = 0;

    // Start is called before the first frame update
    void Start()
    {
        enemies = GetComponentsInChildren<EnemigoAI>();
    }

    // Update is called once per frame
    void Update()
    {
        numEnemy.text = "Enemigos: " + enemies.Length;
        //followText.text = "Te siguen " + following + " enemigos.";

        /*
        foreach(var enemy in enemies)
        {
            if(enemy.follow == true && following < 6)
            {
                following++;
            }
            if (enemy.follow == false && following > 0)
            {
                following--;
            }
        }*/
        
        
    }
}
