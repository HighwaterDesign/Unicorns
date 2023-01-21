using UnityEngine;

    [CreateAssetMenu(fileName = "DeckAudioClips", menuName = "ScriptableObjects/DeckAudioClips")]
    public class DeckAudioClips : ScriptableObject
    {
        public AudioClip[] pickUpSounds;
        public AudioClip[] dropDownSounds;
    }