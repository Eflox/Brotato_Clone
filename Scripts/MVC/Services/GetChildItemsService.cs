/*
 * GetChildItemService.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Brotato_Clone.Services
{
    public class GetChildItemsService
    {
        public NItem[] GetChildItems(NItem item)
        {
            if (item.Attribute == null)
            {
                Debug.LogWarning("The item has no attribute.");
                return null;
            }

            Type attributeType = item.Attribute.GetType();
            FieldInfo[] fields = attributeType.GetFields(BindingFlags.Public | BindingFlags.Instance);

            foreach (var field in fields)
            {
                var itemAttribute = field.GetCustomAttribute<ItemAttribute>();

                if (itemAttribute != null)
                {
                    var value = field.GetValue(item.Attribute) as string[];
                    if (value != null && value.Length > 0)
                    {
                        List<NItem> childItems = new List<NItem>();

                        foreach (var itemName in value)
                            if (ItemsData.Items.ContainsKey(itemName))
                                childItems.Add(ItemsData.Items[itemName]);
                            else
                                Debug.LogWarning($"Item {itemName} not found in ItemsData.");

                        return childItems.ToArray();
                    }
                }
            }

            return null;
        }
    }
}