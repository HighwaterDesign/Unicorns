using UnityEngine;

    [CreateAssetMenu(fileName = "DeckDescription", menuName = "ScriptableObjects/DeckDescription")]
    public class DeckDescription : ScriptableObject
    {
        public GameObject[] prefabs;

        public GameObject GetPrefab(RankEnum rank, SuitEnum suit)
        {
            if (prefabs == null)
                return null;

            if (suit == SuitEnum.Jokers)
            {
                var numJokers = prefabs.Length - 13 * 4;
                if (numJokers <= 0)
                    return null;
                return prefabs[13*4+((int)rank)%numJokers];
                
            }

            var index = ((int)suit) * 13 + (int)rank;
            if (prefabs.Length >= index)
                return null;

            return prefabs[index];
        }
    }
