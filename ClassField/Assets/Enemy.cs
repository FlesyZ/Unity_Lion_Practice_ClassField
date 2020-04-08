using UnityEngine;

public class Enemy : MonoBehaviour
{
    /// <summary>
    /// 怪物血量
    /// </summary>
    [Header("血量"), Tooltip("怪物的血量"), Range(50, 500)]
    public int health = 0;

    /// <summary>
    /// 怪物魔力
    /// </summary>
    [Header("魔力"), Tooltip("怪物的魔力"), Range(10, 100)]
    public int mana = 100;

    /// <summary>
    /// 能力值 - 速度
    /// </summary>
    [Header("能力值"), Range(1.0f, 50.5f)]
    public float speed = 10.5f;

    /// <summary>
    /// 能力值 - 攻擊力
    /// </summary>
    [Range(20, 200)]
    public int attack = 50;

    /// <summary>
    /// 能力值 - 防禦力
    /// </summary>
    [Range(0, 100)]
    public int defense;

    [Header("裝備")]
    /// <summary>
    /// 武器
    /// </summary>
    public string weapon;
    /// <summary>
    /// 裝備
    /// </summary>
    public string equip = "皮衣";

    /// <summary>
    /// 有無鑰匙
    /// </summary>
    [Header("其他資料")]
    [Tooltip("怪物是否帶有鑰匙")]
    public bool hasKey = false;

    /// <summary>
    /// 有無寶物
    /// </summary>
    [Tooltip("怪物是否帶有寶物")]
    public bool hasTreasure = false;
}
