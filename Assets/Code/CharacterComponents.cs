using UnityEngine;
using WolfRPG.Core;

namespace Code
{
	public class CharacterBaseProperties: IRPGComponent
	{
		public string CharacterName { get; set; }
		[AssetReference(typeof(Sprite))]
		public AssetReference Portrait { get; set; }
		
		public string[] ArrayTest { get; set; }
	}

	public class ExampleComponent : IRPGComponent
	{
		[AssetReference(typeof(Sprite))]
		public AssetReference MySprite { get; set; }
		
		[AssetReference(typeof(GameObject))]
		public AssetReference MyPrefab { get; set; }
	}

	public class CharacterProgression : IRPGComponent
	{
		public int BaseLevel { get; set; }
		public AnimationCurve XPCurve { get; set; }
	}

	public class MyTest : IRPGComponent
	{
		public TestClass[] MyTestClass { get; set; }
	}
}