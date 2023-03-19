using UnityEngine;
using WolfRPG.Core;
using WolfRPG.Inventory;

namespace Code
{
	public class TestInventory:  MonoBehaviour
	{
		[SerializeField] private RPGObjectReference[] items;
		[SerializeField] private InventoryPanelController inventoryPanel;

		private void Start()
		{
			var container = new ItemContainer();
			foreach (var item in items)
			{
				container.AddItem(item.GetObject());
			}
			
			inventoryPanel.Show(container);
		}
	}
}