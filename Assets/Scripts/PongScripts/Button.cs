using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    bool nextGameButtonPressed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NextLevelButtonPressed();
    }

    public void NextLevelButtonPressed() 
    {
        if (nextGameButtonPressed == true)
        {
            //TODO  Metodo para pausar/ desactivar el juego actual  dandole 2 o 3 segundos para ver el juego q ya no jugaras

            PONG.obj.TurnOffPong();    
        }
    }
}
