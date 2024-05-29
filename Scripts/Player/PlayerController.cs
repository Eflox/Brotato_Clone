/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Player Player;

    private List<(IWeapon, float, float)> _weaponTimers = new List<(IWeapon, float, float)>();

    private EquipItemService _equipItemService;

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        _equipItemService = new EquipItemService(this);

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        scene.name switch
        {
            "GameScene" => EnterGameScene(),
            "ShopScene" => EnterShopScene(),
        }
    }

    public void EnterGameScene()
    {
        StatsUpdater.UpdateVisibleStats(Player.Stats);
    }

    public void LeaveGameScene()
    {
        StatsUpdater.UpdateVisibleStats(Player.Stats);
    }

    public void EnterShopScene()
    {
        StatsUpdater.UpdateVisibleStats(Player.Stats);
    }

    public void LeaveShopScene()
    {
        StatsUpdater.UpdateVisibleStats(Player.Stats);
    }


    public void EquipItem(ScriptableObject item)
    {
        _equipItemService.EquipItem(item);
        StatsUpdater.UpdateVisibleStats(Player.Stats);
    }
}