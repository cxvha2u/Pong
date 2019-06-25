using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMaterialColor : MonoBehaviour
{
    public Material background;
    public Material ball;
    public Material wall;
    public Material deadZone;

    public Text playerScore;
    public Text enemyScore;

    [System.Serializable]
    public class ColorPalette0
    {
        public Color pScore = new Color(1, 1, 1, .5f);
        public Color eScore = new Color(0.6666667f, 0.2117647f, 0.2235294f, .5f);

        public Color32 bg = new Color32();
        public Color32 ball = new Color32();
        public Color32 wall = new Color32();
        public Color32 dz = new Color32();
    }
    public ColorPalette0 colorPalette0 = new ColorPalette0();

    [System.Serializable]
    public class ColorPalette1
    {
        public Color pScore = new Color(0, 0, 0, .5f);
        public Color eScore = new Color(0.8207547f, 0.2745098f, 0.2745098f, .5f);

        public Color32 bg = new Color32();
        public Color32 ball = new Color32();
        public Color32 wall = new Color32();
        public Color32 dz = new Color32();
    }
    public ColorPalette1 colorPalette1 = new ColorPalette1();

    [System.Serializable]
    public class ColorPalette2
    {
        public Color pScore = new Color(1, 1, 1, 1);
        public Color eScore = new Color(1, 1, 1, 1);

        public Color32 bg = new Color32();
        public Color32 ball = new Color32();
        public Color32 wall = new Color32();
        public Color32 dz = new Color32();
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
            wall.color = colorPalette0.wall;
            deadZone.color = colorPalette0.dz;
        }
        else if (colorPalette == 1)
        {
            playerScore.color = colorPalette1.pScore;
            enemyScore.color = colorPalette1.eScore;

            background.color = colorPalette1.bg;
            ball.color = colorPalette1.ball;
            wall.color = colorPalette1.wall;
            deadZone.color = colorPalette1.dz;
        }
        else if (colorPalette == 2)
        {
            playerScore.color = colorPalette2.pScore;
            enemyScore.color = colorPalette2.eScore;

            background.color = colorPalette2.bg;
            ball.color = colorPalette2.ball;
            wall.color = colorPalette2.wall;
            deadZone.color = colorPalette2.dz;
        }
    }

}
