using LeopotamGroup.Common;
using LeopotamGroup.Tutorials;
using UnityEngine;

namespace LeopotamGroup.Examples.TutorialsTest {
    public class TutorialsTest : MonoBehaviour {
        void Start () {
            // Tutorial progress saved for each scene separately,
            // you can reset it for all scenes with calling
            // TutorialManager.Instance.ClearAllData (true), or
            // for current screen with calling TutorialManager.SetAll(false).
            Service<TutorialManager>.Get ().SetAll (false);

            // Initiate tutorial sequence.
            Service<TutorialManager>.Get ().RaiseNextBit ();
        }
    }
}