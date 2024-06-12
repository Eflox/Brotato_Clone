using Brotato_Clone.Models;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TestSaveManager : MonoBehaviour
{
    private string savePath;

    private void Start()
    {
        savePath = Path.Combine(Application.persistentDataPath, "TestWeapons.json");
        Debug.Log($"Save path: {savePath}");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Alpha1 key pressed");
            SaveTestWeapons();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("Alpha2 key pressed");
            LoadTestWeapons();
        }
    }

    private void SaveTestWeapons()
    {
        List<Weapon> weapons = new List<Weapon>
        {
            new Weapon
            {
                Name = "TestKnife",
                Damage = 10,
                Cooldown = 1.0f
            },
            new Weapon
            {
                Name = "TestFist",
                Damage = 5,
                Cooldown = 0.5f
            }
        };

        string json = JsonUtility.ToJson(new WeaponListWrapper { Weapons = weapons }, true);
        Debug.Log($"Saving weapons: {json}");
        File.WriteAllText(savePath, json);
    }

    private void LoadTestWeapons()
    {
        if (!File.Exists(savePath))
        {
            Debug.LogWarning("Save file does not exist.");
            return;
        }

        string json = File.ReadAllText(savePath);
        Debug.Log($"Loaded JSON: {json}");

        WeaponListWrapper weaponListWrapper = JsonUtility.FromJson<WeaponListWrapper>(json);

        if (weaponListWrapper == null || weaponListWrapper.Weapons == null)
        {
            Debug.LogWarning("Failed to deserialize weapons.");
            return;
        }

        Debug.Log($"Loaded {weaponListWrapper.Weapons.Count} weapons");
        foreach (var weapon in weaponListWrapper.Weapons)
        {
            Debug.Log($"Weapon: {weapon.Name}, Damage: {weapon.Damage}, Cooldown: {weapon.Cooldown}");
        }
    }

    [System.Serializable]
    private class WeaponListWrapper
    {
        public List<Weapon> Weapons;
    }
}