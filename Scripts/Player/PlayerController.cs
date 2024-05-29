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
    private InGameWeaponService _inGameWeaponService;
    private MovementService _movementService;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
            SceneManager.LoadScene("GameScene");
        if (Input.GetKeyUp(KeyCode.Alpha2))
            SceneManager.LoadScene("ShopScene");
        if (Input.GetKeyUp(KeyCode.Escape))
            QuitToCharacterSelection();
    }

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        _equipItemService = new EquipItemService(this);

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        switch (scene.name)
        {
            case "GameScene":
                EnterGameScene();
                break;
            case "ShopScene":
                LeaveGameScene();
                EnterShopScene();
                break;
        }
    }

    public void EnterGameScene()
    {
        Debug.Log("EnterGameScene");
        StatsUpdater.UpdateVisibleStats(Player.Stats);

        _inGameWeaponService = gameObject.AddComponent<InGameWeaponService>();
        _movementService = gameObject.AddComponent<MovementService>();
    }

    public void LeaveGameScene()
    {
        Debug.Log("LeaveGameScene");
        StatsUpdater.UpdateVisibleStats(Player.Stats);

        Destroy(_inGameWeaponService);
        Destroy(_movementService);

    }

    public void EnterShopScene()
    {
        Debug.Log("EnterShopScene");
        StatsUpdater.UpdateVisibleStats(Player.Stats);
    }

    public void EquipItem(ScriptableObject item)
    {
        _equipItemService.EquipItem(item);
        StatsUpdater.UpdateVisibleStats(Player.Stats);
    }

    public void QuitToCharacterSelection()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
        SceneManager.LoadScene("CharacterSelectionScene");
        Destroy(gameObject);

    }
}