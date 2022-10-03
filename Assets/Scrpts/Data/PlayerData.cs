using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerData
{
    public static int LevelID {
        get => PlayerPrefs.GetInt("LevelID", 0); set => PlayerPrefs.SetInt("LevelID", value); }
}
