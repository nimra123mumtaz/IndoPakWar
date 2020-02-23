using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newgame : MonoBehaviour
{
    public void TakeNewGame(string scenename)
    {
        Application.LoadLevel(scenename);
    }



    public void OptionMenu(string scenename)
    {
        Application.LoadLevel(scenename);
    }


    public void BackToMenu(string scenename)
    {
        Application.LoadLevel(scenename);
    }
}
