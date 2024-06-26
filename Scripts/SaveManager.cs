/*
 * SaveManager.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 12/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class SaveManager
{
    private static readonly string SaveDirectory = Path.Combine(Application.persistentDataPath, "Data");
    private static readonly string WeaponsSavePath = Path.Combine(SaveDirectory, "Weapons.json");
    private static readonly string UpgradesSavePath = Path.Combine(SaveDirectory, "Upgrades.json");
    private static readonly string ItemsSavePath = Path.Combine(SaveDirectory, "Items.json");
    private static readonly string CharacterSavePath = Path.Combine(SaveDirectory, "Character.json");

    public static List<Weapon> GetWeapons() => LoadData<WeaponListWrapper, Weapon>(WeaponsSavePath);

    public static List<Upgrade> GetUpgrades() => LoadData<UpgradeListWrapper, Upgrade>(UpgradesSavePath);

    public static List<Item> GetItems() => LoadData<ItemListWrapper, Item>(ItemsSavePath);

    public static void SaveItems(List<Item> items)
    {
        EnsureDirectoryExists();
        string json = JsonUtility.ToJson(new ItemListWrapper { Items = items }, true);
        File.WriteAllText(ItemsSavePath, json);
    }

    public static void SaveItem(Item item)
    {
        var items = GetItems();
        items.Add(item);
        SaveItems(items);
    }

    public static void SaveWeapon(Weapon weapon)
    {
        var weapons = GetWeapons();
        weapons.Add(weapon);
        SaveWeapons(weapons);
    }

    public static void SaveUpgrade(Upgrade upgrade)
    {
        var upgrades = GetUpgrades();
        upgrades.Add(upgrade);
        SaveUpgrades(upgrades);
    }

    public static void SaveWeapons(List<Weapon> weapons)
    {
        EnsureDirectoryExists();
        string json = JsonUtility.ToJson(new WeaponListWrapper { Weapons = weapons }, true);
        File.WriteAllText(WeaponsSavePath, json);
    }

    public static void SaveUpgrades(List<Upgrade> upgrades)
    {
        EnsureDirectoryExists();
        string json = JsonUtility.ToJson(new UpgradeListWrapper { Upgrades = upgrades }, true);
        File.WriteAllText(UpgradesSavePath, json);
    }

    public static void SaveCharacter(Character character)
    {
        EnsureDirectoryExists();
        string json = JsonUtility.ToJson(character, true);
        File.WriteAllText(CharacterSavePath, json);
    }

    public static Character GetCharacter()
    {
        if (!File.Exists(CharacterSavePath))
            return null;

        string json = File.ReadAllText(CharacterSavePath);

        if (string.IsNullOrEmpty(json))
            return null;

        Character character = JsonUtility.FromJson<Character>(json);
        return character;
    }

    private static void EnsureDirectoryExists()
    {
        if (!Directory.Exists(SaveDirectory))
            Directory.CreateDirectory(SaveDirectory);
    }

    private static List<TItem> LoadData<TWrapper, TItem>(string path) where TWrapper : class, IItemListWrapper<TItem>, new()
    {
        if (!File.Exists(path))
            return new List<TItem>();

        string json = File.ReadAllText(path);

        if (string.IsNullOrEmpty(json))
            return new List<TItem>();

        TWrapper wrapper = JsonUtility.FromJson<TWrapper>(json);

        if (wrapper == null)
            return new List<TItem>();

        return wrapper.GetItems();
    }
}

[System.Serializable]
public class WeaponListWrapper : IItemListWrapper<Weapon>
{
    public List<Weapon> Weapons;

    public List<Weapon> GetItems()
    {
        return Weapons;
    }
}

[System.Serializable]
public class ItemListWrapper : IItemListWrapper<Item>
{
    public List<Item> Items;

    public List<Item> GetItems()
    {
        return Items;
    }
}

[System.Serializable]
public class UpgradeListWrapper : IItemListWrapper<Upgrade>
{
    public List<Upgrade> Upgrades;

    public List<Upgrade> GetItems()
    {
        return Upgrades;
    }
}

public interface IItemListWrapper<T>
{
    List<T> GetItems();
}