/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 29/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

public class VisualsService : MonoBehaviour
{
    private PlayerController _playerController;

    public void Init(PlayerController playerController)
    {
        _playerController = playerController;

        SpriteRenderer spriteRenderer = gameObject.AddComponent<SpriteRenderer>();

        foreach (var item in _playerController.Player.Items)
            if (item is ItemBase characterItem && characterItem.classes != null)
                foreach (var itemClass in characterItem.classes)
                    if (itemClass == Class.Character)
                        spriteRenderer.sprite = characterItem.Icon;
    }
}