using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMaterialColor : MonoBehaviour
{
    //refactoring this is a pain
    public Material background;
    public Material ball;
    public Material player;
    public Material enemy;

    public Text playerScore;
    public Text enemyScore;

    [System.Serializable]
    public class ColorPalette0
    {
        public Color pScore = new Color32();
        public Color eScore = new Color32();

        public Color32 bg = new Color32();
        public Color32 ball = new Color32();
        public Color32 player = new Color32();
        public Color32 enemy = new Color32();
    }
    public ColorPalette0 colorPalette0 = new ColorPalette0();

    [System.Serializable]
    public class ColorPalette1
    {
        public Color pScore = new Color32();
        public Color eScore = new Color32();

        public Color32 bg = new Color32();
        public Color32 ball = new Color32();
        public Color32 player = new Color32();
        public Color32 enemy = new Color32();
    }
    public ColorPalette1 colorPalette1 = new ColorPalette1();

    [System.Serializable]
    public class ColorPalette2
    {
        public Color pScore = new Color32();
        public Color eScore = new Color32();

        public Color32 bg = new Color32();
        public Color32 ball = new Color32();
        public Color32 player = new Color32();
        public Color32 enemy = new Color32();
    }
    public ColorPalette2 colorPalette2 = new ColorPalette2();

    public int colorPalette;

    void Start()
    {
        colorPalette = PlayerPrefs.GetInt("ColorPalette", 0);
    }

    private void Update()
    {
        PlayerPrefs.SetInt("ColorPalette", colorPalette);
    }

    void FixedUpdate()
    {
        if (colorPalette == 0)
        {
            playerScore.color = colorPalette0.pScore;
            enemyScore.color = colorPalette0.eScore;

            background.color = colorPalette0.bg;
            ball.color = colorPalette0.ball;
            player.color = colorPalette0.player;
            enemy.color = colorPalette0.enemy;
        }
        else if (colorPalette == 1)
        {
            playerScore.color = colorPalette1.pScore;
            enemyScore.color = colorPalette1.eScore;

            background.color = colorPalette1.bg;
            ball.color = colorPalette1.ball;
            player.color = colorPalette1.player;
            enemy.color = colorPalette1.enemy;
        }
        else if (colorPalette == 2)
        {
            playerScore.color = colorPalette2.pScore;
            enemyScore.color = colorPalette2.eScore;

            background.color = colorPalette2.bg;
            ball.color = colorPalette2.ball;
            player.color = colorPalette2.player;
            enemy.color = colorPalette2.enemy;
        }
    }

    public void ColorSwitcher()
    {
        colorPalette++;
        if(colorPalette > 2)
        {
            colorPalette = 0;
        }
    }

}
