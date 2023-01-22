using UnityEngine;
using WolfRPG.Core;

namespace Code
{
	public class TestMonoBehaviour: MonoBehaviour
	{
		[SerializeField] private RPGObjectReference characterReference;

		private void Awake()
		{
			// Load the RPGObject from the reference
			// The first time the asset is loaded from disk and deserialized, but it's cached afterwards
			IRPGObject character = characterReference.GetObject();
			
			// Use GetComponent to retrieve our data from the RPGObject
			ExampleComponent component = character.GetComponent<ExampleComponent>();

			// Unity assets are referenced with the AssetReference type
			AssetReference prefabReference = component.MyPrefab;

			// Retrieve the prefab from our prefab reference
			// The first time this loads the asset from the disk, but is cached in memory afterwards
			GameObject prefab = prefabReference.GetAsset<GameObject>();
			
			// Instantiate a GameObject from our prefab, using the normal Unity method, add a sprite object
			GameObject myGameObject = Instantiate(prefab);

			// Load the Sprite using the same method as before with the prefab
			AssetReference spriteReference = component.MySprite;
			Sprite sprite = spriteReference.GetAsset<Sprite>();
			
			// Add a spriteRenderer so we can render our sprite
			SpriteRenderer spriteRenderer = myGameObject.AddComponent<SpriteRenderer>();
			spriteRenderer.sprite = sprite;
		}
	}
}