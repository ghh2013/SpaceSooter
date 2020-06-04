using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DataInfo;

[CreateAssetMenu(fileName = "GameDataSO", menuName = "Create GameData", order = 1)]

public class GameDataObject : ScriptableObject
{
    public int killCount = 0;
    public float hp = 120.0f;
    public float damage = 25.0f;
    public float speed = 6.0f;
    public List<Item> equipItem = new List<Item>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
