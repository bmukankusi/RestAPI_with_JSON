using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


/// <summary>
/// Player data class
/// Store player data in a structured format
/// </summary>

[Serializable]
public class PlayerData
{
    public Record record;
    public Metadata metadata;
}

[Serializable]
public class Record
{
    public string playerName;
    public int level;
    public float health;
    public Position position;
    public List<InventoryItem> inventory;
}

[Serializable]
public class Position
{
    public float x, y, z;
}

[Serializable]
public class InventoryItem
{
    public string itemName;
    public int quantity;
    public float weight;
}

/// <summary>
/// Metadata class, store metadata information
/// </summary>
[Serializable]
public class Metadata
{
    public string id;
    public bool isPrivate;
    public string createdAt;
    public string name;
}
