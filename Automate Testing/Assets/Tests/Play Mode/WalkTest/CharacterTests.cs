using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using Cinemachine;
public class CharacterTests: InputTestFixture
{
    GameObject character = Resources.Load<GameObject>("Prefab/Character");
    Keyboard keyboard;
    CinemachineVirtualCamera camera;
    Transform playerCamRoot;
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
    [UnityTest, Order(1)]
    public IEnumerator TestPlayerMoves()
    {
        camera = GameObject.Find("PlayerFollowCamera").GetComponent<CinemachineVirtualCamera>();
        GameObject characterInstance = GameObject.Instantiate(character, Vector3.zero, Quaternion.identity);
        playerCamRoot = characterInstance.transform.GetChild(0);
        camera.Follow = playerCamRoot;

        Assert.That(characterInstance, !Is.Null);
        Assert.That(playerCamRoot, !Is.Null);
        Assert.That(camera, !Is.Null);

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

        //Run Left
        Press(keyboard.upArrowKey);
        Press(keyboard.leftArrowKey);
        Press(keyboard.shiftKey);
        yield return new WaitForSeconds(1f);
        Release(keyboard.upArrowKey);
        Release(keyboard.leftArrowKey);
        Release(keyboard.shiftKey);
        yield return new WaitForSeconds(0.5f);

        //Run Right
        Press(keyboard.upArrowKey);
        Press(keyboard.rightArrowKey);
        Press(keyboard.shiftKey);
        yield return new WaitForSeconds(1.5f);
        Release(keyboard.upArrowKey);
        Release(keyboard.rightArrowKey);
        Release(keyboard.shiftKey);
        yield return new WaitForSeconds(1f);

        //Jump
        Press(keyboard.spaceKey);
        yield return new WaitForSeconds(0.7f);
        Release(keyboard.spaceKey);
        yield return new WaitForSeconds(1f);


        Assert.That(characterInstance.transform.GetChild(0).transform.position.z, Is.GreaterThan(1.5f));
    }

}
