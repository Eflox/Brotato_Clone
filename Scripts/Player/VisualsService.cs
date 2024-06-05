/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 29/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Controllers;
using UnityEngine;

public class VisualsService : MonoBehaviour
{
    private PlayerController _playerController;
    private SpriteRenderer _spriteRenderer;

    public void Init(PlayerController playerController)
    {
        //_playerController = playerController;

        //_spriteRenderer = gameObject.AddComponent<SpriteRenderer>();

        //_spriteRenderer.sortingOrder = 10;
        //foreach (var item in _playerController.Player.Items)
        //    if (item is ItemBase characterItem && characterItem.classes != null)
        //        foreach (var itemClass in characterItem.classes)
        //            if (itemClass == Class.Character)
        //                _spriteRenderer.sprite = characterItem.Icon;
    }

    private void OnDestroy()
    {
        Destroy(_spriteRenderer);
    }
}