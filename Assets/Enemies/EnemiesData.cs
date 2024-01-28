using UnityEngine;
[CreateAssetMenu (fileName = "Data", menuName = "ScriptableObjects/Enemy", order = 1)]
public class EnemiesData : ScriptableObject
{
    public int hp;
    public int damage;
    public float speed;
}
