using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [Header("怪物資訊")]
    public Enemy Enemy01;
    public Enemy Enemy02;

    private void Start()
    {
        print("怪物一號擁有了 " + Enemy01.mana + " 點魔力!");
        print("怪物二號穿著" + Enemy02.equip + "!");

        Enemy01.health = 100;
        Enemy02.health = 300;
        Enemy01.defense = 50;
        Enemy01.weapon = "木棍";
        Enemy02.weapon = "短刀";
        Enemy01.hasKey = true;
        Enemy02.hasTreasure = true;
    }
}
