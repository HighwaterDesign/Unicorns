using UnityEditor;
using UnityEngine;

namespace FlexiblePlayingCards
{
    [CustomEditor(typeof(CardController))]
    public class CardControllerCustomEditor: Editor
    {
        public override void OnInspectorGUI()
        {
            CardController cardController = (CardController)target;

            DrawDefaultInspector();

            if (GUILayout.Button("Update Collider Size"))
            {
                cardController.UpdateColliderSize();
            }
        }
    }
}