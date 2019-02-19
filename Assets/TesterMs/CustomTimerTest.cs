using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class CustomTimerTest : MonoBehaviour {
    public int numTests = 1000000;

    private void OnGUI()
    {
        GUI.skin.button.fontSize = 50;
        if (GUI.Button(new Rect(0, 0, 400, 100), "Test"))
        {
            using (new CustomTimer("Empty Cycle Test", numTests))
            {
                TestFunction();
            }
        }
    }

    void TestFunction() {
        List<int> listOfInts = new List<int>();
        for (int i = 0; i < 1000000; i++)
            listOfInts.Add(i);
    }
}
