using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class CharacterTests: InputTestFixture
{
    GameObject character = Resources.Load<GameObject>("Prefab/Character");
    Keyboard keyboard;
    public override void Setup()
    {
        SceneManager.LoadScene("Scenes/SimpleWalkTest");
        base.Setup();
        keyboard = InputSystem.AddDevice<Keyboard>();

        var mouse = InputSystem.AddDevice<Mouse>();
        Press(mouse.rightButton);
        Release(mouse.rightButton); ;
    }
    // A Test behaves as an ordinary method
    [UnityTest]
    public IEnumerator TestPlayerMoves()
    {
        GameObject characterInstance = GameObject.Instantiate(character, Vector3.zero, Quaternion.identity);
        Assert.That(characterInstance, !Is.Null);
        yield return new WaitForSeconds(1f);

        //Walk
        Press(keyboard.upArrowKey);
        yield return new WaitForSeconds(2f);
        Release(keyboard.upArrowKey);
        yield return new WaitForSeconds(0.5f);

        //Jump
        Press(keyboard.spaceKey);
        yield return new WaitForSeconds(1f);
        Release(keyboard.spaceKey);
        yield return new WaitForSeconds(0.5f);

        //Walk
        Press(keyboard.upArrowKey);
        yield return new WaitForSeconds(2f);
        Release(keyboard.upArrowKey);
        yield return new WaitForSeconds(0.5f);

        Assert.That(characterInstance.transform.GetChild(0).transform.position.z, Is.GreaterThan(1.5f));
    }

}
