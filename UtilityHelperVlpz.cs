using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Author: Miguel Adán Vargas López
 * GitHub: https://github.com/AdanVlpz7
 * Twitter: https://twitter.com/home
 */
public static class UtilityHelperVlpz
{
    #region UI methods
    public static void Pause(GameObject gameView, GameObject pauseMenu)
    {
        Time.timeScale = 0;
        gameView.SetActive(false);
        pauseMenu.SetActive(true);
    }

    public static void QuitPause(GameObject gameView, GameObject pauseMenu)
    {
        Time.timeScale = 1;
        gameView.SetActive(false);
        pauseMenu.SetActive(true);
    }
    #endregion

    #region Behaviors
    public static void ChangeColor(GameObject obj, Color color, bool randomColor)
    {
        #region readme if you need it.
        /* @attribute "obj" is defined by the object you want to change it's color.
         * @attribute "color" is defined by the color you want us to set to the "obj".
         * @attribute "randomColor" is true when you want us to set a random color.
         * 
         */
        #endregion

        if (randomColor == true)
        {
            color = new Color(Random.value, Random.value, Random.value);
        }
        obj.GetComponent<MeshRenderer>().material.color = color;
    }
    #endregion 
}
