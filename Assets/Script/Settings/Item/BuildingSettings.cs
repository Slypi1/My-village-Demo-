using UnityEngine;

namespace Script.Settings.Item
{
   [CreateAssetMenu(fileName = "EnvironmentSettings", menuName = "EnvironmentSettings/BuildingsSettings", order = 1)]
   public class BuildingSettings : ScriptableObject
   {
      [SerializeField] private Sprite _icon;
      [SerializeField] private House _housePrefab;
      [SerializeField] private Vector2Int _size;

      public House BuildingPrefab => _housePrefab;
      public Sprite Icon => _icon;
      public Vector2Int Size => _size;
   }
}
