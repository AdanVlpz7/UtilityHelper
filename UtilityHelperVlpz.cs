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
    
    #region Vector3
    public static Vector3 GenerateRandomPosition2D(float xRange, float yRange)
    {
        float spawnPosX = Random.Range(-xRange, xRange);
        float spawnPosY = Random.Range(-yRange, yRange);

        Vector3 randomPos = new Vector3(spawnPosX, spawnPosY,0);
        return randomPos;
    }        
    public static Vector3 GenerateRandomPosition(float xRange, float yRange, float zRange)
    {
        float spawnPosX = Random.Range(-xRange, xRange);
        float spawnPosY = Random.Range(-yRange, yRange);
        float spawnPosZ = Random.Range(-zRange, zRange);

        Vector3 randomPos = new Vector3(spawnPosX, spawnPosY, spawnPosZ);
        return randomPos;
    }

    #endregion
}
